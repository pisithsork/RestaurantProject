-- CREATE DATABASE RestaurantDB;

GO
DROP TABLE Grade;
DROP TABLE Score;
DROP TABLE Menu;
DROP TABLE Restaurant;


GO
SELECT * FROM Grade;
SELECT * FROM Score;
SELECT * FROM Menu;
SELECT * FROM Restaurant;

GO

CREATE TABLE Restaurant
(
    id INT NOT NULL IDENTITY PRIMARY KEY,
    rest_id INT NOT NULL,
    name NVARCHAR(20) NOT NULL,
    address NVARCHAR(50) NOT NULL,
    city NVARCHAR(20) NOT NULL,
    state VARCHAR(2) NOT NULL,
    cuisine_type NVARCHAR(20) NOT NULL
);

CREATE TABLE Menu
(
    dish_id INT IDENTITY PRIMARY KEY,
	cuisine_res INT NOT NULL FOREIGN KEY REFERENCES Restaurant(id),
    dish NVARCHAR(50) NOT NULL,
    price DECIMAL NOT NULL,
);

CREATE TABLE Score
(
	score_id INT IDENTITY PRIMARY KEY,
	rest_scoreid INT FOREIGN KEY REFERENCES Restaurant(id),
	score INT NOT NULL,
	score_date DATE NOT NULL,
);

CREATE TABLE Grade
(
	grade_id INT NOT NULL IDENTITY PRIMARY KEY,
	rest_gradeid INT NOT NULL FOREIGN KEY REFERENCES Restaurant(id),
	grade CHAR NOT NULL,
	grade_date DATE NOT NULL
);

-- CREATE TABLE Cuisine
-- (
--     cuisine_id INT NOT NULL IDENTITY PRIMARY KEY,
--     rest_cuisineid INT NOT NULL FOREIGN KEY REFERENCES Restaurant(id),
--     cuisine_type NVARCHAR(20) NOT NULL
-- );
