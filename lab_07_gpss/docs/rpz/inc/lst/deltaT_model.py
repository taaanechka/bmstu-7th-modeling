from random import randint

def deltaT_model(generator, processor, total_tasks=0, repeat=0, step=0.001):
    done_tasks = 0
    t_curr = step
    t_gen = generator.generate()
    t_gen_prev = t_proc = 0
    cur_qlen = max_qlen = 0
    free = True

    while done_tasks < total_tasks:
        # Генератор
        if t_curr > t_gen:
            cur_qlen += 1
            if cur_qlen > max_qlen:
                max_qlen = cur_qlen
            
            t_gen_prev = t_gen
            t_gen += generator.generate()

        # Обработчик
        if t_curr > t_proc:
            if cur_qlen > 0:
                was_free = free
                if free:
                    free = False
                else:
                    done_tasks += 1
                    if randint(1, 100) <= repeat:
                        cur_qlen += 1

                cur_qlen -= 1
                if was_free:
                    t_proc = t_gen_prev + processor.generate()
                else:
                    t_proc += processor.generate()
            else:
                free = True

        t_curr += step

    return max_qlen