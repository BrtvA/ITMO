import psycopg2


class DbConnector:
    def __init__(self, db_name: str, db_users: str,
                 db_password: str, db_host: str, db_port: str):
        self.__db_name = db_name
        self.__db_users = db_users
        self.__db_password = db_password
        self.__db_host = db_host
        self.__db_port = db_port

    def execute_query(self, sql_query: str, param=None):
        try:
            create_connect = psycopg2.connect(dbname=self.__db_name,
                                              user=self.__db_users,
                                              password=self.__db_password,
                                              host=self.__db_host,
                                              port=self.__db_port)
            curs = create_connect.cursor()
            create_connect.autocommit = False
            if param is None:
                curs.execute(sql_query)
            else:
                curs.execute(sql_query, param)
            create_connect.commit()
            result = curs.fetchall()
        except (Exception, psycopg2.Error) as error:
            create_connect.rollback()
            print(f"Ошибка при выполнении запроса\n", error)
            result = [-999]
        finally:
            if create_connect:
                curs.close()
                create_connect.close()
        return result


if __name__ == "__main__":
    connector = DbConnector("test_market",
                            "postgres",
                            "pgpassword",
                            "127.0.0.1",
                            "5432")
    print(connector.execute_query("SELECT * FROM markets"))