SET IDENTITY_INSERT tblStaff ON;

IF EXISTS (SELECT * FROM tblStaff WHERE StfID = 1)
BEGIN
    UPDATE tblStaff
    SET StfName = 'Test Staff',
        StfEmail = 'teststaff@email.com',
        StfRole = 'Manager',
        StfSalary = 25000,
        StfDateJoined = '2024-01-01',
        StfIsActive = 1
    WHERE StfID = 1;
END
ELSE
BEGIN
    INSERT INTO tblStaff
    (StfID, StfName, StfEmail, StfRole, StfSalary, StfDateJoined, StfIsActive)
    VALUES
    (1, 'Test Staff', 'teststaff@email.com', 'Manager', 25000, '2024-01-01', 1);
END

SET IDENTITY_INSERT tblStaff OFF;