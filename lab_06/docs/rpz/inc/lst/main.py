from Model import Model
from Generator import Generator
from Distribute import UniformDistribution
from Processor import Processor

from prettytable import PrettyTable


def create_operators(distribution, t_proc: list[list[int]], n: int) -> list[Processor]:
    operators = list()

    for i in range(n):
        operators.append(Processor(
                    distribution(t_proc[i][0] - t_proc[i][1], t_proc[i][0] + t_proc[i][1]))
                    )
    return operators

def create_computers(distribution, t_proc: list[int], n: int) -> list[Processor]:
    comps = list()

    for i in range(n):
        comps.append(Processor(
                    distribution(t_proc[i], t_proc[i])) )
    return comps


def create_table(data: dict[str, float], operators_n: int, computers_n: int, clients_number: int):
    table = PrettyTable()
    table.add_column('Элементы', [('Оператор '+ str(i + 1)) for i in range(operators_n)] + [('Компьютер ' + str(i + 1)) for i in range(computers_n)])
    table.add_column('max очередь', data['max_q_size'])
    table.add_column('Обработано', data['done_arr'])

    print("Кол-во заявок:       ", clients_number)
    print("Время работы сис-мы:  " + str(data['time']))
    print(table)


if __name__ == '__main__':
    clients_number = 600

    generator = Generator(
        UniformDistribution(0, 3),
        clients_number,
    )

    t_proc_op = list()
    t_proc_op.append([3, 1]) # t_i, dt_i
    t_proc_op.append([4, 2])
    t_proc_op.append([5, 3])
    t_proc_op.append([8, 4])

    operators = create_operators(UniformDistribution, t_proc_op, len(t_proc_op))

    t_proc_comp = [1, 2, 3]

    computers = create_computers(UniformDistribution, t_proc_comp, len(t_proc_comp))

    model = Model(generator, operators, computers)
    res = model.start_event()

    create_table(res, len(operators), len(computers), clients_number)
    