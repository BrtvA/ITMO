from . import db_connector
# import db_connector

class QueryManager:
    def __init__(self, db_name: str, db_users: str,
                 db_password: str, db_host: str, db_port: str):
        self.__connector = db_connector.DbConnector(db_name, db_users, db_password,
                                                    db_host, db_port)

    def get_sort_markets_list(self, sort_param: str, sort_type: str,
                              x_pos: float, y_pos: float,
                              page_num: int = 1, page_size: int = 20):
        match sort_param:
            case "id":
                srt_prm = "markets.id"
            case "name":
                srt_prm = "markets.name"
            case "street":
                srt_prm = "street"
            case "city":
                srt_prm = "city"
            case "county":
                srt_prm = "county"
            case "state":
                srt_prm = "state"
            case "distance":
                srt_prm = "distance"
            case "zip":
                srt_prm = "zip"
            case _:
                srt_prm = "rating"

        if sort_type == "asc":
            srt_tp = "ASC"
        else:
            srt_tp = "DESC"

        sql_query = f'''
            SELECT markets.id, markets.name,
		        (SELECT STRING_AGG(streets.name,', ')
		        FROM markets_streets
			        JOIN streets
				        ON streets.id = markets_streets.street_id
		        WHERE markets_streets.market_id = markets.id) as street,
		        (SELECT STRING_AGG(cities.name,', ')
		        FROM markets_cities
			        JOIN cities
				        ON cities.id = markets_cities.city_id
		        WHERE markets_cities.market_id = markets.id) as city,
		        counties.name as county, states.name as state,
		        zips.code as zip,
		        TRUNC(fn_get_distance_between(markets.x_position, markets.y_position,
                                                {x_pos}, {y_pos})) as distance,
		        (SELECT ROUND(AVG(ratings.value), 1)
		        FROM markets_ratings
			        JOIN ratings
				        ON ratings.id = markets_ratings.rating_id
		        WHERE markets_ratings.market_id = markets.id) as rating
            FROM markets 
	            JOIN counties 
		            ON counties.id = markets.county_id
	            JOIN states 
		            ON states.id = markets.state_id
		        JOIN zips
		            ON zips.id = markets.zip_id
		    ORDER BY {srt_prm} {srt_tp}
		    LIMIT {page_size} OFFSET {page_num * page_size + 1};
        '''

        return self.__connector.execute_query(sql_query)

    def find_markets_list(self, city_name: str, state_name: str,
                          zip_code: str, distance: float,
                          x_pos: float, y_pos: float) -> list:
        # param = (city_name, state_name, zip_code, distance)

        sql_query = f'''
            SELECT * FROM (
	            SELECT markets.id, markets.name,
		            (SELECT STRING_AGG(streets.name,', ')
		            FROM markets_streets
			            JOIN streets
				            ON streets.id = markets_streets.street_id
		            WHERE markets_streets.market_id = markets.id) as street,
		            (SELECT STRING_AGG(cities.name,', ')
		            FROM markets_cities
			            JOIN cities
				            ON cities.id = markets_cities.city_id
		            WHERE markets_cities.market_id = markets.id) as city,
		            counties.name as county, states.name as state,
		            zips.code as zip,
		            TRUNC(fn_get_distance_between(markets.x_position, markets.y_position,
		                                            {x_pos}, {y_pos})) as distance,
		            (SELECT ROUND(AVG(ratings.value), 1)
		            FROM markets_ratings
			            JOIN ratings
				            ON ratings.id = markets_ratings.rating_id
		            WHERE markets_ratings.market_id = markets.id) as rating
	            FROM markets 
		            JOIN counties 
			            ON counties.id = markets.county_id
		            JOIN states 
			            ON states.id = markets.state_id
		            JOIN zips
			            ON zips.id = markets.zip_id) AS foo
	        WHERE city = '{city_name}' AND state = '{state_name}'
	        AND zip = '{zip_code}'
        '''

        if distance > 0:
            sql_query = f"{sql_query} AND distance < {distance}"

        return self.__connector.execute_query(sql_query)

    def get_info(self, market_id: int) -> list[tuple]:
        sql_query = f'''
            SELECT markets.id, markets.name,
		        (SELECT ROUND(AVG(ratings.value), 1)
		        FROM markets_ratings
			        JOIN ratings
				        ON ratings.id = markets_ratings.rating_id
		        WHERE markets_ratings.market_id = markets.id) as rating,
		        markets.update_time,
		        ARRAY(SELECT CONCAT(medias.name, ' : ', markets_medias.url)
		        FROM markets_medias
			        JOIN medias
				        ON medias.id = markets_medias.media_id
		        WHERE markets_medias.market_id = markets.id) as media,
		        (SELECT STRING_AGG(streets.name,', ')
		        FROM markets_streets
			        JOIN streets
				        ON streets.id = markets_streets.street_id
		        WHERE markets_streets.market_id = markets.id) as street,
		        (SELECT STRING_AGG(cities.name,', ')
		        FROM markets_cities
			        JOIN cities
				        ON cities.id = markets_cities.city_id
		        WHERE markets_cities.market_id = markets.id) as city,
		        counties.name as county, states.name as state,
		        zips.code as zip, markets.x_position, markets.y_position,
		        ARRAY(SELECT CONCAT(from_date, ' to ', to_date, ' $ ', time_interval)
		        FROM markets_seasons
		        WHERE markets_seasons.market_id = markets.id) as season,
		        ARRAY(SELECT additionals.name
		        FROM markets_additionals
			        JOIN additionals
				        ON additionals.id = markets_additionals.additional_id
		        WHERE markets_additionals.market_id = markets.id) as additional,
		        ARRAY(SELECT categories.name
		        FROM markets_categories
			        JOIN categories
				        ON categories.id = markets_categories.category_id
		        WHERE markets_categories.market_id = markets.id) as category
            FROM markets 
	            JOIN counties 
		            ON counties.id = markets.county_id
	            JOIN states 
		            ON states.id = markets.state_id
	            JOIN zips
		            ON zips.id = markets.zip_id
            WHERE markets.id = {market_id};
        '''
        data = self.__connector.execute_query(sql_query)
        print(data)

        market_id = data[0][0]
        market_name = data[0][1]
        market_rating = data[0][2]
        market_update_time = data[0][3]

        market_contacts = []
        for item in data[0][4]:
            temp_list = item.split(" : ")
            market_contacts.append(temp_list)

        market_streets = data[0][5]
        market_cities = data[0][6]
        market_county = data[0][7]
        market_state = data[0][8]
        market_zip = data[0][9]
        market_x_pos = data[0][10]
        market_y_pos = data[0][11]

        market_seasons = []
        for item in data[0][12]:
            temp_list = item.split(" $ ")
            if temp_list[0] == " to ":
                temp_list[0] = None
            market_seasons.append(temp_list)

        market_additionals = data[0][13]
        market_categories = data[0][14]

        return [market_id, market_name, market_rating, market_update_time, market_contacts,
                market_streets, market_cities, market_county, market_state, market_zip,
                market_x_pos, market_y_pos, market_seasons, market_additionals, market_categories]

    def add_review(self, market_id: int, rating: int,
                   firstname: str, lastname: str,
                   text: str):
        sql_query = '''
            INSERT INTO markets_ratings
            (market_id, rating_id, firstname, lastname, text)
            VALUES(%s, %s, %s, %s, %s)
        '''
        if text.strip() == "":
            text = None

        self.__connector.execute_query(sql_query, (market_id, rating, firstname,
                                                   lastname, text))

    def get_review(self, market_id: int):
        sql_query = f'''
            SELECT markets_ratings.firstname, markets_ratings.lastname,
		            ratings.value, markets_ratings.text
            FROM markets_ratings
	            JOIN ratings
		            ON ratings.id = markets_ratings.rating_id
            WHERE markets_ratings.market_id = {market_id}
        '''
        return self.__connector.execute_query(sql_query)


if __name__ == "__main__":
    manager = QueryManager("test_market",
                           "postgres",
                           "pgpassword",
                           "127.0.0.1",
                           "5432")
    print(manager.get_sort_markets_list("id", "asc", 38.8951, 77.0364))
