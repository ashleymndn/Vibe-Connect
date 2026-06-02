CREATE TABLE tblCustomer
(
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100),
    CustomerEmail NVARCHAR(100),
    CustomerPassword NVARCHAR(100),
    CustomerPhone NVARCHAR(20),
    CustomerAddress NVARCHAR(200),
    CustomerDateCreated DATE,
    CustomerIsActive BIT
);