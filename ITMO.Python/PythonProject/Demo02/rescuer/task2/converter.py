import math

YARDS_TO_FEET_FACTOR = 3
MILES_TO_FEET_FACTOR = 5280


def convert_to_radian(degree):
    return degree * math.pi / 180


def convert_yards_to_feet(yards):
    return YARDS_TO_FEET_FACTOR * yards


def convert_miles_to_feet(miles):
    return MILES_TO_FEET_FACTOR * miles
