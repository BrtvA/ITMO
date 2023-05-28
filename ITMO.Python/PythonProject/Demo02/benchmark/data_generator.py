import random
import json

INPUT_PATH = 'data/input_data'
TYPE_INTEGER = "Integer"
TYPE_DOUBLE = "Double"
TYPE_BIG_INTEGER = "BigInteger"


def validate_input_data(data_type, thread_num, start_num,
                        minimum, maximum,
                        trans_a_flag, trans_b_flag):
    is_valid = (data_type == TYPE_INTEGER or data_type == TYPE_DOUBLE or data_type == TYPE_BIG_INTEGER) \
               and (thread_num >= 0) and (start_num > 0) and (minimum < maximum) \
               and (trans_a_flag == 0 or trans_a_flag == 1) \
               and (trans_b_flag == 0 or trans_b_flag == 1)
    if (not is_valid):
        raise ValueError("Валидация данных не пройдена")


def get_input_value():
    type_data = input("Введите тип данных? [Integer/Double/BigInteger] => ")
    start_num = int(input("Введите количество запусков => "))
    thread_num = int(input("Введите количество потоков => "))
    minimum, maximum = map(int, input("Введите диапазон значений элементов матрицы[x y] => ").split())
    trans_a_flag = int(input("Введите флаг транспонирования для матрицы А [0/1] => "))
    trans_b_flag = int(input("Введите флаг транспонирования для матрицы B [0/1] => "))
    alfa_scalar = int(input("Введите скаляр alfa => "))
    betta_scalar = int(input("Введите скаляр betta => "))

    validate_input_data(type_data, thread_num, start_num,
                        minimum, maximum,
                        trans_a_flag, trans_b_flag)

    return type_data, thread_num, start_num, \
        minimum, maximum, \
        trans_a_flag, trans_b_flag, \
        alfa_scalar, betta_scalar


def generate_matrix(min_value, max_value, row, col, is_int):
    if is_int:
        return [[random.randint(min_value, max_value) for _ in range(col)] for _ in range(row)]
    else:
        return [[random.uniform(min_value, max_value) for _ in range(col)] for _ in range(row)]


def create_input_data(data_type, min_value, max_value, row, col,
                      trans_a, trans_b, alfa, betta, thread_count,
                      start_count, path):
    is_int = data_type == "Integer" or data_type == "BigInteger"

    matrix_a = generate_matrix(min_value, max_value, row, col, is_int)
    matrix_b = generate_matrix(min_value, max_value, row, col, is_int)

    data = {
        "thread_count": thread_count,
        "start_count": start_count,
        "trans_a": trans_a,
        "trans_b": trans_b,
        "alfa": alfa,
        "betta": betta,
        "matrix_a": matrix_a,
        "matrix_b": matrix_b,
    }
    try:
        data_json = json.dumps(data)
        with open(path, "w") as my_file:
            my_file.write(data_json)
        return "\nДанные записаны в json-файл\n"
    except Exception as e:
        return f"\nОшибка при записи начальных данных в json: {e}\n"


def start_data_creator():
    path_list = []
    row_list = []

    data_type, thread_count, start_count, min_value, max_value, \
        trans_a, trans_b, alfa, betta = get_input_value()

    print()

    while True:
        row = int(input("Введите кол-во строк (столбцов) в матрице => "))
        if row < 1:
            raise ValueError("Валидация данных не пройдена")
        col = row

        path = f"{INPUT_PATH}_{data_type}_{row}x{col}.json"
        path_list.append(path)
        row_list.append(row)

        print(create_input_data(data_type, min_value, max_value,
                                row, col, trans_a, trans_b,
                                alfa, betta, thread_count, start_count, path))

        is_next = input("\nСгенерировать еще данные?[Y/N] => ") == "Y"
        print()
        if is_next:
            continue
        else:
            break

    return path_list, data_type, row_list, thread_count
