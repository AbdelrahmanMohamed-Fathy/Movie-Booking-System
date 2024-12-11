----------------------------------------Database Creation----------------------------------------
CREATE DATABASE MovieBooking_system;
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
CREATE FUNCTION dbo.CheckOldShows (@ShowID INTEGER)
RETURNS BIT
AS
BEGIN
    DECLARE @isOld BIT
    IF EXISTS(SELECT CAST(ShowDate AS DATETIME) + CAST(EndTime AS DATETIME) AS CombinedDate
              FROM Shows
              WHERE CombinedDate < NOW() AND ShowID = @ShowID)
        SET @IsOld = 1
    ELSE
        SET @IsOld = 0
    RETURN @isOld;
END;
GO
---------------------------------------------Tables----------------------------------------------
CREATE TABLE Accounts (
    UserID			INTEGER 		NOT NULL IDENTITY(1,1),
    Fname			VARCHAR(20)		NOT NULL,
    Lname			VARCHAR(20)		NOT NULL,
    Email			VARCHAR(50)		NOT NULL UNIQUE,
    Pass			VARCHAR(64)		NOT NULL,
    PhoneNumber		INTEGER,
    Authority		VARCHAR(10)		NOT NULL CHECK (Authority IN ('Admin', 'Employee', 'Client')),
	PRIMARY KEY		(UserID)
);
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
Old                 AS dbo.CheckOldShows(ShowID),
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
FOREIGN KEY			(CinemaID)      REFERENCES Cinema,
PRIMARY KEY			(CinemaID,SeatNumber)
);
GO
---------------------------------------
CREATE TABLE Bookings (
BookingID			INTEGER			NOT NULL IDENTITY(1,1),
UserID              INTEGER         NOT NULL,
SeatID              INTEGER         NOT NULL,
ShowID              INTEGER         NOT NULL,
Price               DECIMAL         NOT NULL,
PaymentMethod		VARCHAR(20)		NOT NULL CHECK (Paymentmethod IN ('Cash', 'Credit')),
PRIMARY KEY			(BookingID),
FOREIGN KEY         (UserID)        REFERENCES Users,
FOREIGN KEY         (SeatID)        REFERENCES Seats,
FOREIGN KEY         (ShowID)        REFERENCES Shows
);
---------------------------------------
CREATE TABLE Orders (
OrderID				INTEGER			NOT NULL IDENTITY(1,1),
FoodID				INTEGER			NOT NULL,
OrderCount			INTEGER			NOT NULL,
Fulfilled           BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(OrderID,FoodID),
FOREIGN KEY			(FoodID)        REFERENCES Fooditems
);
---------------------------------------
CREATE TABLE HelpTickets (
HelpTicketID		INTEGER			NOT NULL IDENTITY(1,1),
UserID              INTEGER         NOT NULL,
Content				VARCHAR(500)	NOT NULL,
Header				VARCHAR(50)		NOT NULL,
Closed              BIT             NOT NULL DEFAULT 0,
PRIMARY KEY			(HelpTicketID,UserID),
FOREIGN KEY         (UserID)        REFERENCES Users
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
FOREIGN KEY         (UserID)        REFERENCES Users
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
FOREIGN KEY         (UserID)        REFERENCES Users
);
---------------------------------------