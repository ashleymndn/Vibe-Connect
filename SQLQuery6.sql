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
