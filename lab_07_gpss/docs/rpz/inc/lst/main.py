from event_model import event_model
from deltaT_model import deltaT_model

from distribute import UniformDistribution, PoissonDistribution

def main():
    a, b = 1, 10
    generator = UniformDistribution(a, b)

    lam = 6.0
    processor = PoissonDistribution(lam)

    total_tasks = 1000
    step = 0.01

    repeat_percent = float(input("Введите процент повторных заявок: "))

    print("\nМаксимальная длина очереди")
    
    print('Принцип delta_t   : ', deltaT_model(generator, processor, total_tasks, repeat_percent, step))
    print('Событийный принцип: ', event_model(generator, processor, total_tasks, repeat_percent))


if __name__ == '__main__':
    main()