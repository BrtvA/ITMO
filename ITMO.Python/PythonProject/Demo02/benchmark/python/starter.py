import json
import time
from benchmark import dgemm


def read_json(path):
    with open(path, "r") as my_file:
        data_json = my_file.read()
    return json.loads(data_json)


def start_benchmark(path):
    try:
        json_data = read_json(path)
    except FileNotFoundError as e:
        print(f"[Python] Входной файл не найден: {e}")
        return -999

    result = []
    time_list = []
    for _ in range(json_data["start_count"]):
        start_time = time.time()
        result = dgemm(json_data["matrix_a"], json_data["matrix_b"],
                       json_data["trans_a"], json_data["trans_b"],
                       json_data["alfa"], json_data["betta"],
                       json_data["thread_count"], result)
        time_list.append((time.time() - start_time) * 10 ** 3)

    return sum(time_list)