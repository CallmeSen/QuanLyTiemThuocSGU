CREATE DATABASE quanlycuahangthuoc;
GO
USE quanlycuahangthuoc;
GO



CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    Gender CHAR(1),
    Role NVARCHAR(50),
    Phone NVARCHAR(15),
    Email NVARCHAR(255),
    Salary DECIMAL(18,2),
    HireDate DATE
);
GO

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role INT,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
GO

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(15),
    Email NVARCHAR(255),
    Address NVARCHAR(255)
);
GO

CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(15),
    Email NVARCHAR(255),
    Address NVARCHAR(255)
);
GO

CREATE TABLE ProductCategory (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL,
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
('Fish Oil 1000mg', 3, 2, 130000, 120, '2025-07-20'),
('Vitamin C 500mg', 3, 2, 90000, 300, '2024-09-15'),
('Disposable Syringe 10ml', 4, 3, 700, 1000, NULL),
('Digital Thermometer', 5, 4, 80000, 50, NULL),
('Ibuprofen 400mg', 2, 1, 3000, 450, '2025-02-10'),
('Glucometer Test Strips (50-pack)', 5, 4, 55000, 80, '2024-11-30'),
('Hand Sanitizer 500ml', 4, 3, 25000, 200, NULL),
('Omeprazole 20mg', 1, 1, 4500, 250, '2024-06-20'),
('Calcium + Vitamin D Tablets', 3, 2, 125000, 180, '2025-01-15'),
('Nebulizer Machine', 5, 4, 1500000, 20, NULL),
('Surgical Gloves (100-pack)', 4, 3, 45000, 600, NULL),
('Metformin 500mg', 1, 1, 2000, 300, '2025-03-10'),
('Probiotic Supplement', 3, 2, 160000, 100, '2024-10-05'),
('Wound Dressing Kit', 4, 3, 35000, 50, NULL),
('Antacid Suspension', 2, 1, 5500, 400, '2023-11-30'),
('Omega-3 500mg', 3, 2, 145000, 200, '2025-05-25'),
('Insulin Syringes', 4, 3, 1200, 750, NULL),
('Blood Glucose Meter', 5, 4, 1250000, 25, NULL),
('Surgical Mask N95', 4, 3, 10000, 500, NULL),
('Iron Supplement', 3, 2, 110000, 150, '2024-12-20'),
('Vitamin D3 1000 IU', 3, 2, 90000, 180, '2025-08-01');
GO

-- Chèn dữ liệu giả cho bảng Employees
INSERT INTO Employees (FullName, Gender, Role, Phone, Email, Salary, HireDate)
VALUES 
(N'Trần Quang Huy', 'M', 'Staff', '0901234567', 'huytq@pharmacy.com', 8500000, '2021-05-01'),
(N'Nguyễn Thị Lan', 'F', 'Admin', '0902345678', 'lannn@pharmacy.com', 9200000, '2020-11-15'),
(N'Lê Văn Khoa', 'M', 'Staff', '0903456789', 'khoalv@pharmacy.com', 7500000, '2022-02-10'),
(N'Phạm Minh Anh', 'F', 'Admin', '0904567890', 'anhtp@pharmacy.com', 6800000, '2023-03-20'),
(N'Phạm Văn Thanh', 'M', N'Admin', '0905671234', 'thanhpv@pharmacy.com', 15000000, '2019-09-10'),
(N'Bùi Thị Mai', 'F', N'Staff', '0906781234', 'maibt@pharmacy.com', 8000000, '2022-01-25'),
(N'Trần Minh Tuấn', 'M', N'Staff', '0907891234', 'tuantm@pharmacy.com', 12000000, '2021-07-15'),
(N'Nguyễn Văn Dương', 'M', N'Staff', '0908901234', 'duongnv@pharmacy.com', 7000000, '2023-06-18');
GO

-- Chèn dữ liệu giả cho bảng Accounts
INSERT INTO Accounts (Username, Password, Role, EmployeeID)
VALUES 
(N'staff', '123456', 0, 1),
(N'admin', '123456', 1, 2),
(N'khoa_le', 'khoa_password789', 0, 3),
(N'minh_anh', 'anh_password321', 1, 4),
(N'thanh_pham', 'thanh_password123', 1, 5),
(N'mai_bui', 'mai_password456', 0, 6),
(N'minh_tuan', 'tuan_password789', 0, 7),
(N'duong_nguyen', 'duong_password321', 0, 8);
GO

-- Chèn dữ liệu giả cho bảng Customers
INSERT INTO Customers (FullName, Phone, Email, Address)
VALUES 
(N'Phạm Hoàng Nam', '0986543210', 'namph@gmail.com', N'21 Tôn Đức Thắng, Hà Nội'),
(N'Nguyễn Minh Châu', '0978654321', 'chaunm@hotmail.com', N'32 Điện Biên Phủ, Đà Nẵng'),
(N'Lê Thị Hoa', '0967451234', 'hoale@yahoo.com', N'90 Lý Thường Kiệt, TP Hồ Chí Minh'),
(N'Vương Quốc Bảo', '0945123789', 'bao.vuong@zmail.com', N'15 Hàng Bài, Hà Nội'),
(N'Trần Thị Bích', '0981234567', 'bich.tran@gmail.com', N'12 Hàng Khay, Hà Nội'),
(N'Hoàng Văn Phúc', '0972345678', 'phuc.hoang@hotmail.com', N'23 Hai Bà Trưng, Hà Nội'),
(N'Nguyễn Thị Hoa', '0963456789', 'hoa.nguyen@yahoo.com', N'45 Lê Lợi, Đà Nẵng'),
(N'Đỗ Thị Mai', '0954567890', '', N'78 Bạch Đằng, TP Hồ Chí Minh'),
(N'Lê Thanh Sơn', '0945678901', '', ''),
(N'Vũ Minh Hằng', '0936789012', '', N'34 Phạm Văn Đồng, TP Hồ Chí Minh'),
(N'Phạm Văn Bảo', '0927890123', 'bao.pham@hotmail.com', ''),
(N'Nguyễn Thị Lan Anh', '0918901234', 'lananh.nguyen@zmail.com', N'56 Nguyễn Trãi, Hà Nội'),
(N'Bùi Thị Mai', '0902345678', '', ''),
(N'Lê Văn Hoàng', '0903456789', '', ''),
(N'Trần Quốc Bảo', '0904567890', '', N'45 Nguyễn Huệ, Đà Nẵng'),
(N'Nguyễn Thanh Phong', '0915678901', '', ''),
(N'Phạm Minh Đức', '0926789012', '', N'12 Lý Tự Trọng, Hà Nội'),
(N'Võ Anh Tuấn', '0937890123', '', '');
GO

-- Chèn dữ liệu giả cho bảng Orders
INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, TotalAmount)
VALUES 
(1, 1, '2024-09-28', 173500),
(2, 2, '2024-10-12', 560000),
(3, 3, '2024-10-15', 90000),
(4, 4, '2024-10-22', 430000),
(1, 1, '2024-11-01', 1230000),
(2, 3, '2024-11-01', 890000),
(3, 6, '2024-11-02', 560000),
(4, 7, '2024-11-02', 1100000),
(5, 8, '2024-11-03', 780000),
(6, 1, '2024-11-03', 430000),
(7, 3, '2024-11-04', 1200000),
(8, 6, '2024-11-04', 900000),
(9, 7, '2024-11-05', 1500000),
(10, 8, '2024-11-05', 1230000),
(11, 1, '2024-11-06', 670000),
(12, 3, '2024-11-06', 980000),
(13, 6, '2024-11-07', 560000),
(14, 7, '2024-11-07', 780000),
(15, 8, '2024-11-08', 430000),
(16, 1, '2024-11-08', 1200000),
(17, 3, '2024-11-09', 150000),
(18, 6, '2024-11-09', 1230000),
(1, 7, '2024-11-10', 980000),
(2, 8, '2024-11-10', 670000),
(3, 1, '2024-11-11', 430000),
(4, 3, '2024-11-11', 780000),
(5, 6, '2024-11-12', 980000),
(6, 7, '2024-11-12', 1500000),
(7, 8, '2024-11-13', 1200000),
(8, 1, '2024-11-13', 430000),
(9, 3, '2024-11-14', 1230000),
(10, 6, '2024-11-14', 560000),
(11, 7, '2024-11-15', 670000),
(12, 8, '2024-11-15', 780000),
(13, 1, '2024-11-16', 900000),
(14, 3, '2024-11-16', 1200000),
(15, 6, '2024-11-17', 1230000),
(16, 7, '2024-11-17', 560000),
(17, 8, '2024-11-18', 980000),
(18, 1, '2024-11-18', 1500000),
(1, 3, '2024-11-19', 780000),
(2, 6, '2024-11-19', 430000),
(3, 7, '2024-11-20', 670000),
(4, 8, '2024-11-20', 900000),
(5, 1, '2024-11-20', 1200000);
GO

