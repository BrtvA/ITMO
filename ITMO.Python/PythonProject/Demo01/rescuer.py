import math

YARDS_TO_FEET_FACTOR = 3
MILES_TO_FEET_FACTOR = 5280

distance_to_water = float(input("Введите кратчайшее расстояние между спасателем и кромкой воды, d1 (ярды) => "))
print("{:.0f}".format(distance_to_water))
distance_to_coast = float(input("Введите кратчайшее расстояние от утопающего до берега, d2 (футы) => "))
print("{:.0f}".format(distance_to_coast))
side_shift = float(input("Введите боковое смещение между спасателем и утопающим, h (ярды) => "))
print("{:.0f}".format(side_shift))
speed_sand = float(input("Введите скорость движения спасателя по песку, v_sand (мили в час) => "))
print("{:.0f}".format(speed_sand))
deceleration_coefficient = float(input("Введите коэффициент замедления спасателя при движении в воде, n => "))
print("{:.0f}".format(deceleration_coefficient))
first_degree = float(input("Введите направление движения спасателя по песку, theta1 (градусы) => "))
print("{:.3f}".format(first_degree))


def convert_to_radian(degree):
    return degree * math.pi / 180


def get_perpendicular_distance(distance_to_water, radian):
    return distance_to_water / math.tan(radian)


def get_new_distance_to_water(distance_to_water, perpendicular_distance):
    return math.sqrt(perpendicular_distance ** 2 + distance_to_water ** 2)


def get_new_distance_to_coast(side_shift, perpendicular_distance, distance_to_coast):
    return math.sqrt((side_shift - perpendicular_distance) ** 2 + distance_to_coast ** 2)


def get_time(distance_to_water, distance_to_coast, perpendicular_distance, deceleration_coefficient, speed_sand):
    return (get_new_distance_to_water(distance_to_water, perpendicular_distance)
            + deceleration_coefficient * get_new_distance_to_coast(side_shift, perpendicular_distance,
                                                                   distance_to_coast)) \
        / speed_sand


distance_to_water = distance_to_water * YARDS_TO_FEET_FACTOR
side_shift = side_shift * YARDS_TO_FEET_FACTOR
speed_sand = speed_sand * MILES_TO_FEET_FACTOR
first_radian = convert_to_radian(first_degree)

perpendicular_distance = get_perpendicular_distance(distance_to_water, first_radian)

time = get_time(distance_to_water, distance_to_coast, perpendicular_distance, deceleration_coefficient,
                speed_sand) * 3600

print(f'\nЕсли спасатель начнёт движение под углом theta1, равным {first_degree:.0f} градусам,\n'
      f'он достигнет утопащего через {time:.1f} секунд')
