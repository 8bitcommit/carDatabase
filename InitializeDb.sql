USE Project_group3;

-- Drop foreign key constraints
ALTER TABLE Vehicle DROP CONSTRAINT IF EXISTS FK_Vehicle_vType;
ALTER TABLE Rental DROP CONSTRAINT IF EXISTS FK_Rental_VIN;
ALTER TABLE Rental DROP CONSTRAINT IF EXISTS FK_Rental_RentedFrom;
ALTER TABLE Rental DROP CONSTRAINT IF EXISTS FK_Rental_ReturnedTo;
GO

-- Drop tables
DROP TABLE IF EXISTS Rental;
DROP TABLE IF EXISTS Vehicle;
DROP TABLE IF EXISTS VehicleType;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Branch;
GO

-- Create tables
CREATE TABLE Branch(
    BranchID int IDENTITY(5000, 1) PRIMARY KEY,
    BranchName nchar(40) NULL,
    PhoneNumber nchar(12) NULL,
    UnitNum int NULL,
    Street nchar(10) NULL,
    City nchar(10) NULL,
    Province nchar(10) NULL,
    PostalCode nchar(10) NULL
);

CREATE TABLE Employee(
    EmployeeID int IDENTITY(10000, 1) PRIMARY KEY,
    FirstName nchar(20) NULL,
    LastName nchar(20) NULL, 
    Gender nchar(2) NULL, 
    DOB date NULL,
    Email nchar(40) NULL,
    UnitNum int NULL,
    Street nchar(10) NULL,
    City nchar(10) NULL,
    Province nchar(10) NULL,
    PostalCode nchar(10) NULL
);

CREATE TABLE Customer(
    CustomerID int IDENTITY(100, 1) PRIMARY KEY,
    FirstName nchar(20) NULL,
    LastName nchar(20) NULL, 
    Gender nchar(2) NULL, 
    DOB date NULL,
    Email nchar(40) NULL,
    UnitNum int NULL,
    Street nchar(10) NULL,
    City nchar(10) NULL,
    Province nchar(10) NULL,
    PostalCode nchar(10) NULL
);

CREATE TABLE VehicleType(
    vType nchar(15) PRIMARY KEY,
    CostPerDay numeric(6, 2) NULL,
    CostPerWeek numeric(6, 2) NULL,
    CostPerMonth numeric(6, 2) NULL
);

CREATE TABLE Vehicle(
    VIN nchar(17) PRIMARY KEY,
    LicensePlate nchar(10) NULL,
	Kilometers numeric(7, 0) CHECK (Kilometers >= 0) NOT NULL,
    Make nchar(20) NULL,
    Model nchar(20) NULL,
    Colour nchar(20) NULL,
    vType nchar(15) NULL
);

CREATE TABLE Rental(
    TransactionID int IDENTITY(1000, 1) PRIMARY KEY,
    DateRented date NULL,
    DateReturned date NULL,
    TotalPrice numeric(6, 2) NULL,
    VIN nchar(17) NULL,
    RentedFrom int NULL,
    ReturnedTo int NULL
);

-- Add foreign key constraints
ALTER TABLE Vehicle ADD CONSTRAINT FK_Vehicle_vType FOREIGN KEY (vType) REFERENCES VehicleType(vType);
ALTER TABLE Rental ADD CONSTRAINT FK_Rental_VIN FOREIGN KEY (VIN) REFERENCES Vehicle(VIN);
ALTER TABLE Rental ADD CONSTRAINT FK_Rental_RentedFrom FOREIGN KEY (RentedFrom) REFERENCES Branch(BranchID);
ALTER TABLE Rental ADD CONSTRAINT FK_Rental_ReturnedTo FOREIGN KEY (ReturnedTo) REFERENCES Branch(BranchID);


-- Insert refined vehicle types into the VehicleType table
INSERT INTO VehicleType (vType, CostPerDay, CostPerWeek, CostPerMonth)
VALUES 
('Sedan', 50.00, 300.00, 1000.00),
('SUV', 80.00, 480.00, 1600.00),
('Truck', 100.00, 600.00, 2000.00),
('Sports', 120.00, 720.00, 2400.00),
('Electric', 150.00, 900.00, 3000.00);

-- Insert sample cars into the Vehicle table
INSERT INTO Vehicle (VIN, LicensePlate, Kilometers, Make, Model, Colour, vType)
VALUES 
('1FA6P8TH0J5132526', 'MUSTNG1', 15000, 'Ford', 'Mustang', 'Pink', 'Sports'),
('YV1MS382X82152219', '8YVMS82', 30000, 'Volvo', 'S60', 'Red', 'Sedan'),
('5YJ3E1EA8LF173458', 'TE5LA3X', 5000, 'Tesla', 'Model 3', 'Matte Black', 'Electric'),
('WBA3A5C50DF595169', 'B328BMW', 20000, 'BMW', '328i', 'Blue', 'Sedan'),
('1GNEK13ZX3R298540', 'GRNTHOE', 45000, 'Chevrolet', 'Tahoe', 'Green', 'SUV'),
('1FTFW1EFXEKF51234', 'F1FT512', 35000, 'Ford', 'F-150', 'Black', 'Truck'),
('JHMCM82633C045678', '8JHM826', 22000, 'Honda', 'Accord', 'Silver', 'Sedan'),
('1N4BZ0CP5JC305067', 'NISSN1X', 10000, 'Nissan', 'Leaf', 'White', 'Electric'),
('WAUHGAFC6DN048573', 'AUD1A6X', 18000, 'Audi', 'A6', 'Black', 'Sedan'),
('1HGCM82633A004589', 'C1VICRX', 27000, 'Honda', 'Civic', 'Red', 'Sedan');


INSERT INTO Branch(BranchName, PhoneNumber,UnitNum,Street, City,Province, PostalCode)
VALUES
('Whyte Avenue','780-555-5000',12,'Whyte Ave','Edmonton','AB','T5T1T4'),
('Jasper Avenue','780-555-5001',12,'Jasper Ave','Edmonton','AB','T5T1T5'),
('North Side','780-555-5002',12,'137 Ave','Edmonton','AB','T5T1T6'),
('South Side','780-555-5003',12,'34 Ave','Edmonton','AB','T5T1T7'),
('YEG Edmonton Int''l Airport','780-555-5004',12,'Airport Rd','Nisku','AB','T5T1T8');

INSERT INTO Rental(DateRented,DateReturned,TotalPrice, VIN,RentedFrom,ReturnedTo)
VALUES
('2024/05/20','2024/05/21',120,'1FA6P8TH0J5132526',5000,5000),
('2024/06/20','2024/06/27',720,'1FA6P8TH0J5132526',5000,5001),
('2024/03/5','2024/03/15',1080,'1FA6P8TH0J5132526',5002,5000);