-- Chèn dữ liệu giả cho bảng OrderInfo
INSERT INTO OrderInfo (OrderID, ProductID, Quantity, PriceAtPurchase)
VALUES 
(1, 1, 10, 3500),
(1, 2, 1, 150000),
(2, 3, 1, 1200000),
(3, 4, 2, 50000),
(4, 6, 3, 130000),
(4, 5, 5, 4000),
(5, 1, 5, 200000),
(5, 2, 2, 350000),
(6, 3, 3, 150000),
(6, 4, 4, 50000),
(7, 5, 2, 78000),
(7, 6, 1, 120000),
(8, 2, 3, 670000),
(8, 3, 1, 890000),
(9, 4, 2, 430000),
(9, 5, 3, 560000),
(10, 1, 1, 150000),
(10, 3, 2, 123000),
(11, 4, 3, 980000),
(11, 5, 1, 780000),
(12, 2, 2, 90000),
(12, 6, 3, 130000),
(13, 1, 4, 350000),
(13, 3, 5, 450000),
(14, 4, 2, 230000),
(14, 5, 1, 123000),
(15, 2, 3, 78000),
(15, 6, 4, 150000),
(16, 1, 5, 120000),
(16, 3, 2, 98000),
(17, 4, 1, 450000),
(17, 5, 3, 670000),
(18, 2, 2, 89000),
(18, 6, 4, 350000),
(19, 1, 1, 123000),
(19, 3, 5, 56000),
(20, 4, 3, 120000),
(20, 5, 1, 780000),
(21, 2, 2, 890000),
(21, 6, 4, 123000),
(22, 1, 5, 35000),
(22, 3, 2, 450000),
(23, 4, 1, 120000),
(23, 5, 3, 98000),
(24, 2, 2, 67000),
(24, 6, 4, 56000),
(25, 1, 1, 45000),
(25, 3, 5, 123000),
(26, 4, 3, 350000),
(26, 5, 1, 89000),
(27, 2, 2, 120000),
(27, 6, 4, 670000);
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
    @EmployeeID INT = NULL
