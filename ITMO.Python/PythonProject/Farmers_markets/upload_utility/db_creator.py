import psycopg2
import file_reader
import data_preparer

DATABASE_NAME = "test_market"
DATABASE_USER = "postgres"
DATABASE_PASSWORD = "pgpassword"
DATABASE_HOST = "127.0.0.1"
DATABASE_PORT = "5432"

CREATE_DATABASE_SQL = f"CREATE DATABASE {DATABASE_NAME}"

SQL_PATH = 'create_tables.sql'
CSV_PATH = 'data/Export.csv'


def create_db(db_name: str, db_users: str,
              db_password: str, db_host: str,
              db_port: str):
    status = True
    try:
        create_connect = psycopg2.connect(dbname="postgres",
                                          user=db_users,
                                          password=db_password,
                                          host=db_host,
                                          port=db_port)
        curs = create_connect.cursor()
        create_connect.autocommit = True
        create_db_sql = f"CREATE DATABASE {db_name}"
        curs.execute(create_db_sql)
        print(f"База данных {db_name} успешно создана")
    except (Exception, psycopg2.Error) as error:
        print("Ошибка при создании базы данных\n", error)
        status = False
    finally:
        if create_connect:
            curs.close()
            create_connect.close()
    return status


def execute_query(status: bool, db_name: str, db_users: str,
                  db_password: str, db_host: str,
                  db_port: str, sql_definition: str,
                  sql_query: str, sql_values: list = None) -> bool:
    # status = True
    if not status:
        print(f"Отмена \'{status}\'")
        return False

    try:
        create_connect = psycopg2.connect(dbname=db_name,
                                          user=db_users,
                                          password=db_password,
                                          host=db_host,
                                          port=db_port)
        curs = create_connect.cursor()
        create_connect.autocommit = False
        if sql_values == None:
            curs.execute(sql_query)
        else:
            curs.executemany(sql_query, sql_values)
        create_connect.commit()
        print(f"Запрос \'{sql_definition}\' выполнен")
    except (Exception, psycopg2.Error) as error:
        create_connect.rollback()
        print(f"Ошибка при выполнении запроса \'{sql_definition}\'\n", error)
        status = False
    finally:
        if create_connect:
            curs.close()
            create_connect.close()
    return status


def create_tables(db_name: str, db_users: str,
                  db_password: str, db_host: str,
                  db_port: str, sql_query: str,
                  status: bool) -> bool:
    if not status:
        print("Отмена создания таблиц")
        return False
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "создание таблиц",
                           sql_query)
    return status


def upload_data(db_name: str, db_users: str,
                db_password: str, db_host: str,
                db_port: str, status: bool,
                csv_file_name: str) -> bool:
    if not status:
        print("Отмена загрузки данных")
        return False

    preparer = data_preparer.DataPreparer(csv_file_name)

    sql_insert_categories = "INSERT INTO categories (id, name) VALUES (%s, %s)"
    categories = preparer.get_categories()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка categories",
                           sql_insert_categories, categories)

    sql_insert_additionals = "INSERT INTO additionals (id, name) VALUES (%s, %s)"
    additionals = preparer.get_additionals()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка additionals",
                           sql_insert_additionals, additionals)

    sql_insert_medias = "INSERT INTO medias (id, name) VALUES (%s, %s)"
    medias = preparer.get_medias()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка medias",
                           sql_insert_medias, medias)

    sql_insert_ratings = "INSERT INTO ratings (id, value) VALUES (%s, %s)"
    ratings = preparer.get_ratings()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка ratings",
                           sql_insert_ratings, ratings)

    sql_insert_streets = "INSERT INTO streets (id, name) VALUES (%s, %s)"
    streets = preparer.get_streets()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка streets",
                           sql_insert_streets, streets)

    sql_insert_cities = "INSERT INTO cities (id, name) VALUES (%s, %s)"
    cities = preparer.get_cities()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка cities",
                           sql_insert_cities, cities)

    sql_insert_counties = "INSERT INTO counties (id, name) VALUES (%s, %s)"
    counties = preparer.get_counties()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка counties",
                           sql_insert_counties, counties)

    sql_insert_states = "INSERT INTO states (id, name) VALUES (%s, %s)"
    states = preparer.get_states()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка states",
                           sql_insert_states, states)

    sql_insert_zips = "INSERT INTO zips (id, code) VALUES (%s, %s)"
    zips = preparer.get_zips()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка zips",
                           sql_insert_zips, zips)

    sql_insert_markets = "INSERT INTO markets (id, name, county_id, state_id, zip_id, x_position, y_position, update_time) " \
                         "VALUES (%s, %s, %s, %s, %s, %s, %s, %s)"
    markets = preparer.get_markets(counties, states, zips)
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets",
                           sql_insert_markets, markets)

    sql_insert_markets_additionals = "INSERT INTO markets_additionals (market_id, additional_id) " \
                                     "VALUES (%s, %s)"
    markets_additionals = preparer.get_markets_additionals()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_additionals",
                           sql_insert_markets_additionals, markets_additionals)

    sql_insert_markets_categories = "INSERT INTO markets_categories (market_id, category_id) " \
                                    "VALUES (%s, %s)"
    markets_categories = preparer.get_markets_categories()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_categories",
                           sql_insert_markets_categories, markets_categories)

    sql_insert_markets_medias = "INSERT INTO markets_medias (market_id, media_id, url) " \
                                "VALUES (%s, %s, %s)"
    markets_medias = preparer.get_markets_medias()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_medias",
                           sql_insert_markets_medias, markets_medias)

    sql_insert_markets_cities = "INSERT INTO markets_cities (market_id, city_id) " \
                                "VALUES (%s, %s)"
    markets_cities = preparer.get_markets_cities(cities)
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_cities",
                           sql_insert_markets_cities, markets_cities)

    sql_insert_markets_streets = "INSERT INTO markets_streets (market_id, street_id) " \
                                 "VALUES (%s, %s)"
    markets_streets = preparer.get_markets_streets(streets)
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_streets",
                           sql_insert_markets_streets, markets_streets)

    sql_insert_markets_seasons = "INSERT INTO markets_seasons (market_id, from_date, to_date, time_interval) " \
                                 "VALUES (%s, %s, %s, %s)"
    markets_seasons = preparer.get_markets_seasons()
    status = execute_query(status, db_name, db_users, db_password,
                           db_host, db_port, "загрузка markets_seasons",
                           sql_insert_markets_seasons, markets_seasons)

    return status


'''
Основной блок программы
'''

print(f"Создаю базу данных \'{DATABASE_NAME}\'")

status_create_db = create_db(DATABASE_NAME, DATABASE_USER, DATABASE_PASSWORD,
                             DATABASE_HOST, DATABASE_PORT)

status_create_tables = create_tables(DATABASE_NAME, DATABASE_USER, DATABASE_PASSWORD, DATABASE_HOST,
                                     DATABASE_PORT, file_reader.FileReader(SQL_PATH).read_sql(),
                                     status_create_db)

status_upload_data = upload_data(DATABASE_NAME, DATABASE_USER, DATABASE_PASSWORD, DATABASE_HOST,
                                 DATABASE_PORT, status_create_tables, CSV_PATH)

if status_upload_data:
    print("Данные успешно загружены")
else:
    print("Удалите базу данных для повторного создания")
