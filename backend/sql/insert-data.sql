GO
INSERT INTO Restaurant(rest_id, name, address, city, state, cuisine_type)
VALUES

    (1, 'Olive Garden', '2512 Wetbread Way', 'Morrow', 'GA', 'Italian'),
    (2, 'Panda Express', '3958 Longrice Blvd', 'Orlando', 'FL', 'Chinese'),
    (3, 'Chipotle', '2389 Beansrock St.', 'Los Angeles', 'CA', 'Mexican'),
    (4, 'Papa Reginald', '2948 Discshape Rd.', 'New York', 'NY', 'Italian'),
    (5, 'Taco Bell', '4977 Krakatoa Blvd.', 'Seattle', 'WA', 'Mexican'),
    (6, 'Wendys', '5802 Bestfry', 'Atlanta', 'GA', 'American'),
    (7, 'Huddy Bistro', '1122 Stone Rd.', 'Atlanta', 'GA', 'American'),
    (8, 'Olive Catch', '488 Summerhouse Dr.', 'Pikesville', 'MD', 'Italian'),
    (9, 'Savory Goddess', '62 Andover Ave', 'West Hempstead', 'NY', 'American'),
    (9, 'Savory Goddess', '62 Andover Ave', 'West Hempstead', 'NY', 'French'),
    (10, 'Proud Salmon', '876 S. Hill St.', 'Union City', 'NJ', 'Seafood'),
    (11, 'Friendly Lane', '8214 Edgefield Ave.', 'Dallas', 'TX', 'Mexican'),
    (12, 'The Turban', '8352 Ashley St.', 'Omaha', 'NE', 'Middle Eastern'),
    (13, 'The Crown', '4888 Old York St.', 'Fenton', 'MI', 'French'),
    (14, 'The Noodle Moment', '7482 San Juan Rd.', 'Newport News', 'VA', 'Chinese'),
    (15, 'Chopstix', '8484 Manor Station Dr.', 'Dallas', 'TX', 'Japanese'),
    (16, 'Lemon Grass', '9873 East High Point St.', 'Hyattsville', 'WA', 'Thai'),
    (17, '777', '7 Livingston Rd.', 'Hightstown', 'NY', 'Chinese'),
    (18, 'The Silver Fish', '4452 River Dr.', 'East Elmhurst', 'FL', 'Seafood'),
    (19, 'Endless Bar N Grill', '646 Nichols St.', 'Passaic', 'NY', 'American'),
    (19, 'Endless Bar N Grill', '646 Nichols St.', 'Passaic', 'NY', 'Italian'),
    (19, 'Endless Bar N Grill', '646 Nichols St.', 'Passaic', 'NY', 'Chinese'),
    (20, 'TGIF', '4239 Jackon Blvd', 'Atlanta', 'GA', 'American'),
    (20, 'TGIF', '4239 Jackon Blvd', 'Atlanta', 'GA', 'Seafood'),
    (21, 'Harvest Lounge', '2357 Strawberry Dr.', 'Waynesboro', 'PA', 'Mexican'),
    (22, 'McDonald', '2243 Park Ave', 'Compton', 'NY', 'American'),
    (23, 'Regional Bar', '4877 Newark St.', 'Long Island', 'NY', 'American'),
    (24, 'Ginos Pizzaria', '3392 5th St.', 'New York', 'NY', 'Italian'),
    (25, 'Eatalionos', '1122 23rd Ave.', 'New York', 'NY', 'Italian'),
    (26, 'Grill n Chill', '1000 Strawberry St.', 'Seattle', 'WA', 'Mexican'),
    (27, 'Mama Chang', '3883 Adolfo Rd.', 'Los Angeles', 'CA', 'Chinese'),
    (27, 'Mama Chang', '3883 Adolfo Rd.', 'Los Angeles', 'CA', 'Italian');