AS
BEGIN
    IF @EmployeeID IS NULL
        SELECT * FROM Employees
    ELSE
        SELECT * FROM Employees WHERE EmployeeID = @EmployeeID
END
GO

-- Stored procedure to retrieve employee details
CREATE PROCEDURE USP_GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees
END
GO

-- Stored procedure to add a new employee
CREATE PROC USP_AddEmployee
    @FullName NVARCHAR(255),
    @Gender CHAR(1),
	@Role VARCHAR(50),
    @Phone VARCHAR(15),
    @Email VARCHAR(255),
    @Salary DECIMAL(18,2),
    @HireDate DATE
AS
BEGIN
    INSERT INTO Employees (FullName, Gender, Role, Phone, Email, Salary, HireDate)
    VALUES (@FullName, @Gender, @Role, @Phone, @Email, @Salary, @HireDate)
END
GO

-- Stored procedure to update an existing employee's details
CREATE PROC USP_UpdateEmployee
    @EmployeeID INT,
    @FullName NVARCHAR(255) = NULL,
    @Gender CHAR(1) = NULL,
    @Role VARCHAR(50) = NULL,
    @Phone VARCHAR(15) = NULL,
    @Email VARCHAR(255) = NULL,
    @Salary DECIMAL(18,2) = NULL,
    @HireDate DATE = NULL
