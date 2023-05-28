from PythonProject.Farmers_markets.web.src.DAL import query_manager
from PythonProject.Farmers_markets.web.src.BAL.validator import validate, validate_by_list


class RequestHandler:
    NUMBER_REGEX = r'^[0-9]+$'
    RATING_REGEX = r'^[1-5]'
    LATIN_CYRILLIC_REGEX = r'^[a-zA-Zа-яА-ЯёЁ]+$'
    LATIN_REGEX = r'^[a-zA-Z]+$'
    ZIP_REGEX = r'^[0-9-]+$'
    FLOAT_REGEX = r'[0-9]+\.?[0-9]+'

    def __init__(self, db_name: str, db_users: str,
                 db_password: str, db_host: str,
                 db_port: str):
        self.__manager = query_manager.QueryManager(db_name, db_users,
                                                    db_password, db_host,
                                                    db_port)
        self.__sort_param = ("id", "name", "street", "city", "county",
                             "state", "zip", "distance", "rating")
        self.__sort_type = ("asc", "desc")

    def handle_request_sort(self, page_num_str: str = "0", sort_param: str = "id",
                            sort_type: str = "asc", x_pos_str: str = "38.8951",
                            y_pos_str: str = "77.0364"):

        isValid = validate_by_list(sort_param, self.__sort_param) \
                  and validate_by_list(sort_type, self.__sort_type)

        error = None

        if isValid:
            try:
                page_num = int(page_num_str)
                x_pos = float(x_pos_str)
                y_pos = float(y_pos_str)
            except ValueError as ex:
                page_num = 0
                x_pos = 38.8951
                y_pos = 77.0364
                error = "Invalid input data"
                print("Неверные входные данные", ex)
        else:
            page_num = 0
            sort_param = "id"
            sort_type = "asc"
            x_pos = 38.8951
            y_pos = 77.0364
            error = "Invalid input data"
            print("Неверные входные данные")

        if error is None:
            try:
                data = self.__manager.get_sort_markets_list(sort_param, sort_type,
                                                            x_pos, y_pos, page_num)
            except Exception as ex:
                data = None
                error = "Data not available"
                print("Проблема подключения к БД при запросе с сортировкой", ex)
        else:
            data = None

        context = {
            "search_type": "sort",
            "config": {
                "sort_param": sort_param,
                "sort_type": sort_type,
                "x": x_pos,
                "y": y_pos,
            },
            "page": page_num,
            "data": data,
            "error": error
        }
        return context

    def handle_request_find(self, city: str, state: str,
                            zip: str, distance_str: str,
                            x_str: str, y_str: str):
        isValid = validate(self.LATIN_REGEX, city, 1, 60) \
                  and validate(self.LATIN_REGEX, state, 1, 50) \
                  and validate(self.ZIP_REGEX, zip, 1, 10)

        error = None
        if isValid:
            try:
                x_pos = float(x_str)
                y_pos = float(y_str)
                if distance_str == "":
                    distance = 0
                else:
                    distance = float(distance_str)
            except ValueError as ex:
                x_pos = 38.8951
                y_pos = 77.0364
                error = "Invalid input data"
                print("Неверные входные данные", ex)
        else:
            x_pos = 38.8951
            y_pos = 77.0364
            error = "Invalid input data"
            print("Неверные входные данные")

        if error is None:
            try:
                data = self.__manager.find_markets_list(city, state, zip,
                                                        distance, x_pos, y_pos)
            except Exception as ex:
                data = None
                error = "Data not available"
                print("Проблема подключения к БД при запросе с поиском", ex)
        else:
            data = None

        context = {
            "search_type": "find",
            "config": {
                "city": city,
                "state": state,
                "zip": zip,
                "distance": "",
                "x": x_pos,
                "y": y_pos,
            },
            "data": data,
            "error": error
        }

        return context

    def handle_request_review(self, market_id_str: str, rating_str: str,
                              firstname: str, lastname: str, text: str):
        isValid = validate(self.RATING_REGEX, rating_str, 1, 1) \
                  and validate(self.LATIN_CYRILLIC_REGEX, firstname, 1, 20) \
                  and validate(self.LATIN_CYRILLIC_REGEX, lastname, 1, 20) \
                  and (validate(self.LATIN_CYRILLIC_REGEX, text, 1, 200) or text == "")

        redirected = None
        error = None

        if not validate(self.NUMBER_REGEX, market_id_str, 1, 7):
            redirected = "index"

        if isValid:
            try:
                market_id = int(market_id_str)
            except ValueError as ex:
                redirected = "index"
                error = "Invalid input data"
                print("Неверные входные данные", ex)
        else:
            redirected = "info"
            error = "Invalid input data"
            print("Неверные входные данные")

        print(f"Error: {error}")
        print(f"isValid: {isValid}")
        if error is None:
            try:
                self.__manager.add_review(market_id, int(rating_str),
                                          firstname, lastname, text)
            except Exception as ex:
                redirected = "info"
                error = "Failed to add review"
                print("Проблема подключения к БД при добавлении отзыва", ex)

        return redirected, error

    def handle_request_info(self, market_id: int, error):
        try:
            data = self.__manager.get_info(market_id)
            review = self.__manager.get_review(market_id)
        except Exception as ex:
            print("Проблема подключения к БД", ex)
            error = "Сервер помер"
            data = None
            review = None

        context = {
            "data": data,
            "error": error,
            "market_id": market_id,
            "review": review
        }
        return context
