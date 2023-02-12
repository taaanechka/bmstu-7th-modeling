class Generator:
    def __init__(self, generator, count: int):
        self._generator = generator
        self.receivers = []
        self.num_requests = count
        self.next = 0 

    def next_time(self):
        return self._generator.generate()
    
    def generate_request(self):
        self.num_requests -= 1
        min_receiver = self.receivers[0]
        min_q_size = self.receivers[0].curr_q_size

        for i in range(1, len(self.receivers)):
            curr_r = self.receivers[i]
            if curr_r.curr_q_size < min_q_size: 
                min_q_size = curr_r.curr_q_size
                min_receiver = curr_r

        min_receiver.receive_request()
        
        return min_receiver