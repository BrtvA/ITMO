import calculator
from converter import convert_to_radian, \
    convert_yards_to_feet, convert_miles_to_feet

YARDS_TO_FEET_FACTOR = 3
MILES_TO_FEET_FACTOR = 5280


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
    degree = float(input("Введите направление движения спасателя по песку, theta1 (градусы) => "))
    print("{:.3f}".format(degree))

    return [distance_d1, distance_d2, shift,
            speed, coefficient, degree]


if __name__ == "__main__":
    [distance_to_water,
     distance_to_coast,
     side_shift,
     speed_sand,
     deceleration_coefficient,
     first_degree] = get_input_data()

    distance_to_water = convert_yards_to_feet(distance_to_water)
    side_shift = convert_yards_to_feet(side_shift)
    speed_sand = convert_miles_to_feet(speed_sand)
    first_radian = convert_to_radian(first_degree)

    calculator = calculator.Calculator(distance_to_water, distance_to_coast,
                                       first_radian, deceleration_coefficient,
                                       speed_sand, side_shift)
    print(f'\nЕсли спасатель начнёт движение под углом theta1, равным {first_degree:.0f} градусам,\n'
          f'он достигнет утопащего через {calculator.get_time():.1f} секунд')
