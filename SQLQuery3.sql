CREATE PROCEDURE sproc_tblStaff_Delete
    @StfID INT
AS
BEGIN
    DELETE FROM tblStaff
    WHERE StfID = @StfID
END