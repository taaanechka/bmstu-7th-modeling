from Generator import Generator
from Processor import Processor

class Model:
    def __init__(self, generator: Generator, operators: list[Processor], computers: list[Processor]):
        self._generator = generator
        self._operators = operators
        self._computers = computers

    # n0 - число обслуженных клиентов
    def start_event(self) -> dict[str, float]:
        generator = self._generator
        n0 = 0
        n1 = 0

        generator.receivers = self._operators.copy()
        self._operators[0].receivers = [self._computers[0]]
        self._operators[1].receivers = [self._computers[1]]
        self._operators[2].receivers = [self._computers[2]]
        self._operators[3].receivers = [self._computers[2]]

        generator.next = generator.next_time()
        self._operators[0].next = self._operators[0].next_time()


        blocks = [ generator ] + self._operators + self._computers

        n_done = 0
        n_requests = generator.num_requests

        while n_done < n_requests:
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
                        if block.curr_q_size == 0:
                            block.next = 0
                        else:
                            block.next = curr_t + block.next_time()
            n_done = 0
            for item in self._computers: 
                n_done += item.processed_requests

        max_q_size = []

        for item in self._operators:
            max_q_size.append(item.max_size)
        for item in self._computers:
            max_q_size.append(item.max_size)

        done_arr = []

        for item in self._operators:
            done_arr.append(item.processed_requests)
        for item in self._computers:
            done_arr.append(item.processed_requests)
         
        return {"max_q_size": max_q_size,
                "time": curr_t,
                "done": n_done,
                "done_arr": done_arr,
                "arrived": n0
                }