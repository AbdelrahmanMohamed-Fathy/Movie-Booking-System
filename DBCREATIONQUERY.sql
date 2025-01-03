----------------------------------------Database Creation----------------------------------------
USE master;
GO
ALTER DATABASE MovieBooking_system SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE IF EXISTS MovieBooking_system;
GO
CREATE DATABASE MovieBooking_system;
GO
USE MovieBooking_system;
GO
--------------------------------------------Functions--------------------------------------------
CREATE FUNCTION dbo.GetEndTime (@MovieID INTEGER,@StartTime TIME)
RETURNS TIME
AS
BEGIN
    DECLARE @EndTime TIME;

    SELECT @EndTime = DATEADD(MINUTE, DATEDIFF(MINUTE,0,Runtime),@StartTime)
    FROM Movies
    WHERE MovieID = @MovieID;

    RETURN @EndTime;
END;
GO
----------------------------------------
CREATE FUNCTION dbo.GetBookingPrice (@BookingID INTEGER)
RETURNS DECIMAL
AS
BEGIN
    DECLARE @Price DECIMAL;

    SELECT @Price = Price*COUNT(Seats)
    FROM Seats, BookingSeats
    WHERE BookingSeats.SeatID = Seats.SeatID AND BookingSeats.BookingID = @BookingID;

    RETURN @Price;
END;
GO
----------------------------------------
--CREATE FUNCTION dbo.CheckOldShows (@ShowID INTEGER)
--RETURNS BIT
--AS
--BEGIN
--    DECLARE @isOld BIT
--    IF EXISTS(SELECT CAST(ShowDate AS DATETIME) + CAST(EndTime AS DATETIME) AS CombinedDate
--              FROM Shows
--              WHERE CombinedDate < NOW() AND ShowID = @ShowID)
--        SET @IsOld = 1
--    ELSE
--        SET @IsOld = 0
--    RETURN @isOld;
--END;
--GO
---------------------------------------------Tables----------------------------------------------
CREATE TABLE Accounts (
UserID			INTEGER 		NOT NULL IDENTITY(5267,1),
Fname			VARCHAR(20)		NOT NULL,
Lname			VARCHAR(20)		NOT NULL,
Email			VARCHAR(50)		NOT NULL UNIQUE,
Pass			VARCHAR(64)		NOT NULL,
PhoneNumber		INTEGER         NOT NULL DEFAULT -1,
Authority		VARCHAR(10)		NOT NULL CHECK (Authority IN ('Admin', 'Employee', 'Client')),
PRIMARY KEY		(UserID)
);
GO
----------------------------------------
CREATE TABLE Movies (
MovieID				INTEGER			NOT NULL IDENTITY(1,1),
MovieName			VARCHAR(50)		NOT NULL,
Director			VARCHAR(20)		NOT NULL,
Runtime				TIME			NOT NULL,
MovieDescription    VARCHAR(200)    NOT NULL DEFAULT '',
MoviePicturePath    AS '..\..\Assets\Movies\' + MovieName + '.png',
PRIMARY KEY			(MovieID),
);
----------------------------------------
CREATE TABLE FoodItems (
FoodID				INTEGER			NOT NULL IDENTITY(1,1),
FoodName			VARCHAR(20)		NOT NULL,
FoodQty				INTEGER			NOT NULL,
Price				DECIMAL			NOT NULL,
FoodDescription		VARCHAR(200)	NOT NULL DEFAULT '',
PRIMARY KEY			(FoodID)
);
---------------------------------------
CREATE TABLE Cinemas (
CinemaID			INTEGER			NOT NULL IDENTITY(1,1),
CinemaType			VARCHAR(10)		NOT NULL,
CinemaManagerID		INTEGER			REFERENCES Accounts,
PRIMARY KEY			(CinemaID)
);
GO
-------------------------------------------------------------------------------------------------
CREATE TABLE Shows (
ShowID				INTEGER			NOT NULL IDENTITY(1,1),
MovieID             INTEGER         NOT NULL,
CinemaID            INTEGER         NOT NULL,
ShowDate			DATE			NOT NULL DEFAULT GETDATE(),
StartTime			TIME			NOT NULL,
EndTime             AS dbo.GetEndTime(MovieID,StartTime),
Old                 BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(ShowID),
FOREIGN KEY         (MovieID)       REFERENCES Movies,
);
GO
---------------------------------------
CREATE TABLE Seats (
SeatNumber			INTEGER			NOT NULL,
CinemaID			INTEGER			NOT NULL,
Price				DECIMAL			NOT NULL,
FOREIGN KEY			(CinemaID)      REFERENCES Cinemas,
PRIMARY KEY			(CinemaID,SeatNumber)
);
GO
---------------------------------------
CREATE TABLE Bookings (
BookingID			INTEGER				NOT NULL IDENTITY(9034,1),
UserID              INTEGER				NOT NULL,
ShowID              INTEGER				NOT NULL,
Price               AS dbo.GetBookingPrice(BookingID),
PRIMARY KEY			(BookingID),
FOREIGN KEY         (UserID)			REFERENCES Accounts,
FOREIGN KEY         (ShowID)			REFERENCES Shows
);
GO
---------------------------------------
CREATE TABLE BookingSeats (
BookingID			INTEGER				NOT NULL,
CinemaID			INTEGER				NOT NULL,
SeatID              INTEGER				NOT NULL,
PRIMARY KEY         (BookingID,SeatID),
FOREIGN KEY         (BookingID)         REFERENCES Bookings,
FOREIGN KEY         (CinemaID,SeatID)   REFERENCES Seats
);
---------------------------------------
CREATE TABLE Orders(
OrderID             INTEGER			NOT NULL IDENTITY(1,1),
UserID              INTEGER         NOT NULL,
Fulfilled           BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(OrderID),
FOREIGN KEY			(UserID)        REFERENCES Accounts
);
---------------------------------------
CREATE TABLE Orders_Details (
OrderID				INTEGER			NOT NULL,
FoodID				INTEGER			NOT NULL,
OrderCount			INTEGER			NOT NULL,
PRIMARY KEY			(OrderID,FoodID),
FOREIGN KEY			(FoodID)        REFERENCES Fooditems
);
---------------------------------------
CREATE TABLE HelpTickets (
HelpTicketID		INTEGER			NOT NULL IDENTITY(5867,1),
UserID              INTEGER         NOT NULL,
Header				VARCHAR(50)		NOT NULL,
Content				VARCHAR(500)	NOT NULL,
Seen				BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(HelpTicketID,UserID),
FOREIGN KEY         (UserID)        REFERENCES Accounts
);
---------------------------------------
CREATE TABLE MovieReviews (
UserID              INTEGER         NOT NULL,
MovieID             INTEGER         NOT NULL,
Rating				INTEGER			NOT NULL CHECK (Rating > 0 AND Rating <6),
PRIMARY KEY			(MovieID,UserID),
FOREIGN KEY         (MovieID)       REFERENCES Movies,
FOREIGN KEY         (UserID)        REFERENCES Accounts
);
---------------------------------------
GO

