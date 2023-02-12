import numpy.random as nprand
import random as rand


class UniformDistribution:
    def __init__(self, a: float, b: float):
        self.a = a
        self.b = b

    def generate(self):
        return self.a + (self.b - self.a) * rand.random()


class PoissonDistribution:
    def __init__(self, lam : float):
        self.lam = lam

    def generate(self):
        return nprand.poisson(self.lam)