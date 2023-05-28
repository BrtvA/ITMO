import re


def validate(regex: str, value: str,
             min_length: int, max_length: int):
    return len(re.findall(regex, value)) > 0 \
        and min_length <= len(value) <= max_length


def validate_by_list(value, main_list: tuple):
    return value in main_list


if __name__ == "__main__":
    print(validate(r'^[0-9] + $', "0", 1, 1))

    print(validate_by_list("id", ("id", "name", "street", "city",
                                    "county", "state", "zip", "distance", "rating")))

    print(validate(r'^[a-zA-Zа-яА-ЯёЁ]+$', "hgfd", 1, 20))

