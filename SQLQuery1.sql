INSERT INTO tblStaff
(
    StfName,
    StfEmail,
    StfRole,
    StfSalary,
    StfDateJoined,
    StfIsActive
)
VALUES
(
    'Test Staff',
    'teststaff@email.com',
    'Manager',
    25000,
    '2024-01-01',
    1
);
EXEC sproc_tblStaff_FilterByStfID @StfID = 1