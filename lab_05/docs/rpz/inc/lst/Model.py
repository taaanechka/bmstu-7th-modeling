from Generator import Generator
from Processor import Processor

class Model:
    def __init__(self, generator: Generator, operators: list[Processor], computers: list[Processor]):
        self._generator = generator
        self._operators = operators
        self._computers = computers

    # n0 - число обслуженных клиентов
    # n1 - число клиентов, получивших отказ
    # n = n0 + n1  - общее число заявок (generated_requests)
    def start_event(self) -> dict[str, float]:
        generator = self._generator
        generated_requests = generator.num_requests
        n0 = 0
        n1 = 0

        generator.receivers = self._operators.copy()
        self._operators[0].receivers = [self._computers[0]]
        self._operators[1].receivers = [self._computers[0]]
        self._operators[2].receivers = [self._computers[1]]

        generator.next = generator.next_time()
        self._operators[0].next = self._operators[0].next_time()

        blocks = [
            generator,
            self._operators[0],
            self._operators[1],
            self._operators[2],
            self._computers[0],
            self._computers[1],
        ]

        while generator.num_requests >= 0:
            # находим наименьшее время
            curr_t = generator.next
            for block in blocks:
                if 0 < block.next < curr_t:
                    curr_t = block.next

            # для каждого из блоков
            for block in blocks:
                # если событие наступило для этого блока
                if curr_t == block.next:
                    if not isinstance(block, Processor):
                        # для генератора 
                        # проверяем, может ли оператор обработать
                        next_generator = generator.generate_request()
                        if next_generator is not None:
                            next_generator.next = \
                                curr_t + next_generator.next_time()
                            n0 += 1
                        else:
                            n1 += 1
                        generator.next = curr_t + generator.next_time()
                    else:
                        block.process_request()
                        if block.curr_queue_size == 0:
                            block.next = 0
                        else:
                            block.next = curr_t + block.next_time()
         
        return {"refusal_percentage": n1 / generated_requests * 100,
                "processed": n0,
                "refused": n1,
                }