# Randomizer
# To generate random numbers - linear congurent method


# consts
# K             C           N
# 4096          150889      714025
# 36261         66037       312500
# 84589         45989       217728

# 1664525       1013904223  2^32
# 22695477      1           2^32
# 1103515245    12345       2^31 

class Randomizer:
    def __init__(self, seed = 10):
        self.current = seed

        self.N = 217728
        self.C = 45989
        self.K = 84589

    def get_number(self, low = 0, high = 100) -> int:
        self.current = (self.K * self.current + self.C) % self.N
        res = int(low + self.current % (high - low))

        return res