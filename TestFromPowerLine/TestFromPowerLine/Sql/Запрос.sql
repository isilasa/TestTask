CREATE DATABASE IF NOT EXISTS Orders;

USE Orders;

CREATE TABLE Customers
(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(20) NOT NULL
);
 
CREATE TABLE Orders
(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CustomerId INT,
    FOREIGN KEY (CustomerId)  REFERENCES Customers (Id)
);

INSERT INTO Customers (NAME) 
VALUES
('Max'),
('Ilya'),
('Alex'),
('Mark');

INSERT INTO Orders (CustomerId)
VALUES 
(1),
(2),
(3),
(3),
(2),
(2),
(1);

SELECT Name
FROM Customers
WHERE NOT EXISTS (
SELECT Customers.Id
FROM Orders
WHERE Customers.id = Orders.CustomerId);