INSERT INTO Accounts VALUES ('Ahmed', 'Soltan', 'A7medsoltan2004@gmail.com', '12345', 1203547383, 'Admin')
INSERT INTO Accounts (Fname,Lname,Email,Pass,Authority) VALUES ('Abdelrahman', 'Fathy', 'test@test.com','test','Client')
INSERT INTO Accounts (Fname, Lname, Email, Pass, Authority) VALUES
('Benjamin', 'Hernandez', 'benjamin.hernandez@example.com', 'pass6778', 'Admin'),
('Jane', 'Lewis', 'jane.lewis@example.com', 'pass7527', 'Admin'),
('Lucas', 'Taylor', 'lucas.taylor@example.com', 'pass9532', 'Client'),
('Abigail', 'Sanchez', 'abigail.sanchez@example.com', 'pass9291', 'Employee'),
('Benjamin', 'Garcia', 'benjamin.garcia@example.com', 'pass6527', 'Employee'),
('Lucas', 'Sanchez', 'lucas.sanchez@example.com', 'pass9824', 'Admin'),
('Harper', 'Jackson', 'harper.jackson@example.com', 'pass1808', 'Employee'),
('Mia', 'Robinson', 'mia.robinson@example.com', 'pass2500', 'Admin'),
('Sarah', 'Lopez', 'sarah.lopez@example.com', 'pass7521', 'Admin'),
('Sarah', 'Brown', 'sarah.brown@example.com', 'pass7537', 'Client'),
('Sarah', 'Thomas', 'sarah.thomas@example.com', 'pass2213', 'Admin'),
('Sarah', 'Moore', 'sarah.moore@example.com', 'pass1138', 'Admin'),
('Harper', 'Wilson', 'harper.wilson@example.com', 'pass2578', 'Employee'),
('Amelia', 'Jackson', 'amelia.jackson@example.com', 'pass5089', 'Admin'),
('Lucas', 'Lewis', 'lucas.lewis@example.com', 'pass4173', 'Client'),
('James', 'Hernandez', 'james.hernandez@example.com', 'pass1972', 'Employee'),
('Evelyn', 'Lewis', 'evelyn.lewis@example.com', 'pass3806', 'Client'),
('Benjamin', 'Lopez', 'benjamin.lopez@example.com', 'pass7303', 'Employee'),
('Harper', 'Taylor', 'harper.taylor@example.com', 'pass3448', 'Admin'),
('Elijah', 'Williams', 'elijah.williams@example.com', 'pass3629', 'Client'),
('Elijah', 'Walker', 'elijah.walker@example.com', 'pass1607', 'Employee'),
('Harper', 'Jackson', 'harper.jackson1@example.com', 'pass4938', 'Employee'),
('Alexander', 'Robinson', 'alexander.robinson@example.com', 'pass3029', 'Client'),
('Ella', 'Robinson', 'ella.robinson@example.com', 'pass3737', 'Employee'),
('Daniel', 'Hernandez', 'daniel.hernandez@example.com', 'pass5376', 'Client'),
('David', 'Williams', 'david.williams@example.com', 'pass7765', 'Client'),
('Olivia', 'Johnson', 'olivia.johnson@example.com', 'pass9412', 'Employee'),
('Daniel', 'Clark', 'daniel.clark@example.com', 'pass5379', 'Client'),
('Abigail', 'Miller', 'abigail.miller@example.com', 'pass9239', 'Client'),
('Benjamin', 'Martinez', 'benjamin.martinez@example.com', 'pass2274', 'Client');




INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('IMAX', 5267)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('Standard', 5268)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('4DX', 5269)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('VIP', 5270)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('Luxury', 5271)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('8D', 5272)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('Standard', 5273)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('VIP', 5274)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('Luxury', 5275)
INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('Standard', 5276)

INSERT INTO Cinemas (CinemaType, CinemaManagerID) VALUES ('IMAX',5267)
GO

INSERT INTO Seats VALUES (1,1,50)
INSERT INTO Seats VALUES (2,1,50)
INSERT INTO Seats VALUES (3,1,50)
INSERT INTO Seats VALUES (4,1,50)
INSERT INTO Seats VALUES (5,1,50)
INSERT INTO Seats VALUES (6,1,50)
INSERT INTO Seats VALUES (7,1,50)
INSERT INTO Seats VALUES (8,1,50)
INSERT INTO Seats VALUES (9,1,50)
INSERT INTO Seats VALUES (10,1,50)


INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('La La Land', 'Damien Chazelle', CAST(N'02:08:00' AS Time), 'When Sebastian, a pianist, and Mia, an actress, follow their passion and achieve success in their respective fields, they find themselves torn between their love for each other and their careers.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES('The Shawshank Redemption', 'Frank Darabont', CAST(N'02:22:00' AS Time), 'A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Godfather', 'Francis Ford Coppola', CAST(N'02:55:00' AS Time), 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Dark Knight', 'Christopher Nolan', CAST(N'02:32:00' AS Time), 'When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Pulp Fiction', 'Quentin Tarantino', CAST(N'02:34:00' AS Time), 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Lord of the Rings The Return of the King', N'Peter Jackson', CAST(N'03:21:00' AS Time), 'Gandalf and Aragorn lead the World of Men against Sauron''s army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Fight Club', 'David Fincher', CAST(N'02:19:00' AS Time), 'An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Inception', 'Christopher Nolan', CAST(N'02:28:00' AS Time), 'A thief steals corporate secrets using dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO, but his tragic past may doom the project and his team to disaster.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Forrest Gump', 'Robert Zemeckis', CAST(N'02:22:00' AS Time), 'The history of the United States from the 1950s to the ''70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Matrix', 'Lana Wachowski', CAST(N'02:16:00' AS Time), 'When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Goodfellas', 'Martin Scorsese', CAST(N'02:26:00' AS Time), 'The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Interstellar', 'Christopher Nolan', CAST(N'02:49:00' AS Time), 'When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Silence of the Lambs', N'Jonathan Demme', CAST(N'01:58:00' AS Time), 'A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Green Mile', 'Frank Darabont', CAST(N'03:09:00' AS Time), 'Paul Edgecomb, the head guard of a prison, meets an inmate, John Coffey, a black man who is accused of murdering two girls. His life changes drastically when he discovers that John has a special gift') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Gladiator', 'Ridley Scott', CAST(N'02:35:00' AS Time), 'A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Prestige', 'Christopher Nolan', CAST(N'02:10:00' AS Time), 'Rival 19th-century magicians engage in a bitter battle for trade secrets.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Memento', 'Christopher Nolan', CAST(N'01:53:00' AS Time), 'Leonard Shelby, an insurance investigator, suffers from anterograde amnesia and uses notes and tattoos to hunt for the man he thinks killed his wife, which is the last thing he remembers.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('The Departed', 'Martin Scorsese', CAST(N'02:31:00' AS Time), 'An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.') 
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Whiplash', 'Damien Chazelle', CAST(N'01:47:00' AS Time), 'A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student''s potential.')
INSERT INTO Movies (MovieName, Director, Runtime, MovieDescription) VALUES ('Django Unchained', 'Quentin Tarantino', CAST(N'02:45:00' AS Time), 'With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation owner in Mississippi.')
GO


INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (1,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (2,2,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (3,3,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (4,4,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (5,5,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (6,6,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (7,7,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (8,8,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (9,9,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (10,11,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (11,10,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (12,7,CAST('08:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (13,3,CAST('05:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (14,5,CAST('14:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (15,9,CAST('10:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (16,11,CAST('12:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (17,1,CAST('06:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (18,2,CAST('08:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (19,8,CAST('05:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (20,5,CAST('06:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (4,10,CAST('06:00:00' AS Time))

INSERT INTO MovieReviews (UserID, MovieID, Rating) VALUES (5267,1,4)

INSERT INTO HelpTickets (UserID,Header,Content) VALUES (5267,'help','kofta gedan')
INSERT INTO HelpTickets (UserID,Header,Content) VALUES (5267,'Issue with Orders','kofta gedan 2: electric boogaloo')

INSERT INTO FoodItems (FoodName, FoodQty, Price, FoodDescription) VALUES ('Pop-Corn', 500, 50, 'Feshar yasta enta 3abeet?')
INSERT INTO FoodItems (FoodName, FoodQty, Price, FoodDescription) VALUES ('Kofta', 20, 300, 'kofta not kobeba dumbass')

INSERT INTO Orders (UserID) VALUES (5267)
INSERT INTO Orders (UserID) VALUES (5268)

INSERT INTO Orders_Details (OrderID, FoodID, OrderCount) VALUES (1, 2, 6)
INSERT INTO Orders_Details (OrderID, FoodID, OrderCount) VALUES (1, 1, 3)
INSERT INTO Orders_Details (OrderID, FoodID, OrderCount) VALUES (2, 2, 4)

SELECT FoodItems.FoodName, SUM(OrderCount) AS Quantity , SUM(OrderCount*FoodItems.Price) AS Revenue
FROM Orders_Details, FoodItems
WHERE Orders_Details.FoodID = FoodItems.FoodID
GROUP BY FoodItems.FoodName
ORDER BY Quantity

SELECT Movies.MovieName, COUNT(Shows.ShowID) AS Total_Shows,SUM(Bookings.Price) AS Revenue
FROM Bookings, Movies, Shows
WHERE Bookings.ShowID = Shows.ShowID AND Shows.MovieID = Movies.MovieID
GROUP BY Movies.MovieName
ORDER BY Revenue

SELECT AVG(MovieReviews.Rating) AS Rating
FROM MovieReviews
WHERE MovieReviews.MovieID = MovieReviews.MovieID
GROUP BY MovieReviews.MovieID

SELECT  SeatNumber
FROM Seats
WHERE Seats.CinemaID = 1

SELECT *
FROM BookingSeats

SELECT *
FROM Accounts
