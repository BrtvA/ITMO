import math

YARDS_TO_FEET_FACTOR = 3
MILES_TO_FEET_FACTOR = 5280
HOURS_TO_SECONDS_FACTOR = 3600
DEGREE_START = 0
DEGREE_STEP = 0.001
DEGREE_STOP = 90

'''
Блок рабочих функций
'''


def get_input_data():
    distance_d1 = float(input("Введите кратчайшее расстояние между спасателем и кромкой воды, d1 (ярды) => "))
    print("{:.0f}".format(distance_d1))
    distance_d2 = float(input("Введите кратчайшее расстояние от утопающего до берега, d2 (футы) => "))
    print("{:.0f}".format(distance_d2))
    shift = float(input("Введите боковое смещение между спасателем и утопающим, h (ярды) => "))
    print("{:.0f}".format(shift))
    speed = float(input("Введите скорость движения спасателя по песку, v_sand (мили в час) => "))
    print("{:.0f}".format(speed))
    coefficient = float(input("Введите коэффициент замедления спасателя при движении в воде, n => "))
    print("{:.0f}".format(coefficient))

    return [distance_d1, distance_d2, shift,
            speed, coefficient]


def convert_to_radian(degree):
    return degree * math.pi / 180


def get_perpendicular_distance(distance_to_water, radian):
    return distance_to_water / math.tan(radian)


def get_new_distance_to_water(distance_to_water, perpendicular_distance):
    return math.sqrt(perpendicular_distance ** 2 + distance_to_water ** 2)


def get_new_distance_to_coast(side_shift, perpendicular_distance, distance_to_coast):
    return math.sqrt((side_shift - perpendicular_distance) ** 2 + distance_to_coast ** 2)


def get_time(distance_to_water, distance_to_coast, perpendicular_distance,
             deceleration_coefficient, speed_sand, side_shift):
    return (get_new_distance_to_water(distance_to_water, perpendicular_distance)
            + deceleration_coefficient * get_new_distance_to_coast(side_shift, perpendicular_distance,
                                                                   distance_to_coast)) \
        / speed_sand


def calculate_minimum_time():
    [distance_to_water,
     distance_to_coast,
     side_shift,
     speed_sand,
     deceleration_coefficient] = get_input_data()

    distance_to_water = distance_to_water * YARDS_TO_FEET_FACTOR
    side_shift = side_shift * YARDS_TO_FEET_FACTOR
    speed_sand = speed_sand * MILES_TO_FEET_FACTOR

    first_degree = DEGREE_START
    min_time = 0
    optimal_degree = 0

    for idx in range(0, int((DEGREE_STOP - DEGREE_START) / DEGREE_STEP)):
        first_degree += DEGREE_STEP
        first_radian = convert_to_radian(first_degree)
        perpendicular_distance = get_perpendicular_distance(distance_to_water, first_radian)
        time = get_time(distance_to_water, distance_to_coast, perpendicular_distance, deceleration_coefficient,
                        speed_sand, side_shift) * HOURS_TO_SECONDS_FACTOR
        if idx == 0 or time < min_time:
            min_time = time
            optimal_degree = first_degree

    return (optimal_degree, min_time)


'''
Основной блок программы
'''

(degree, time) = calculate_minimum_time()
print(f'\nЕсли спасатель начнёт движение под оптимальным углом theta1, '
      f'равным {degree:.2f} градусам,\nон достигнет утопащего через {time:.1f} секунд')
