SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'tblCustomer';

ALTER TABLE tblCustomer
ADD CustomerEmail NVARCHAR(100);

ALTER TABLE tblCustomer
ADD CustomerPhone NVARCHAR(20);

INSERT INTO tblCustomer
(
    CustomerID,
    CustomerName,
    CustomerEmail,
    CustomerPassword,
    CustomerPhone,
    CustomerAddress,
    CustomeDateCreated,
    CustomerIsActive
)
VALUES
(
    1,
    'Hajra',
    'hajra@email.com',
    'Password123!',
    '03001234567',
    'Faisalabad',
    GETDATE(),
    1
);

SELECT * FROM tblCustomer;
