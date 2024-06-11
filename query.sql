

SELECT * from Rental;
SELECT * from Vehicle;
SELECT * from VehicleType;
SELECT * from Customer;
SELECT * from Employee;
SELECT * from Branch;


--1
SELECT vehicle.VType from Rental, Vehicle
where DateRented like '%-03-%' and rental.VIN=Vehicle.VIN
group by vehicle.VType
having count(*)>=1;

--2

select  t1.Make,t1.Model,max(num_rentals) as num
from (SELECT distinct rental.ReturnedTo ,count(rental.ReturnedTo) as num_rentals,vehicle.Make,Vehicle.Model from Rental, Vehicle
where rental.VIN=Vehicle.VIN and Vehicle.Kilometers<20000
group by rental.ReturnedTo,vehicle.Make,Vehicle.Model)as t1
group by t1.Make,t1.Model;

--3
