import random
from file_action import read_from_file, write_into_file
from engine import generate_frame
from painter import draw_field

DATA_PATH = 'data/input_data.json'
IMAGE_PATH = 'data/screen.png'


def generate_field(rows, columns, inverse_density):
    return [[[not bool(random.randint(0, inverse_density)) for col in range(columns)] for row in range(rows)], 0]


'''
Основной блок программы
'''

try:
    matrix, age, color, scale = read_from_file(DATA_PATH)
except FileNotFoundError:
    row_count = int(input("Введите высоту поля => "))
    col_count = int(input("Введите ширину поля => "))
    color = list(map(int, input("Введите цвет живой ячейки [R G B]=> ").split()))
    inv_den = int(input("Введите обратную плотность [>=1] => "))
    matrix, age = generate_field(row_count, col_count, inv_den)
    scale = int(input("Введите коэффициент увеличения [>=1] => "))

if scale < 1:
    scale = 1

if age > 0:
    matrix = generate_frame(matrix)

draw_field(matrix, age, color, scale, IMAGE_PATH)
write_into_file(matrix, age + 1, color, scale, DATA_PATH)
