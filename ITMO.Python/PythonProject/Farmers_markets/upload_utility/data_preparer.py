import file_reader


class DataPreparer:
    def __init__(self, filename: str):
        reader = file_reader.FileReader(filename)
        self.__data = reader.read_csv()

    #########

    def upcase_first_word(self, lines: str, split_delimiter: str = " ") -> str:
        word_list = lines.split(split_delimiter)
        new_list = []
        for word in word_list:
            if word != "":
                new_list.append(word[0].upper() + word[1:])
        return split_delimiter.join(new_list)

    def convert_into_list_from_single(self, value: str,
                                      split_delimiter: str = ",",
                                      split_delimiter_2: str = " and ") -> list[str]:
        row_list = value.split(split_delimiter)

        temp_list = row_list[len(row_list) - 1].split(split_delimiter_2)
        if (len(temp_list) > 1):
            row_list.pop()
            row_list += temp_list

        return [self.upcase_first_word(self.upcase_first_word(item.strip().lower()), "-")
                for item in row_list]

    def get_unique_str_list(self, value_list: list[str]) -> list[str]:
        unique_data = []
        for item in value_list:
            if unique_data.count(item) == 0 and item != "":
                unique_data.append(item)
        return unique_data

    def find_element(self, value, source_list: list[()], idx: int = 1) -> int:
        for item in source_list:
            if item[idx] == value:
                return item[0]
        return -999

    ######################################
    # Функции получения данных для запросов
    ######################################

    def get_categories(self) -> list[tuple]:
        ctgr = self.__data[0][28:len(self.__data[0]) - 1]

        output = []
        for idx in range(len(ctgr)):
            output.append((idx + 1, ctgr[idx]))
        return output

    def get_additionals(self) -> list[tuple]:
        addit = self.__data[0][23:28]

        output = []
        for idx in range(len(addit)):
            output.append((idx + 1, addit[idx]))
        return output

    def get_medias(self) -> list[tuple]:
        medias = self.__data[0][2:7]

        output = []
        for idx in range(len(medias)):
            output.append((idx + 1, medias[idx]))
        return output

    def get_ratings(self) -> list[tuple]:
        output = []
        for idx in range(1, 6):
            output.append((idx, idx))
        return output

    def get_streets(self) -> list[tuple]:
        streets_list = []
        for idx in range(1, len(self.__data)):
            streets_list += self.convert_into_list_from_single(self.__data[idx][7])

        streets = self.get_unique_str_list(streets_list)

        output = []
        for idx in range(len(streets)):
            output.append((idx + 1, streets[idx]))
        return output

    def get_cities(self) -> list[tuple]:
        cities_list = []
        for idx in range(1, len(self.__data)):
            cities_list += self.convert_into_list_from_single(self.__data[idx][8])

        cities = self.get_unique_str_list(cities_list)

        output = []
        for idx in range(len(cities)):
            output.append((idx + 1, cities[idx]))
        return output

    def get_counties(self) -> list[tuple]:
        counties_list = [self.__data[idx][9] for idx in range(1, len(self.__data))]
        counties = self.get_unique_str_list(counties_list)

        output = []
        for idx in range(len(counties)):
            output.append((idx + 1, counties[idx]))
        return output

    def get_states(self) -> list[tuple]:
        states_list = [self.__data[idx][10] for idx in range(1, len(self.__data))]
        states = self.get_unique_str_list(states_list)

        output = []
        for idx in range(len(states)):
            output.append((idx + 1, states[idx]))
        return output

    def get_zips(self) -> list[tuple]:
        zips_list = [self.__data[idx][11] for idx in range(1, len(self.__data))]
        zips = self.get_unique_str_list(zips_list)

        output = []
        for idx in range(len(zips)):
            output.append((idx + 1, zips[idx]))
        return output

    def get_markets(self, counties_list: list[tuple],
                    states_list: list[tuple], zips_list: list[tuple]) -> list[tuple]:
        output = []
        for idx in range(1, len(self.__data)):
            market_id = self.__data[idx][0]
            name = self.__data[idx][1].strip()

            county_res = self.find_element(self.__data[idx][9], counties_list)
            if county_res > 0:
                county_id = county_res
            else:
                county_id = None

            state_res = self.find_element(self.__data[idx][10], states_list)
            if state_res > 0:
                state_id = state_res
            else:
                state_id = None

            zip_res = self.find_element(self.__data[idx][11], zips_list)
            if zip_res > 0:
                zip_id = zip_res
            else:
                zip_id = None

            x_str = self.__data[idx][20]
            if x_str == "":
                x_pos = None
            else:
                x_pos = float(x_str)

            y_str = self.__data[idx][21]
            if y_str == "":
                y_pos = None
            else:
                y_pos = float(y_str)

            update_time_str = self.__data[idx][58]
            if update_time_str == "":
                update_time = update_time_str
            else:
                update_time = None

            output.append((market_id, name, county_id, state_id, zip_id, x_pos, y_pos, update_time))
        return output

    def get_markets_additionals(self) -> list[tuple]:
        output = []
        for row in range(1, len(self.__data)):
            for col in range(23, 28):
                if self.__data[row][col].strip() == "Y":
                    output.append((int(self.__data[row][0]), col - 22))
        return output

    def get_markets_categories(self) -> list[tuple]:
        output = []
        for row in range(1, len(self.__data)):
            for col in range(28, len(self.__data[0])):
                if self.__data[row][col].strip() == "Y":
                    output.append((int(self.__data[row][0]), col - 27))
        return output

    def get_markets_medias(self) -> list[tuple]:
        output = []
        for row in range(1, len(self.__data)):
            for col in range(2, 7):
                if self.__data[row][col].strip() != "":
                    output.append((int(self.__data[row][0]), col - 1, str(self.__data[row][col].strip())))
        return output

    def get_markets_cities(self, cities_list: list[tuple]) -> list[tuple]:
        output = []
        for row in range(1, len(self.__data)):
            temp_cities_list = self.convert_into_list_from_single(self.__data[row][8])
            for item in temp_cities_list:
                if item == "":
                    continue
                idx = self.find_element(item, cities_list)
                if idx > 0:
                    output.append((self.__data[row][0], idx))
        return output

    def get_markets_streets(self, streets_list: list[tuple]) -> list[tuple]:
        output = []
        for row in range(1, len(self.__data)):
            temp_streets_list = self.convert_into_list_from_single(self.__data[row][7])
            for item in temp_streets_list:
                if item == "":
                    continue
                idx = self.find_element(item, streets_list)
                if idx > 0:
                    output.append((self.__data[row][0], idx))
        return output

    def get_markets_seasons(self) -> list[tuple]:
        output = []

        for row in range(1, len(self.__data)):
            for col in range(12, 20, 2):
                if self.__data[row][col].strip() == "":
                    from_date = None
                    to_date = None
                else:
                    temp_date = self.__data[row][col].split("to")
                    from_date = temp_date[0].strip()
                    to_date = None
                    if len(temp_date) > 1:
                        to_date = temp_date[1].strip()

                if self.__data[row][col + 1].strip() == "":
                    time = None
                else:
                    time = self.__data[row][col + 1].strip()

                if from_date is not None or time is not None:
                    output.append((self.__data[row][0], from_date, to_date, time))

        return output


