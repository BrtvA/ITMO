import math

COMMAND_LOC = "loc"
COMMAND_ZIP = "zip"
COMMAND_DIST = "dist"
COMMAND_END = "end"

RESPONSE_ERROR = "Invalid command, ignoring"
RESPONSE_DONE = "Done"
RESPONSE_UNKNOWN_ZIP = "Invalid or unknown ZIP Code"

REQUEST_ENTER_ZIP = "Enter a ZIP Code to lookup => "
REQUEST_ENTER_CITY = "Enter a city name to lookup => "
REQUEST_ENTER_STATE = "Enter the state name to lookup => "
REQUEST_ENTER_FIRST_ZIP = "Enter the first ZIP Code => "
REQUEST_ENTER_SECOND_ZIP = "Enter the second ZIP Code => "

EARTH_RADIUS = 3958.76  # miles


def convert_to_radian(degree):
    return degree * math.pi / 180


def convert_to_dms(degree):
    deg = math.trunc(degree)
    min = math.trunc((degree - deg) * 60)
    sec = ((degree - deg) * 60 - min) * 60
    return int(math.fabs(deg)), int(math.fabs(min)), math.fabs(sec)


def calc_distance(latitude_1, longitude_1,
                  latitude_2, longitude_2):
    latitude_1 = convert_to_radian(latitude_1)
    longitude_1 = convert_to_radian(longitude_1)
    latitude_2 = convert_to_radian(latitude_2)
    longitude_2 = convert_to_radian(longitude_2)

    return 2 * EARTH_RADIUS * math.asin(math.sqrt(math.pow(math.sin((latitude_2 - latitude_1) / 2), 2)
                                                  + math.cos(latitude_1) * math.cos(latitude_2) * math.pow(
        ((longitude_2 - longitude_1) / 2), 2)))


def get_location(zip_code, data):
    for row in data:
        if row[0] == zip_code:
            latitude = convert_to_dms(row[1])
            longitude = convert_to_dms(row[2])
            return f"ZIP Code {row[0]} is in {row[3]}, {row[4]}, {row[5]} county,\n" \
                   f"coordinates: ({latitude[0]}°{latitude[1]}'{latitude[2]:.2f}\"N, " \
                   f"{longitude[0]}°{longitude[1]}'{longitude[2]:.2f}\"W)"
    return RESPONSE_UNKNOWN_ZIP


def get_zip(city, state, data):
    zip_list = []
    city_name = ""
    state_name = ""

    for row in data:
        if row[3].lower() == city and row[4].lower() == state:
            city_name = row[3]
            state_name = row[4]
            zip_list.append(row[0])

    if len(zip_list) == 0:
        return f"No ZIP Code found for {city_name}, {state_name}"
    return f"The following ZIP Code(s) found for {city_name}, {state_name}: " \
           f"{', '.join(zip_list)}"


def get_distance(zip_1, zip_2, data):
    fiducial_point = -999

    latitude_1 = fiducial_point
    longitude_1 = fiducial_point
    latitude_2 = fiducial_point
    longitude_2 = fiducial_point

    for row in data:
        if row[0] == zip_1:
            latitude_1 = row[1]
            longitude_1 = row[2]
        if row[0] == zip_2:
            latitude_2 = row[1]
            longitude_2 = row[2]

    if latitude_1 == fiducial_point or longitude_1 == fiducial_point \
            or latitude_2 == fiducial_point or longitude_2 == fiducial_point:
        return f"The distance between {zip_1} and {zip_2} cannot be determined"
    else:
        return f"The distance between {zip_1} and {zip_2} is " \
               f"{calc_distance(latitude_1, longitude_1, latitude_2, longitude_2):.2f} miles"


def start_console(data):
    while True:
        command = input("Command ('loc', 'zip', 'dist', 'end') => ")
        print(command)
        command = command.lower()

        if command == COMMAND_END:
            print(RESPONSE_DONE)
            break

        if command == COMMAND_LOC:
            zip_code = input(REQUEST_ENTER_ZIP)
            print(zip_code)
            print(get_location(zip_code, data))
            continue

        if command == COMMAND_ZIP:
            city = input(REQUEST_ENTER_CITY)
            print(city)
            state = input(REQUEST_ENTER_STATE)
            print(state)
            print(get_zip(city.lower(), state.lower(), data))
            continue

        if command == COMMAND_DIST:
            zip_1 = input(REQUEST_ENTER_FIRST_ZIP)
            print(zip_1)
            zip_2 = input(REQUEST_ENTER_SECOND_ZIP)
            print(zip_2)
            print(get_distance(zip_1, zip_2, data))
            continue

        print(RESPONSE_ERROR)
