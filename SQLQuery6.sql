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
