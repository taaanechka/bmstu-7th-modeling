from random import randint


def event_model(generator, processor, total_tasks=0, repeat=0):
    done_tasks = 0
    cur_qlen = max_qlen = 0
    events = [[generator.generate(), 'g']]
    free, process_flag = True, False

    while done_tasks < total_tasks:
        event = events.pop(0)

        # Генератор
        if event[1] == 'g':
            cur_qlen += 1
            if cur_qlen > max_qlen:
                max_qlen = cur_qlen

            add_event(events, [event[0] + generator.generate(), 'g'])

            if free:
                process_flag = True

        # Обработчик
        elif event[1] == 'p':
            done_tasks += 1
            if randint(1, 100) <= repeat:
                cur_qlen += 1

            process_flag = True

        if process_flag:
            if cur_qlen > 0:
                cur_qlen -= 1
                add_event(events, [event[0] + processor.generate(), 'p'])
                free = False
            else:
                free = True

            process_flag = False

    return max_qlen


def add_event(events, event: list):
    i = 0

    while i < len(events) and events[i][0] < event[0]:
        i += 1

    if 0 < i < len(events):
        events.insert(i - 1, event)
    else:
        events.insert(i, event)