AS
BEGIN
    UPDATE Employees
    SET FullName = COALESCE(@FullName, FullName),
        Gender = COALESCE(@Gender, Gender),
        Role = COALESCE(@Role, Role),
        Phone = COALESCE(@Phone, Phone),
        Email = COALESCE(@Email, Email),
        Salary = COALESCE(@Salary, Salary),
        HireDate = COALESCE(@HireDate, HireDate)
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
    @Role VARCHAR(50) 
AS
BEGIN
    SELECT e.EmployeeID, e.FullName, e.Gender, e.Role, e.Phone, e.Email, e.Salary, e.HireDate
    FROM Employees e
    WHERE e.Role = @Role
END
GO

CREATE PROCEDURE USP_AddCustomer
    @FullName NVARCHAR(255),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(255),
    @Address NVARCHAR(255)
AS
BEGIN
    INSERT INTO Customers (FullName, Phone, Email, Address)
    VALUES (@FullName, @Phone, @Email, @Address);
	 SELECT SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE USP_GetAllCustomers
AS
BEGIN
    SELECT * FROM Customers;
END
GO

CREATE PROCEDURE USP_UpdateCustomer
    @CustomerID INT,
    @FullName NVARCHAR(255),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(255),
    @Address NVARCHAR(255)
AS
BEGIN
    UPDATE Customers
    SET FullName = @FullName,
        Phone = @Phone,
        Email = @Email,
        Address = @Address
    WHERE CustomerID = @CustomerID;
END
GO

CREATE PROCEDURE USP_DeleteCustomer
    @CustomerID INT
AS
BEGIN
    DELETE FROM Customers WHERE CustomerID = @CustomerID;
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

CREATE PROCEDURE USP_AddProduct
    @ProductName NVARCHAR(255),
    @CategoryID INT,
    @SupplierID INT,
    @Price DECIMAL(10, 2),
    @QuantityInStock INT,
    @ExpirationDate DATE
AS
BEGIN
    INSERT INTO Products (ProductName, CategoryID, SupplierID, Price, QuantityInStock, ExpirationDate)
    VALUES (@ProductName, @CategoryID, @SupplierID, @Price, @QuantityInStock, @ExpirationDate);
END
GO

CREATE PROCEDURE USP_GetAllProducts
AS
BEGIN
    SELECT * FROM Products;
END
GO

CREATE PROCEDURE USP_GetProductIDByName
    @ProductName NVARCHAR(255)
AS
BEGIN
    SELECT ProductID
    FROM Products
    WHERE ProductName = @ProductName
END
GO


CREATE PROCEDURE USP_UpdateProduct
    @ProductID INT,
    @ProductName NVARCHAR(255),
    @CategoryID INT,
    @SupplierID INT,
    @Price DECIMAL(10, 2),
    @QuantityInStock INT,
    @ExpirationDate DATE
AS
BEGIN
    UPDATE Products
    SET ProductName = @ProductName,
        CategoryID = @CategoryID,
        SupplierID = @SupplierID,
        Price = @Price,
        QuantityInStock = @QuantityInStock,
        ExpirationDate = @ExpirationDate
    WHERE ProductID = @ProductID;
END
GO

CREATE PROCEDURE USP_DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Products WHERE ProductID = @ProductID;
END
GO

CREATE PROCEDURE USP_GetCategoryByProductID
    @ProductID INT
AS
BEGIN
    SELECT CategoryName
    FROM ProductCategory
    INNER JOIN Products ON ProductCategory.CategoryID = Products.CategoryID
    WHERE Products.ProductID = @ProductID;
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

CREATE PROCEDURE USP_AddSupplier
    @SupplierName NVARCHAR(255),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(255),
    @Address NVARCHAR(255)
AS
BEGIN
    INSERT INTO Suppliers (SupplierName, Phone, Email, Address)
    VALUES (@SupplierName, @Phone, @Email, @Address);
END
GO

