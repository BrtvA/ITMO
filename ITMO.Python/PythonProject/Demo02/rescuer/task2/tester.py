import calculator
from converter import convert_to_radian, \
    convert_yards_to_feet, convert_miles_to_feet


def test_convert_to_radian(input_value, output_value):
    return round(convert_to_radian(input_value), 3) == output_value


def test_convert_yards_to_feet(input_value, output_value):
    return convert_yards_to_feet(input_value) == output_value


def test_convert_miles_to_feet(input_value, output_value):
    return convert_miles_to_feet(input_value) == output_value


def test_get_time(distance_to_water, distance_to_coast,
                  first_radian, deceleration_coefficient,
                  speed_sand, side_shift, output_value):
    time = calculator.Calculator(distance_to_water, distance_to_coast,
                                 first_radian, deceleration_coefficient,
                                 speed_sand, side_shift).get_time()
    return round(time, 3) == output_value


if __name__ == "__main__":
    print(f"Тестирование преобразования в радианы: "
          f"{test_convert_to_radian(39.413, 0.688)}")

    print(f"Тестирование преобразования ярдов в футы: "
          f"{test_convert_yards_to_feet(8, 24)}")

    print(f"Тестирование преобразования миль в футы: "
          f"{test_convert_miles_to_feet(5, 26400)}")

    print(f"Тестирование вычисления времени: "
          f"{test_get_time(24, 10, 0.688, 2, 26400, 150, 38.213)}")
