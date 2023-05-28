import json


def read_from_file(input_path):
    with open(input_path, "r") as my_file:
        data_json = my_file.read()
    input_data = json.loads(data_json)
    return [input_data["matrix"], input_data["age"], input_data["color"], input_data["scale"]]


def write_into_file(matrix, age, color, scale, output_path):
    data = {
        "age": age,
        "color": color,
        "scale": scale,
        "matrix": matrix
    }
    data_json = json.dumps(data)
    try:
        with open(output_path, "w") as my_file:
            my_file.write(data_json)
    except Exception as e:
        print(f"Ошибка при сохранения данных об игровом поле в json-файл: {e}")