CREATE PROCEDURE USP_GetAllSuppliers
AS
BEGIN
    SELECT * FROM Suppliers;
END
GO

CREATE PROCEDURE USP_UpdateSupplier
    @SupplierID INT,
    @SupplierName NVARCHAR(255),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(255),
    @Address NVARCHAR(255)
AS
BEGIN
    UPDATE Suppliers
    SET SupplierName = @SupplierName,
        Phone = @Phone,
        Email = @Email,
        Address = @Address
    WHERE SupplierID = @SupplierID;
END
GO

CREATE PROCEDURE USP_DeleteSupplier
    @SupplierID INT
AS
BEGIN
    DELETE FROM Suppliers WHERE SupplierID = @SupplierID;
END
GO

CREATE PROCEDURE USP_GetOrdersByDateRange
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT o.OrderID, o.CustomerID, c.FullName AS CustomerName, 
           o.EmployeeID, e.FullName AS EmployeeName, o.OrderDate, o.TotalAmount
    FROM Orders o
    INNER JOIN Customers c ON o.CustomerID = c.CustomerID
    INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
    WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
    ORDER BY o.OrderDate;
END
GO

CREATE PROCEDURE USP_GetExpiredMedicines
AS
BEGIN
    SELECT
		Products.ProductID,
		Products.CategoryID,
        Products.ProductName,
        ProductCategory.CategoryName,
		Products.SupplierID,
        Suppliers.SupplierName,
        Products.ExpirationDate,
        Products.QuantityInStock,
		Products.Price
    FROM 
        Products
    JOIN 
        ProductCategory ON Products.CategoryID = ProductCategory.CategoryID
    JOIN 
        Suppliers ON Products.SupplierID = Suppliers.SupplierID
    WHERE 
        Products.ExpirationDate < GETDATE();
END
GO

CREATE PROCEDURE USP_GetLowStockMedicines
    @Threshold INT
AS
BEGIN
    -- Retrieve low-stock products
    SELECT 
        Products.ProductID,
        Products.ProductName,
        Products.CategoryID,
        ProductCategory.CategoryName,
        Products.SupplierID,
        Suppliers.SupplierName,
		Products.ExpirationDate,
        Products.QuantityInStock,
        Products.Price
    FROM 
        Products
    INNER JOIN 
        ProductCategory ON Products.CategoryID = ProductCategory.CategoryID
    INNER JOIN 
        Suppliers ON Products.SupplierID = Suppliers.SupplierID
    WHERE 
        Products.QuantityInStock <= @Threshold;
END
GO

--hàm tìm kiếm gần đúng
CREATE FUNCTION [dbo].[fuConvertToUnsign1](@strInput NVARCHAR(4000)) 
	RETURNS NVARCHAR(4000)
AS
BEGIN
	IF @strInput IS NULL 
		RETURN @strInput 
		IF @strInput = '' 
			RETURN @strInput 
		DECLARE @RT NVARCHAR(4000) 
		DECLARE @SIGN_CHARS NCHAR(136) 
		DECLARE @UNSIGN_CHARS NCHAR (136)

SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int 

SET @COUNTER = 1 
WHILE(@COUNTER <= LEN(@strInput))
BEGIN

SET @COUNTER1 = 1 
WHILE(@COUNTER1 <= LEN(@SIGN_CHARS)+ 1)
BEGIN
	IF UNICODE(
    SUBSTRING(@SIGN_CHARS, @COUNTER1, 1)) = UNICODE(SUBSTRING(@strInput, @COUNTER, 1))
BEGIN 
IF @COUNTER = 1 
SET 
@strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1, 1) + SUBSTRING(@strInput, @COUNTER + 1, LEN(@strInput)-1)
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER -1) + SUBSTRING(@UNSIGN_CHARS, @COUNTER1, 1) + SUBSTRING(@strInput, @COUNTER + 1, LEN(@strInput)- @COUNTER)
BREAK
END

SET @COUNTER1 = @COUNTER1 + 1
END 
SET @COUNTER = @COUNTER + 1
END

SET @strInput = replace(@strInput, ' ', '-') 
	RETURN @strInput
END
--------------------------------------------------------
