from Generator import Generator

class Processor(Generator):
    def __init__(self, generator):
        self._generator = generator
        self.curr_q_size = 0
        self.max_size = 0
        self.processed_requests = 0
        self.received_requests  = 0
        self.next = 0
        self.receivers = []

    # обрабатываем запрос, если они есть
    def process_request(self):
        if self.curr_q_size > 0:
            self.processed_requests += 1
            self.curr_q_size -= 1

        if len(self.receivers) != 0:
            min_receiver = self.receivers[0]
            min_q_size = self.receivers[0].curr_q_size

            for receiver in self.receivers:
                if receiver.curr_q_size < min_q_size: 
                    min_q_size = receiver.curr_q_size
                    min_receiver = receiver

            min_receiver.receive_request()
            min_receiver.next  = self.next + min_receiver.next_time()
    
    # добавляем реквест в очередь
    def receive_request(self):
        self.curr_q_size += 1
        self.received_requests += 1

        if self.max_size < self.curr_q_size:
            self.max_size = self.curr_q_size

        return True
        

    def next_time(self):
        return self._generator.generate()