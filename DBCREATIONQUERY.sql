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
ShowID              INTEGER             NOT NULL,
CinemaID			INTEGER				NOT NULL,
SeatID              INTEGER				NOT NULL,
PRIMARY KEY         (BookingID,SeatID),
FOREIGN KEY         (BookingID)         REFERENCES Bookings,
FOREIGN KEY         (ShowID)            REFERENCES Shows,
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


INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('La La Land', 'Damien Chazelle', CAST(N'02:08:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Shawshank Redemption', 'Frank Darabont', CAST(N'02:22:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Godfather', 'Francis Ford Coppola', CAST(N'02:55:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Dark Knight', 'Christopher Nolan', CAST(N'02:32:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Pulp Fiction', 'Quentin Tarantino', CAST(N'02:34:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Lord of the Rings The Return of the King', N'Peter Jackson', CAST(N'03:21:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Fight Club', 'David Fincher', CAST(N'02:19:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Inception', 'Christopher Nolan', CAST(N'02:28:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Forrest Gump', 'Robert Zemeckis', CAST(N'02:22:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Matrix', 'Lana Wachowski', CAST(N'02:16:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Goodfellas', 'Martin Scorsese', CAST(N'02:26:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Se7en', N'David Fincher', CAST(N'02:07:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Interstellar', 'Christopher Nolan', CAST(N'02:49:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Silence of the Lambs', N'Jonathan Demme', CAST(N'01:58:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Green Mile', 'Frank Darabont', CAST(N'03:09:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Gladiator', 'Ridley Scott', CAST(N'02:35:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Prestige', 'Christopher Nolan', CAST(N'02:10:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Memento', 'Christopher Nolan', CAST(N'01:53:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('The Departed', 'Martin Scorsese', CAST(N'02:31:00' AS Time)) 
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Whiplash', 'Damien Chazelle', CAST(N'01:47:00' AS Time))
INSERT INTO Movies (MovieName, Director, Runtime) VALUES ('Django Unchained', 'Quentin Tarantino', CAST(N'02:45:00' AS Time))
GO


INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (1,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (2,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (3,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (4,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (5,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (6,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (7,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (8,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (9,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (10,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (11,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (12,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (13,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (14,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (15,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (16,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (17,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (18,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (19,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (20,1,CAST('02:00:00' AS Time))
INSERT INTO Shows (MovieID,CinemaID,StartTime) VALUES (21,1,CAST('02:00:00' AS Time))

INSERT INTO MovieReviews (UserID, MovieID, Rating) VALUES (5267,1,4)


INSERT INTO HelpTickets (UserID,Header,Content) VALUES (5267,'help','kofta gedan')
INSERT INTO HelpTickets (UserID,Header,Content) VALUES (5267,'Issue with Orders','kofta gedan 2: electric boogaloo')

INSERT INTO FoodItems (FoodName, FoodQty, Price, FoodDescription) VALUES ('Pop-Corn', 500, 50, 'Feshar yasta enta 3abeet?')
INSERT INTO FoodItems (FoodName, FoodQty, Price, FoodDescription) VALUES ('Kofta', 20, 300, 'kofta not kobeba dumbass')

INSERT INTO Orders (UserID) VALUES (5267)

INSERT INTO Orders_Details (OrderID, FoodID, OrderCount) VALUES (1, 2, 6)
INSERT INTO Orders_Details (OrderID, FoodID, OrderCount) VALUES (1, 1, 3)

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