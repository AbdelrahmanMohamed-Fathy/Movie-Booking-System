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
    SELECT @ENDTime = StartTime + RunTime
    FROM Movies
    WHERE MovieID = @MovieID;
    RETURN @EndTime;
END;
GO
----------------------------------------
CREATE FUNCTION dbo.GetBookingPrice (@SeatID INTEGER)
RETURNS DECIMAL
AS
BEGIN
    DECLARE @Price DECIMAL;
    SELECT @Price = Price
    FROM Seats
    WHERE SeatID = @SeatID;
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
PhoneNumber		INTEGER,
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
ShowDate			DATE			NOT NULL,
StartTime			TIME			NOT NULL,
EndTime             AS dbo.GetEndTime(MovieID,StartTime),
Old                 BIT             NOT NULL,
PRIMARY KEY			(ShowID),
FOREIGN KEY         (MovieID)       REFERENCES Movies,
FOREIGN KEY         (CinemaID)      REFERENCES Cinemas
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
SeatID              INTEGER				NOT NULL,
CinemaID			INTEGER				NOT NULL,
ShowID              INTEGER				NOT NULL,
Price               AS dbo.GetBookingPrice(SeatID),
PaymentMethod		VARCHAR(20)			NOT NULL CHECK (Paymentmethod IN ('Cash', 'Credit')),
PRIMARY KEY			(BookingID),
FOREIGN KEY         (UserID)			REFERENCES Accounts,
FOREIGN KEY         (CinemaID,SeatID)	REFERENCES Seats,
FOREIGN KEY         (ShowID)			REFERENCES Shows
);
---------------------------------------
CREATE TABLE AllOrders(
OrderID             INTEGER			NOT NULL IDENTITY(5867,1),
UserID              INTEGER
PRIMARY KEY			(OrderID)

);
CREATE TABLE Orders_Details (
OrderID				INTEGER			NOT NULL,
FoodID				INTEGER			NOT NULL,
OrderCount			INTEGER			NOT NULL,
Fulfilled           BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(OrderID,FoodID),
FOREIGN KEY			(FoodID)        REFERENCES FoodItems,
FOREIGN KEY			(OrderID)        REFERENCES AllOrders
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
ReviewID			INTEGER			NOT NULL IDENTITY(1,1),
UserID              INTEGER         NOT NULL,
MovieID             INTEGER         NOT NULL,
Rating				INTEGER			NOT NULL,
Description   		VARCHAR(100)	NOT NULL DEFAULT '',
PRIMARY KEY			(ReviewID),
FOREIGN KEY         (MovieID)       REFERENCES Movies,
FOREIGN KEY         (UserID)        REFERENCES Accounts
);
---------------------------------------
CREATE TABLE FoodReviews (
ReviewID			INTEGER			NOT NULL IDENTITY(1,1),
UserID              INTEGER         NOT NULL,
FoodID              INTEGER         NOT NULL,
Rating				INTEGER			NOT NULL,
Description         VARCHAR(100)	NOT NULL DEFAULT '',
PRIMARY KEY			(ReviewID),
FOREIGN KEY         (FoodID)        REFERENCES FoodItems,
FOREIGN KEY         (UserID)        REFERENCES Accounts
);
---------------------------------------

INSERT INTO Accounts VALUES (N'Ahmed', N'Soltan', N'A7medsoltan2004@gmail.com', N'12345', 1203547383, N'Admin')
INSERT INTO Movies VALUES ('La La Land', N'Damien Chazelle', CAST(N'02:08:00' AS Time))
INSERT INTO Movies VALUES ('The Shawshank Redemption', N'Frank Darabont', CAST(N'02:22:00' AS Time))
INSERT INTO Movies VALUES ('The Godfather', N'Francis Ford Coppola', CAST(N'02:55:00' AS Time))
INSERT INTO Movies VALUES ('The Dark Knight', N'Christopher Nolan', CAST(N'02:32:00' AS Time)) 
INSERT INTO Movies VALUES ('Pulp Fiction', N'Quentin Tarantino', CAST(N'02:34:00' AS Time)) 
INSERT INTO Movies VALUES ('The Lord of the Rings: The Return of the King', N'Peter Jackson', CAST(N'03:21:00' AS Time))
INSERT INTO Movies VALUES ('Fight Club', N'David Fincher', CAST(N'02:19:00' AS Time)) 
INSERT INTO Movies VALUES ('Inception', N'Christopher Nolan', CAST(N'02:28:00' AS Time)) 
INSERT INTO Movies VALUES ('Forrest Gump', N'Robert Zemeckis', CAST(N'02:22:00' AS Time))
INSERT INTO Movies VALUES ('The Matrix', N'Lana Wachowski', CAST(N'02:16:00' AS Time)) 
INSERT INTO Movies VALUES ('Goodfellas', N'Martin Scorsese', CAST(N'02:26:00' AS Time))
INSERT INTO Movies VALUES ('Se7en', N'David Fincher', CAST(N'02:07:00' AS Time)) 
INSERT INTO Movies VALUES ('Interstellar', N'Christopher Nolan', CAST(N'02:49:00' AS Time)) 
INSERT INTO Movies VALUES ('The Silence of the Lambs', N'Jonathan Demme', CAST(N'01:58:00' AS Time)) 
INSERT INTO Movies VALUES ('The Green Mile', N'Frank Darabont', CAST(N'03:09:00' AS Time)) 
INSERT INTO Movies VALUES ('Gladiator', N'Ridley Scott', CAST(N'02:35:00' AS Time)) 
INSERT INTO Movies VALUES ('The Prestige', N'Christopher Nolan', CAST(N'02:10:00' AS Time)) 
INSERT INTO Movies VALUES ('Memento', N'Christopher Nolan', CAST(N'01:53:00' AS Time)) 
INSERT INTO Movies VALUES ('The Departed', N'Martin Scorsese', CAST(N'02:31:00' AS Time)) 
INSERT INTO Movies VALUES ('Whiplash', N'Damien Chazelle', CAST(N'01:47:00' AS Time))
INSERT INTO Movies VALUES ('Django Unchained', N'Quentin Tarantino', CAST(N'02:45:00' AS Time))

INSERT INTO HelpTickets (UserID,Header,Content) VALUES (5267,'help','kofta gedan')