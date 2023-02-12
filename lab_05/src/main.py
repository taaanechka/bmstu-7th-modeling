from Model import Model
from Generator import Generator
from Distribute import UniformDistribution
from Processor import Processor

from prettytable import PrettyTable


def create_operators(distribution, t_proc: list[list[int]], n: int, max_q: int = 1) -> list[Processor]:
    operators = list()

    for i in range(n):
        operators.append(Processor(
                    distribution(t_proc[i][0] - t_proc[i][1], t_proc[i][0] + t_proc[i][1]),
                    max_queue = max_q)
                    )
    return operators

def create_computers(distribution, t_proc: list[int], n: int) -> list[Processor]:
    comps = list()

    for i in range(n):
        comps.append(Processor(
                    distribution(t_proc[i], t_proc[i]), ) )
    return comps


def create_table(data: dict[str, float]):
    table = PrettyTable()
    table.field_names = ['Кол-во заявок', 'Кол-во обработаных заявок', 'Кол-во отказов', 'Процент отказа']

    table.add_row([clients_number, data['processed'], data['refused'] - 1, data["refusal_percentage"]])

    print(table)


if __name__ == '__main__':
    clients_number = 300

    generator = Generator(
        UniformDistribution(8, 12),
        clients_number,
    )

    t_proc_op = list()
    t_proc_op.append([20, 5]) # t_i, dt_i
    t_proc_op.append([40, 10])
    t_proc_op.append([40, 20])

    operators = create_operators(UniformDistribution, t_proc_op, len(t_proc_op))

    t_proc_comp = [15, 30]

    computers = create_computers(UniformDistribution, t_proc_comp, len(t_proc_comp))

    model = Model(generator, operators, computers)
    res = model.start_event()

    create_table(res)
    