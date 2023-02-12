from Randomizer import Randomizer

from itertools import islice
from math import factorial
import numpy as np

from prettytable import PrettyTable
import matplotlib.pyplot as plt

NUMB_COUNT = 5000

def read_table_data(filename, count) -> set[int]:
    numbers = set()
    
    with open(filename) as file: 
        line_num = 0
        lines = islice(file, line_num, None)

        for l in lines:
            numbers.update(set(l.split(" ")[1:-1]))

            if len(numbers) >= count + 1:
                break

            line_num += 1

        numbers.remove("") 
        numbers = list(numbers)[:count]

    return numbers


def tabular_method(filename, count = NUMB_COUNT):
    numbers = read_table_data(filename, 3 * count)

    single_digit = [int(i) % 10 for i in numbers[:count]]
    double_digit = [int(i) % 90 + 10 for i in numbers[count:count * 2]]
    three_digit = [int(i) % 900 + 100 for i in numbers[count * 2:3 * count]]

    return single_digit, double_digit, three_digit


def algorithmic_method(seed = 10, count = NUMB_COUNT):
    rnd = Randomizer(seed)

    single_digit = [rnd.get_number(0, 10) for i in range(count)]
    double_digit = [rnd.get_number(10, 100) for i in range(count)]
    three_digit = [rnd.get_number(100, 1000) for i in range(count)]

    return  single_digit, double_digit, three_digit


def get_hi(arr, n) -> int:
    r = 0

    arr_len = len(arr)

    for i in range(arr_len):
        if i == arr_len - 1:
            p = (1 / factorial(i + 1))
        else:
            p = (1 / factorial(i + 1) - 1 / factorial(i + 1 + 1))
        
        r += arr[i] * arr[i] / p

    r = r / n - n

    return r


def monotonicity_cr(arr):
    tabs = np.zeros(6, dtype='int64')

    i = 0
    length = 1

    while i < len(arr):
        if (i == len(arr) - 1) or (arr[i] > arr[i + 1]):
            j = 5 if length >= 6 else length - 1
            tabs[j] += 1

            i += 1
            length = 0

        i += 1
        length += 1

    n = sum(i * tabs[i] for i in range(len(tabs)))

    return get_hi(tabs, n)


def draw_arr(arr, axis, i, j, name, clr = "blue"):
    axis[i][j].set_title(f"{name} {j+1}")
    axis[i][j].hist(arr, color = clr)


def draw_all(tbls, algs):
    fig, axis = plt.subplots(2, 3, figsize = (12,7))

    for i in range(len(tbls)):
        draw_arr(tbls[i], axis, 0, i, "Табличный", clr = "lightgreen")

    for i in range(len(algs)):
        draw_arr(algs[i], axis, 1, i, "Алгоритмический", clr = "lightblue")

    plt.show()


def main():
    step = int(NUMB_COUNT / 10)
    numbers = [i for i in range(0, NUMB_COUNT, step)]

    io_arr = [1, 9, 1, 9, 1, 9, 1, 9, 1, 9]
    single_tbl, double_tbl, three_tbl = tabular_method("table_data.txt")
    single_alg, double_alg, three_alg = algorithmic_method(seed = 100, count = NUMB_COUNT)

    table_tbl = PrettyTable()

    table_tbl.add_column("№", numbers)

    table_tbl.add_column('1 разряд', io_arr)

    table_tbl.add_column('1 разряд', single_tbl[::step])
    table_tbl.add_column('2 разряд', double_tbl[::step])
    table_tbl.add_column('3 разряд', three_tbl[::step])
        
    table_tbl.add_column('1 разряд', single_alg[::step])
    table_tbl.add_column('2 разряд', double_alg[::step])
    table_tbl.add_column('3 разряд', three_alg[::step])
    
    table_tbl.add_row(['коэф',
                        monotonicity_cr(io_arr),
                        monotonicity_cr(single_tbl),
                        monotonicity_cr(double_tbl),
                        monotonicity_cr(three_tbl),
                        monotonicity_cr(single_alg),
                        monotonicity_cr(double_alg),
                        monotonicity_cr(three_alg)])

    print("       Собственный|\t\t\tТабличный метод\t\t\t\t |   Алгоритмический метод")
    print(table_tbl)

    draw_all([single_tbl, double_tbl, three_tbl], [single_alg, double_alg, three_alg])

if __name__ == '__main__':
    main() 
