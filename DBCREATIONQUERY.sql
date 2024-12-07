CREATE DATABASE MovieBooking_system;
GO
CREATE TABLE Accounts (
    Fname			VARCHAR(20)		NOT NULL,
    Lname			VARCHAR(20)		NOT NULL,
    ID				INTEGER			NOT NULL,
    Email			VARCHAR(50)		NOT NULL,
    Pass			VARCHAR(64)		NOT NULL,
    PhoneNumber		INTEGER,
    Authority		VARCHAR(10)		NOT NULL CHECK (Authority IN ('Admin', 'Employee', 'Client')),
	PRIMARY KEY		(ID)
);
----------------------------------------
CREATE TABLE Movie (
MovieName			VARCHAR(50)		NOT NULL,
MID					INTEGER			NOT NULL,
Director			VARCHAR(20)		NOT NULL,
Runtime				FLOAT			NOT NULL,
PRIMARY KEY			(MID),
);
---------------------------------------
CREATE TABLE Booking (
BID					INTEGER			NOT NULL,	
PaymentMethod		VARCHAR(20)		NOT NULL CHECK (Paymentmethod IN ('Cash', 'Credit')),
PRIMARY KEY			(BID)
);
---------------------------------------
CREATE TABLE Fooditem (
FoodName			VARCHAR(20)		NOT NULL,
FID					INTEGER			NOT NULL,
FoodQty				INTEGER			NOT NULL,
Price				INTEGER			NOT NULL,
FoodDesc			VARCHAR(200)	NOT NULL,
PRIMARY KEY			(FID)
);
---------------------------------------
CREATE TABLE Cinema (
CinemaType			VARCHAR(10)		NOT NULL,
CID					INTEGER			NOT NULL,
PRIMARY KEY			(CID)
);
---------------------------------------
CREATE TABLE Orders (
FoodID				INTEGER			NOT NULL,
OID					INTEGER			NOT NULL,
OrderCount			INTEGER			NOT NULL,
PRIMARY KEY			(OID,FoodID),
FOREIGN KEY			(FoodID)		REFERENCES Fooditem
);
---------------------------------------
CREATE TABLE Show (
ShowID				INTEGER			NOT NULL,
ShowDate			DATE			NOT NULL,
StartTime			TIME			NOT NULL,
PRIMARY KEY			(ShowID)
);
---------------------------------------
CREATE TABLE HelpTicket (
HelpID				INTEGER			NOT NULL,
Content				VARCHAR(500)	NOT NULL,
Header				VARCHAR(50)		NOT NULL,
PRIMARY KEY			(HelpID)
);
---------------------------------------
CREATE TABLE Review (
ReviewID			INTEGER			NOT NULL,
Rating				INTEGER			NOT NULL,
FoodReview			VARCHAR(100)	NOT NULL,
MovieReview			VARCHAR(100)	NOT NULL,
PRIMARY KEY			(ReviewID)
);
---------------------------------------
CREATE TABLE Seat (
CinemaID			INTEGER			NOT NULL,
Price				INTEGER			NOT NULL,
SeatNumber			INTEGER			NOT NULL,
FOREIGN KEY			(CinemaID)		REFERENCES Cinema,
PRIMARY KEY			(CinemaID,SeatNumber)
);