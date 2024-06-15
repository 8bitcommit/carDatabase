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



-- Insert more sample cars into the Vehicle table
INSERT INTO Vehicle (VIN, LicensePlate, Kilometers, Make, Model, Colour, vType)
VALUES 

-- Sports Cars
('1FA6P8TH0J5132526', 'MUSTNG1', 800, 'Ford', 'Mustang', 'Pink', 'Sports'),
('1FA6P8TH0J5132527', 'MUSTNG2', 1500, 'Ford', 'Mustang', 'Blue', 'Sports'),
('1FA6P8TH0J5132528', 'MUSTNG3', 2200, 'Ford', 'Mustang', 'Red', 'Sports'),
('YV1MS382X82152219', '8YVMS82', 3000, 'Volvo', 'S60', 'Red', 'Sports'),
('YV1MS382X82152220', '8YVMS83', 4500, 'Volvo', 'S60', 'White', 'Sports'),
('YV1MS382X82152221', '8YVMS84', 6000, 'Volvo', 'S60', 'Black', 'Sports'),
('JHMCM82633C045678', '8JHM826', 8000, 'Honda', 'Accord', 'Silver', 'Sports'),
('JHMCM82633C045679', '8JHM827', 9000, 'Honda', 'Accord', 'Black', 'Sports'),
('JHMCM82633C045680', '8JHM828', 10000, 'Honda', 'Accord', 'White', 'Sports'),
('1HGCM82633A004589', 'C1VICRX', 12000, 'Honda', 'Civic', 'Red', 'Sports'),

-- Electric Cars
('5YJ3E1EA8LF173458', 'TE5LA3X', 500, 'Tesla', 'Model 3', 'Matte Black', 'Electric'),
('5YJ3E1EA8LF173459', 'TE5LA3Y', 1000, 'Tesla', 'Model 3', 'Blue', 'Electric'),
('5YJ3E1EA8LF173460', 'TE5LA3Z', 1500, 'Tesla', 'Model 3', 'Silver', 'Electric'),
('1N4BZ0CP5JC305067', 'NISSN1X', 5000, 'Nissan', 'Leaf', 'White', 'Electric'),
('1N4BZ0CP5JC305068', 'NISSN1Y', 6000, 'Nissan', 'Leaf', 'Blue', 'Electric'),
('1N4BZ0CP5JC305069', 'NISSN1Z', 7000, 'Nissan', 'Leaf', 'Black', 'Electric'),
('WAUHGAFC6DN048573', 'AUD1A6X', 8000, 'Audi', 'A6', 'Black', 'Electric'),
('WAUHGAFC6DN048574', 'AUD1A6Y', 9000, 'Audi', 'A6', 'Gray', 'Electric'),
('WAUHGAFC6DN048575', 'AUD1A6Z', 10000, 'Audi', 'A6', 'Silver', 'Electric'),
('1HGCM82633A004590', 'C1VICRY', 11000, 'Honda', 'Civic', 'Blue', 'Electric'),

-- Sedans
('WBA3A5C50DF595169', 'B328BMW', 20000, 'BMW', '328i', 'Blue', 'Sedan'),
('WBA3A5C50DF595170', 'B328BMX', 25000, 'BMW', '328i', 'White', 'Sedan'),
('WBA3A5C50DF595171', 'B328BMY', 30000, 'BMW', '328i', 'Black', 'Sedan'),
('JHMCM82633C045681', '8JHM829', 32000, 'Honda', 'Accord', 'Red', 'Sedan'),
('JHMCM82633C045682', '8JHM830', 33000, 'Honda', 'Accord', 'Blue', 'Sedan'),
('JHMCM82633C045683', '8JHM831', 34000, 'Honda', 'Accord', 'White', 'Sedan'),
('WAUHGAFC6DN048576', 'AUD1A6W', 35000, 'Audi', 'A6', 'Black', 'Sedan'),
('WAUHGAFC6DN048577', 'AUD1A6U', 36000, 'Audi', 'A6', 'Gray', 'Sedan'),
('WAUHGAFC6DN048578', 'AUD1A6V', 37000, 'Audi', 'A6', 'Silver', 'Sedan'),
('1HGCM82633A004591', 'C1VICRZ', 38000, 'Honda', 'Civic', 'White', 'Sedan'),

-- SUVs
('1GNEK13ZX3R298540', 'GRNTHOE', 45000, 'Chevrolet', 'Tahoe', 'Green', 'SUV'),
('1GNEK13ZX3R298541', 'GRNTHOX', 48000, 'Chevrolet', 'Tahoe', 'Silver', 'SUV'),
('1GNEK13ZX3R298542', 'GRNTHOY', 51000, 'Chevrolet', 'Tahoe', 'Red', 'SUV'),
('1GNEK13ZX3R298543', 'GRNTHOZ', 53000, 'Chevrolet', 'Tahoe', 'Blue', 'SUV'),
('1GNEK13ZX3R298544', 'GRNTHOA', 55000, 'Chevrolet', 'Tahoe', 'Black', 'SUV'),
('1GNEK13ZX3R298545', 'GRNTHOB', 57000, 'Chevrolet', 'Tahoe', 'Gray', 'SUV'),
('1GNEK13ZX3R298546', 'GRNTHOC', 59000, 'Chevrolet', 'Tahoe', 'White', 'SUV'),
('1GNEK13ZX3R298547', 'GRNTHOD', 61000, 'Chevrolet', 'Tahoe', 'Brown', 'SUV'),
('1GNEK13ZX3R298548', 'GRNTHOE', 63000, 'Chevrolet', 'Tahoe', 'Orange', 'SUV'),
('1GNEK13ZX3R298549', 'GRNTHOF', 65000, 'Chevrolet', 'Tahoe', 'Purple', 'SUV'),

-- Trucks
('1FTFW1EFXEKF51234', 'F1FT512', 35000, 'Ford', 'F-150', 'Black', 'Truck'),
('1FTFW1EFXEKF51235', 'F1FT513', 40000, 'Ford', 'F-150', 'White', 'Truck'),
('1FTFW1EFXEKF51236', 'F1FT514', 30000, 'Ford', 'F-150', 'Red', 'Truck'),
('1FTFW1EFXEKF51237', 'F1FT515', 45000, 'Ford', 'F-150', 'Blue', 'Truck'),
('1FTFW1EFXEKF51238', 'F1FT516', 50000, 'Ford', 'F-150', 'Green', 'Truck'),
('1FTFW1EFXEKF51239', 'F1FT517', 55000, 'Ford', 'F-150', 'Gray', 'Truck'),
('1FTFW1EFXEKF51240', 'F1FT518', 60000, 'Ford', 'F-150', 'Silver', 'Truck'),
('1FTFW1EFXEKF51241', 'F1FT519', 65000, 'Ford', 'F-150', 'Brown', 'Truck'),
('1FTFW1EFXEKF51242', 'F1FT520', 70000, 'Ford', 'F-150', 'Orange', 'Truck'),
('1FTFW1EFXEKF51243', 'F1FT521', 75000, 'Ford', 'F-150', 'Purple', 'Truck');





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


