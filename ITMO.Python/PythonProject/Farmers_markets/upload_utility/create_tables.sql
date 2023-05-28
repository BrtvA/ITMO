CREATE TABLE additionals (
    id SERIAL PRIMARY KEY NOT NULL,
    name character varying(10) NOT NULL
);

CREATE TABLE categories
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(20) NOT NULL
);

CREATE TABLE cities
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(60) NOT NULL
);

CREATE TABLE counties
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(50) NOT NULL
);

CREATE TABLE medias
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(20) NOT NULL
);

CREATE TABLE ratings
(
	id SERIAL PRIMARY KEY NOT NULL,
	value SMALLINT NOT NULL
);

CREATE TABLE states
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(50) NOT NULL
);

CREATE TABLE streets
(
	id SERIAL PRIMARY KEY NOT NULL,
	name VARCHAR(75) NOT NULL
);

CREATE TABLE zips
(
	id SERIAL PRIMARY KEY NOT NULL,
	code VARCHAR(10) NOT NULL
);

CREATE TABLE markets
(
	id INTEGER PRIMARY KEY NOT NULL,
	name VARCHAR(100) NOT NULL,
	county_id INTEGER REFERENCES counties(id),
	state_id INTEGER REFERENCES states(id),
	zip_id INTEGER REFERENCES zips(id),
	x_position REAL,
	y_position REAL,
	update_time VARCHAR(25)
);

CREATE TABLE markets_additionals
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	additional_id INTEGER REFERENCES additionals(id) NOT NULL,
	PRIMARY KEY(market_id, additional_id)
);

CREATE TABLE markets_categories
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	category_id INTEGER REFERENCES categories(id) NOT NULL,
	PRIMARY KEY(market_id, category_id)
);

CREATE TABLE markets_medias
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	media_id INTEGER REFERENCES medias(id) NOT NULL,
	url VARCHAR(160) NOT NULL,
	PRIMARY KEY(market_id, media_id, url)
);

CREATE TABLE markets_ratings
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	rating_id INTEGER REFERENCES ratings(id) NOT NULL,
	firstname VARCHAR(20) NOT NULL,
	lastname VARCHAR(20) NOT NULL,
	text VARCHAR(200)
);

CREATE TABLE markets_seasons
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	from_date VARCHAR(11),
	to_date VARCHAR(11),
	time_interval VARCHAR(160)
);

CREATE TABLE markets_cities
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	city_id INTEGER REFERENCES cities(id) NOT NULL,
	PRIMARY KEY(market_id, city_id)
);

CREATE TABLE markets_streets
(
	market_id INTEGER REFERENCES markets(id) ON DELETE CASCADE NOT NULL,
	street_id INTEGER REFERENCES streets(id) NOT NULL,
	PRIMARY KEY(market_id, street_id)
);

CREATE FUNCTION fn_get_distance_between
(x2 DOUBLE PRECISION, y2 DOUBLE PRECISION,
 x1 DOUBLE PRECISION DEFAULT 38.8951,
 y1 DOUBLE PRECISION DEFAULT 77.0364,
 radius DOUBLE PRECISION DEFAULT 3958.76)
RETURNS DOUBLE PRECISION
LANGUAGE plpgsql
AS $distance$
DECLARE
	distance DOUBLE PRECISION;
BEGIN
	distance = 2 * radius * SQRT(SIND((x2-x1)/2)^2 + COSD(x1)*COSD(x2)*SIND((y2-y1)/2)^2);
RETURN distance;
END; 
$distance$;