CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerID
    @CustomerID INT
AS
BEGIN
    SELECT *
    FROM tblCustomer
    WHERE CustomerID = @CustomerID;
END

EXEC sproc_tblCustomer_FilterByCustomerID 1;