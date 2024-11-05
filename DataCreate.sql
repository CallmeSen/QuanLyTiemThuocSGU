CREATE DATABASE quanlycuahangthuoc;
GO
USE quanlycuahangthuoc;
GO



CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(255) NOT NULL,
	Gender CHAR(1),
	Role VARCHAR(50),
    Phone VARCHAR(15),
    Email VARCHAR(255),
    Salary DECIMAL(10,2),
    HireDate DATE
);
GO

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role INT,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
GO

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(255) NOT NULL,
    Phone VARCHAR(15),
    Email VARCHAR(255),
    Address VARCHAR(255)
);
GO

CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName VARCHAR(255) NOT NULL,
    Phone VARCHAR(15),
    Email VARCHAR(255),
    Address VARCHAR(255)
);
GO

CREATE TABLE ProductCategory (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(255) NOT NULL
);
GO

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(255) NOT NULL,
    CategoryID INT,
    SupplierID INT,
    Price DECIMAL(10,2) NOT NULL,
    QuantityInStock INT NOT NULL,
    ExpirationDate DATE,
    FOREIGN KEY (CategoryID) REFERENCES ProductCategory(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
GO

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    EmployeeID INT,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
GO

CREATE TABLE OrderInfo (
    OrderInfoID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    Quantity INT NOT NULL,
    PriceAtPurchase DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO

CREATE TABLE Shipments (
    ShipmentID INT PRIMARY KEY IDENTITY(1,1),
    SupplierID INT,
    ProductID INT,
    Quantity INT NOT NULL,
    ShipmentDate DATE NOT NULL,
    ArrivalDate DATE NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO

-- Thêm dữ liệu vào các bảng

-- Chèn dữ liệu giả cho bảng Suppliers
INSERT INTO Suppliers (SupplierName, Phone, Email, Address)
VALUES 
('MedSupply Co.', '0983764582', 'contact@medsupply.com', '45 Nguyen Trai, Ha Noi'),
('HealthFirst Corp.', '0975123489', 'support@healthfirst.com', '78 Le Loi, Ho Chi Minh City'),
('PharmaLogistics', '0968254791', 'info@pharmalogistics.com', '102 Phan Boi Chau, Da Nang'),
('LifeCare Distributors', '0912394875', 'sales@lifecare.com', '20 Truong Chinh, Can Tho');
GO

-- Chèn dữ liệu giả cho bảng ProductCategory
INSERT INTO ProductCategory (CategoryName)
VALUES 
('Prescription Drugs'),
('Over-the-Counter (OTC) Drugs'),
('Health Supplements'),
('Personal Care Products'),
('Medical Equipment');
GO

-- Chèn dữ liệu giả cho bảng Products
INSERT INTO Products (ProductName, CategoryID, SupplierID, Price, QuantityInStock, ExpirationDate)
VALUES 
('Paracetamol 500mg', 2, 1, 3500, 500, '2025-04-15'),
('Multivitamin Capsules', 3, 2, 150000, 200, '2024-08-30'),
('Blood Pressure Monitor', 5, 4, 1200000, 15, NULL),
('Face Mask (50-pack)', 4, 3, 50000, 300, NULL),
('Amoxicillin 250mg', 1, 1, 4000, 150, '2023-12-01'),
('Fish Oil 1000mg', 3, 2, 130000, 120, '2025-07-20');
GO

-- Chèn dữ liệu giả cho bảng Employees
INSERT INTO Employees (FullName, Gender, Role, Phone, Email, Salary, HireDate)
VALUES 
('Tran Quang Huy', 'M', 'Staff', '0901234567', 'huytq@pharmacy.com', 8500000, '2021-05-01'),
('Nguyen Thi Lan', 'F', 'Admin', '0902345678', 'lannn@pharmacy.com', 9200000, '2020-11-15'),
('Le Van Khoa', 'M', 'Staff', '0903456789', 'khoalv@pharmacy.com', 7500000, '2022-02-10'),
('Pham Minh Anh', 'F', 'Admin', '0904567890', 'anhtp@pharmacy.com', 6800000, '2023-03-20');
GO

-- Chèn dữ liệu giả cho bảng Accounts
INSERT INTO Accounts (Username, Password, Role, EmployeeID)
VALUES 
('staff', '123456', 0, 1),
('admin', '123456', 1, 2),
('khoa_le', 'khoa_password789', 0, 3),
('minh_anh', 'anh_password321', 1, 4);
GO

-- Chèn dữ liệu giả cho bảng Customers
INSERT INTO Customers (FullName, Phone, Email, Address)
VALUES 
('Pham Hoang Nam', '0986543210', 'namph@gmail.com', '21 Ton Duc Thang, Ha Noi'),
('Nguyen Minh Chau', '0978654321', 'chaunm@hotmail.com', '32 Dien Bien Phu, Da Nang'),
('Le Thi Hoa', '0967451234', 'hoale@yahoo.com', '90 Ly Thuong Kiet, Ho Chi Minh City'),
('Vuong Quoc Bao', '0945123789', 'bao.vuong@zmail.com', '15 Hang Bai, Ha Noi');
GO

-- Chèn dữ liệu giả cho bảng Orders
INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, TotalAmount)
VALUES 
(1, 1, '2024-09-28', 173500),
(2, 2, '2024-10-12', 560000),
(3, 3, '2024-10-15', 90000),
(4, 4, '2024-10-22', 430000);
GO

-- Chèn dữ liệu giả cho bảng OrderInfo
INSERT INTO OrderInfo (OrderID, ProductID, Quantity, PriceAtPurchase)
VALUES 
(1, 1, 10, 3500),
(1, 2, 1, 150000),
(2, 3, 1, 1200000),
(3, 4, 2, 50000),
(4, 6, 3, 130000),
(4, 5, 5, 4000);
GO

-- Chèn dữ liệu giả cho bảng Shipments
INSERT INTO Shipments (SupplierID, ProductID, Quantity, ShipmentDate, ArrivalDate)
VALUES 
(1, 1, 1000, '2024-08-25', '2024-08-30'),
(2, 2, 300, '2024-07-01', '2024-07-05'),
(4, 3, 25, '2024-09-10', '2024-09-15'),
(3, 4, 500, '2024-09-20', '2024-09-25'),
(2, 5, 200, '2024-10-05', '2024-10-10');
GO

-- tạo stored procedure cho login
CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo. Accounts WHERE Username = @username AND Password = @password
END
GO

-- Stored procedure to retrieve employee details by ID
CREATE PROC USP_GetEmployeeByID
    @EmployeeID INT
AS
BEGIN
    SELECT * FROM Employees WHERE EmployeeID = @EmployeeID
END
GO

-- Stored procedure to add a new employee
CREATE PROC USP_AddEmployee
    @FullName NVARCHAR(255),
    @Gender CHAR(1),
	@Role VARCHAR(50),
    @Phone VARCHAR(15),
    @Email VARCHAR(255),
    @Salary DECIMAL(10,2),
    @HireDate DATE
AS
BEGIN
    INSERT INTO Employees (FullName, Gender, Phone, Email, Salary, HireDate)
    VALUES (@FullName, @Gender, @Phone, @Email, @Salary, @HireDate)
END
GO

-- Stored procedure to update an existing employee's details
CREATE PROC USP_UpdateEmployee
    @EmployeeID INT,
    @FullName NVARCHAR(255),
    @Gender CHAR(1),
	@Role VARCHAR(50),
    @Phone VARCHAR(15),
    @Email VARCHAR(255),
    @Salary DECIMAL(10,2),
    @HireDate DATE
AS
BEGIN
    UPDATE Employees
    SET FullName = @FullName,
        Gender = @Gender,
		Role = @Role,
        Phone = @Phone,
        Email = @Email,
        Salary = @Salary,
        HireDate = @HireDate
    WHERE EmployeeID = @EmployeeID
END
GO

-- Stored procedure to delete an employee by ID
CREATE PROC USP_DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employees WHERE EmployeeID = @EmployeeID
END
GO

-- Stored procedure to retrieve all employees with a specific role
CREATE PROC USP_GetEmployeesByRole
    @Role VARCHAR(50) -- Adjust size to match the Role column size in Employees
AS
BEGIN
    SELECT e.EmployeeID, e.FullName, e.Gender, e.Role, e.Phone, e.Email, e.Salary, e.HireDate
    FROM Employees e
    WHERE e.Role = @Role
END
GO

CREATE PROCEDURE USP_CreateOrder
    @CustomerID INT,
    @EmployeeID INT,
    @OrderDate DATETIME,
    @TotalAmount DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, TotalAmount)
    VALUES (@CustomerID, @EmployeeID, @OrderDate, @TotalAmount);

    -- Return the newly created Order ID
    SELECT SCOPE_IDENTITY() AS OrderID;
END
GO

CREATE PROCEDURE USP_GetOrderByID
    @OrderID INT
AS
BEGIN
    SELECT * FROM Orders WHERE OrderID = @OrderID;
END
GO

CREATE PROCEDURE USP_UpdateOrder
    @OrderID INT,
    @CustomerID INT,
    @EmployeeID INT,
    @OrderDate DATETIME,
    @TotalAmount DECIMAL(10, 2)
AS
BEGIN
    UPDATE Orders
    SET CustomerID = @CustomerID,
        EmployeeID = @EmployeeID,
        OrderDate = @OrderDate,
        TotalAmount = @TotalAmount
    WHERE OrderID = @OrderID;
END
GO

CREATE PROCEDURE USP_DeleteOrder
    @OrderID INT
AS
BEGIN
    DELETE FROM Orders WHERE OrderID = @OrderID;
END
GO


CREATE PROCEDURE USP_AddOrderItem
    @OrderID INT,
    @ProductID INT,
    @Quantity INT,
    @PriceAtPurchase DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO OrderInfo (OrderID, ProductID, Quantity, PriceAtPurchase)
    VALUES (@OrderID, @ProductID, @Quantity, @PriceAtPurchase);
END
GO

CREATE PROCEDURE USP_GetOrderItemsByOrderID
    @OrderID INT
AS
BEGIN
    SELECT * FROM OrderInfo WHERE OrderID = @OrderID;
END
GO

CREATE PROCEDURE USP_DeleteOrderItem
    @OrderInfoID INT
AS
BEGIN
    DELETE FROM OrderInfo WHERE OrderInfoID = @OrderInfoID;
END
GO

CREATE PROCEDURE USP_AddCategory
    @CategoryName NVARCHAR(255)
AS
BEGIN
    INSERT INTO ProductCategory (CategoryName)
    VALUES (@CategoryName);
END
GO

CREATE PROCEDURE USP_GetAllCategories
AS
BEGIN
    SELECT * FROM ProductCategory;
END
GO

CREATE PROCEDURE USP_UpdateCategory
    @CategoryID INT,
    @CategoryName NVARCHAR(255)
AS
BEGIN
    UPDATE ProductCategory
    SET CategoryName = @CategoryName
    WHERE CategoryID = @CategoryID;
END
GO

CREATE PROCEDURE USP_DeleteCategory
    @CategoryID INT
AS
BEGIN
    DELETE FROM ProductCategory WHERE CategoryID = @CategoryID;
END
GO

--------------------------------------------------------