GO
INSERT INTO Menu(cuisine_res, dish, price)
VALUES

    (7, 'Cheeseburger', 15.50),
    (5, 'Beefy Layered Nachos', 18.88),
    (8, 'Spaghetti and Meatballs', 14.47),
    (20, '16oz T-Bone Steak', 26.50),
    (20, '1/2 lb Seafood Platter', 32.48),
    (12, 'Baba Ghannouji', 8.75),
    (10, 'Tilapia Dinner Plate', 19.00),
    (19, 'Carbonara', 22.50),
    (10, '1 lb King Crab', 50.00),
    (16, 'Papaya Salad', 10.00),
    (6, 'Beef Brisket Sandwich', 19.50),
    (6, 'Potato Salad', 5.00),
    (4, 'Gnocchi w/ Sage Butter', 17.50),
    (3, 'Kids Meal', 15.00),
    (13, 'Duck Confit', 50.00),
    (3, 'Beef Bowl', 20.00),
    (8, 'Lasagna', 18.99),
    (5, 'Medium Baja Blast', 1.99),
    (2, 'Dinner Plate', 12.99),
    (5, '12 Taco Party Pack', 15.00),
    (1, 'Spaghetti and Meatball', 22.50),
    (21, 'Beef Birillia Tacos', 5.00),
    (3, 'Chicken Burrito', 15.99),
    (19, 'Bun Bao', 6.99),
    (5, 'Chicken Quessadilla Meal', 9.99),
    (6, '20 Piece Spicy Nuggets', 19.99),
    (13, 'Beef Bourguignon', 29.74),
    (13, 'Steak Frite', 24.00),
    (10, 'Raw Oysters', 25.00),
    (14, 'Chinese Spare Ribs', 15.00),
    (20, 'Double Bacon Jalapeno Burger', 16.99),
    (20, 'Salmon Dinner Plate', 17.00),
    (3, '3 Beef Tacos', 15.00),
    (9, 'Jambalaya', 20.00),
    (9, 'Escagot', 100.00),
    (11, 'Salmon Dinner Plater', 22.00),
    (12, 'Falafel and Hummus', 16.00),
    (15, 'Pork Ramen', 15.00),
    (15, 'Gyoza Dumplings and Tofu Soup', 14.00),
    (17, 'Szechuan Beef', 19.99),
    (18, 'Fried Oysters', 25.00),
    (17, 'House Fried Rice', 15.00),
    (19, 'Lobster Roll', 19.00),
    (19, 'Mapo Tofu', 22.50),
    (19, 'Chicken Tenders and Fries', 12.00),
    (20, 'Chorizo Torta', 12.00),
    (20, 'Lobster Roll', 18.00),
    (9, 'Ratatouille', 57.00),
    (13, 'Coq au vin', 50.00),
    (19, 'Steak and Potatoes', 20.00),
    (16, 'Sticky Rice and Meatballs', 16.93),--
    (22, 'Big Mac Meal', 11.10),
    (22, 'McFlurry', 4.00),
    (23, 'Fried Chicken', 16.00),
    (23, 'Margarita', 9.00),
    (24, 'Cheese Pizza', 12.00),
    (24, 'Slice of Pepperoni Pizza', 0.99),
    (25, 'Cheese Sticks', 10.00),
    (25, 'Cheese Pizza', 16.00),
    (26, 'Chicken Quesadilla', 15.00),
    (26, 'Cheese and Spinach Dip', 12.00),
    (27, 'Chow Mein', 25.00),
    (27, 'Birria Burrito', 22.00);

GO
INSERT INTO Score(rest_scoreid, score, score_date)
VALUES
    (1, 95, '2022-06-18'),
    (2, 41, '2022-02-19'),
    (3, 55, '2022-03-07'),
    (4, 37, '2022-07-20'),
    (5, 35, '2022-07-28'),
    (6, 4, '2022-09-07'),
    (7, 53, '2022-08-15'),
    (8, 58, '2022-06-24'),
    (9, 58, '2022-12-10'),
    (10, 45, '2022-08-15'),
    (11, 62, '2022-04-05'),
    (12, 72, '2022-05-12'),
    (13, 61, '2022-09-18'),
    (14, 83, '2022-11-20'),
    (15, 86, '2022-12-21'),
    (16, 29, '2022-07-23'),
    (17, 55, '2022-12-26'),
    (18, 88, '2022-11-10'),
    (19, 72, '2022-08-09'),
    (20, 66, '2022-01-30'),
    (21, 39, '2022-01-01'),
    (22, 9, '2022-02-02'),
    (23, 39, '2022-01-01'),
    (24, 93, '2022-02-15'),
    (25, 39, '2022-05-25'),
    (26, 87, '2022-08-20'),
    (27, 91, '2022-10-11');


GO
INSERT INTO Grade(rest_gradeid, grade, grade_date)
VALUES

    (1, 'B', '2022-02-02'),
    (2, 'D', '2022-02-17'),
    (3, 'B', '2022-02-24'),
    (4, 'B', '2022-03-29'),
    (5, 'C', '2022-04-07'),
    (6, 'D', '2022-04-11'),
    (7, 'D', '2022-04-20'),
    (8, 'B', '2022-04-28'),
    (9, 'B', '2022-04-30'),
    (10, 'A', '2022-05-11'),
    (11, 'D', '2022-05-28'),
    (12, 'C', '2022-06-03'),
    (13, 'A', '2022-07-13'),
    (14, 'C', '2022-07-22'),
    (15, 'A', '2022-08-07'),
    (16, 'B', '2022-08-18'),
    (17, 'A', '2022-10-01'),
    (18, 'C', '2022-10-06'),
    (19, 'D', '2022-10-11'),
    (20, 'C', '2022-10-12'),
    (21, 'D', '2022-10-19'),
    (22, 'B', '2022-12-05'),
    (23, 'C', '2022-12-23'),
    (24, 'A', '2022-04-18'),
    (25, 'A', '2022-12-06'),
    (26, 'C', '2022-12-07'),
    (27, 'B', '2022-12-17');