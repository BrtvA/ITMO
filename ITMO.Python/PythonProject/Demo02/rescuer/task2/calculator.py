import math


class Calculator:
    def __init__(self, distance_to_water, distance_to_coast,
                 first_radian, deceleration_coefficient,
                 speed_sand, side_shift):
        self.__distance_to_water = distance_to_water
        self.__distance_to_coast = distance_to_coast
        self.__first_radian = first_radian
        self.__deceleration_coefficient = deceleration_coefficient
        self.__speed_sand = speed_sand
        self.__side_shift = side_shift
        pass

    def get_perpendicular_distance(self):
        return self.__distance_to_water / math.tan(self.__first_radian)

    def get_new_distance_to_water(self, perpendicular_distance):
        return math.sqrt(perpendicular_distance ** 2 + self.__distance_to_water ** 2)

    def get_new_distance_to_coast(self, perpendicular_distance):
        return math.sqrt((self.__side_shift - perpendicular_distance) ** 2 + self.__distance_to_coast ** 2)

    def get_time(self):
        perpendicular_distance = self.get_perpendicular_distance()
        return 3600 * (self.get_new_distance_to_water(perpendicular_distance)
                       + self.__deceleration_coefficient * self.get_new_distance_to_coast(perpendicular_distance)) \
            / self.__speed_sand
