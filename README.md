Query tạo bảng "Product":

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DemoDB')
BEGIN
    CREATE DATABASE DemoDB;
END
GO

USE DemoDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Product' and xtype='U')
BEGIN
    CREATE TABLE Product (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        Price DECIMAL(18, 2) NOT NULL,
        Stock INT NOT NULL
    );
END
GO

-- (Optional) Insert some sample data
INSERT INTO Product (Name, Price, Stock) VALUES
('Laptop XYZ', 25000000.00, 10),
('Mouse ABC', 500000.00, 50),
('Keyboard GHI', 1200000.00, 30);
GO