if __name__ == "__main__":
    preparer = DataPreparer('../data/Export.csv')

    categories = preparer.get_categories()
    # print(f"header categories: {categories}")

    additionals = preparer.get_additionals()
    # print(f"header additionals: {additionals}")

    medias = preparer.get_medias()
    # print(f"header medias: {medias}")

    ratings = preparer.get_ratings()
    # print(f"header ratings: {ratings}")

    cities = preparer.get_cities()
    # print(f"header cities: {cities}")

    counties = preparer.get_counties()
    # print(f"header counties: {counties}")

    states = preparer.get_states()
    # print(f"header states: {states}")

    streets = preparer.get_streets()
    # print(f"header streets: {streets}")

    zips = preparer.get_zips()
    # print(f"header zips: {zips}")

    markets = preparer.get_markets(counties, states, zips)
    # print(f"header markets: {markets}")

    markets_additional = preparer.get_markets_additionals()
    # print(f"header markets_additional: {markets_additional}")

    markets_categories = preparer.get_markets_categories()
    # print(f"header markets_categories: {markets_categories}")

    markets_medias = preparer.get_markets_medias()
    # print(f"header markets_medias: {markets_medias}")

    markets_cities = preparer.get_markets_cities(cities)
    # print(f"header markets_medias: {markets_cities}")

    markets_streets = preparer.get_markets_streets(streets)
    # print(f"header markets_streets: {markets_streets}")

    markets_seasons = preparer.get_markets_seasons()
    print(f"header markets_seasons: {markets_seasons}")
