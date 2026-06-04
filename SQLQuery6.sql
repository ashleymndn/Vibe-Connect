CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerID
    @CustomerID INT
AS
BEGIN
    SELECT *
    FROM tblCustomer
    WHERE CustomerID = @CustomerID;
END

EXEC sproc_tblCustomer_FilterByCustomerID 1;
sp_help tblCustomer

SELECT name
FROM sys.procedures
ORDER BY name; 

CREATE PROCEDURE sproc_tblCustomer_SelectAll
AS
SELECT *
FROM tblCustomer

CREATE PROCEDURE sproc_tblCustomer_Insert
    @CustomerName varchar(50),
    @CustomerEmail varchar(200),
    @CustomerPhone varchar(40),
    @CustomerAddress varchar(300),
    @CustomerPassword varchar(255),
    @CustomeDateCreated date,
    @CustomerIsActive bit
AS
BEGIN
    INSERT INTO tblCustomer
    (
        CustomerName,
        CustomerEmail,
        CustomerPhone,
        CustomerAddress,
        CustomerPassword,
        CustomeDateCreated,
        CustomerIsActive
    )
    VALUES
    (
        @CustomerName,
        @CustomerEmail,
        @CustomerPhone,
        @CustomerAddress,
        @CustomerPassword,
        @CustomeDateCreated,
        @CustomerIsActive
    )

    RETURN @@IDENTITY
END

CREATE PROCEDURE sproc_tblCustomer_Update
    @CustomerID INT,
    @CustomerName VARCHAR(50),
    @CustomerEmail VARCHAR(200),
    @CustomerPhone VARCHAR(40),
    @CustomerAddress VARCHAR(300),
    @CustomerPassword VARCHAR(255),
    @CustomeDateCreated DATE,
    @CustomerIsActive BIT
AS
BEGIN
    UPDATE tblCustomer
    SET
        CustomerName = @CustomerName,
        CustomerEmail = @CustomerEmail,
        CustomerPhone = @CustomerPhone,
        CustomerAddress = @CustomerAddress,
        CustomerPassword = @CustomerPassword,
        CustomeDateCreated = @CustomeDateCreated,
        CustomerIsActive = @CustomerIsActive
    WHERE CustomerID = @CustomerID
END

EXEC sp_helptext 'sproc_tblCustomer_Update'

CREATE PROCEDURE sproc_tblCustomer_Delete
    @CustomerID INT
AS
BEGIN
    DELETE FROM tblCustomer
    WHERE CustomerID = @CustomerID
END