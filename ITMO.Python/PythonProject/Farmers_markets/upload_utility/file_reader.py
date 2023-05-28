import csv


class FileReader:

    def __init__(self, file_name: str):
        self.__file_name = file_name

    def read_csv(self) -> list[list[str]]:
        with open(self.__file_name, "r") as fh:
            reader = csv.reader(fh)
            rows = list(reader)
        return rows

    def read_sql(self) -> str:
        with open(self.__file_name, "r") as my_file:
            sql_query = my_file.read()
        return sql_query


if __name__ == '__main__':
    file = FileReader('data/Export.csv')
    data_csv = file.read_csv()
    print(data_csv[0])
    print(data_csv[0][0])
    print(data_csv[1])