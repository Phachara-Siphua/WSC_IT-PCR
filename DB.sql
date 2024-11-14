use master

CREATE DATABASE BelleCroissantLyonnais;
go

USE BelleCroissantLyonnais;

-- Products Table
CREATE TABLE Products (
    product_id INT PRIMARY KEY,
    name VARCHAR(255),
    category VARCHAR(50),
    ingredients TEXT,
    price DECIMAL(10, 2),
    cost DECIMAL(10, 2),
    seasonal_indicator INT,  -- ใช้ INT แทน BOOLEAN
    active_status INT,       -- ใช้ INT แทน BOOLEAN
    introduction_date DATE
);


-- Customers Table
CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    name VARCHAR(255),
    age INT,
    gender CHAR(1),
    postal_code VARCHAR(10),
    email VARCHAR(255),
    phone_number VARCHAR(20),
    membership_status VARCHAR(10), -- ใช้ VARCHAR แทน ENUM
    join_date DATE,
    last_purchase_date DATE,
    total_spending DECIMAL(15, 2),
    average_order_value DECIMAL(10, 2),
    frequency INT,
    preferred_category VARCHAR(50),
    churn_status VARCHAR(10), -- ใช้ VARCHAR แทน ENUM
    CHECK (membership_status IN ('Basic', 'Silver', 'Gold')), -- ตรวจสอบค่าของ membership_status
    CHECK (churn_status IN ('Active', 'Churned')) -- ตรวจสอบค่าของ churn_status
);


-- Sales Transactions Table
CREATE TABLE Sales_Transactions (
    transaction_id INT PRIMARY KEY,
    customer_id INT,
    date DATETIME,
    product_id INT,
    quantity INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Forecasting Table
CREATE TABLE Sales_Forecasting (
    date DATE PRIMARY KEY,
    predicted_sales DECIMAL(15, 2)
);

-- Customer Segmentation Table
CREATE TABLE Customer_Segmentation (
    customer_id INT,
    cluster_label INT,
    total_purchases INT,
    avg_purchase_value DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

-- Recommendations Table
CREATE TABLE Product_Recommendations (
    customer_id INT,
    recommended_product_1 INT,
    recommended_product_2 INT,
    recommended_product_3 INT,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
    FOREIGN KEY (recommended_product_1) REFERENCES Products(product_id),
    FOREIGN KEY (recommended_product_2) REFERENCES Products(product_id),
    FOREIGN KEY (recommended_product_3) REFERENCES Products(product_id)
);

-- Price Analysis Table
CREATE TABLE Price_Analysis (
    product_id INT PRIMARY KEY,
    price_elasticity_of_demand DECIMAL(10, 2),
    suggested_price_change DECIMAL(5, 2),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Customer Lifetime Value (CLTV) Table
CREATE TABLE Customer_Lifetime_Value (
    customer_id INT PRIMARY KEY,
    cltv DECIMAL(15, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

-- Churn Analysis Table
CREATE TABLE Churn_Analysis (
    churn_rate DECIMAL(5, 2),
    avg_cltv_churned DECIMAL(15, 2),
    avg_cltv_active DECIMAL(15, 2)
);

-- Insert sample data into Products table
INSERT INTO Products (product_id, name, category, ingredients, price, cost, seasonal_indicator, active_status, introduction_date)
VALUES
    (1, 'Croissant', 'Pastries', 'Flour, Butter, Sugar, Yeast', 2.50, 1.20, 0, 1, '2023-01-10'),
    (2, 'Baguette', 'Bread', 'Flour, Water, Salt, Yeast', 1.80, 0.80, 0, 1, '2022-12-01'),
    (3, 'Chocolate Tart', 'Tarte', 'Flour, Chocolate, Butter, Sugar', 3.00, 1.50, 1, 1, '2023-05-15'),
    (4, 'Almond Croissant', 'Pastries', 'Flour, Butter, Almonds, Sugar, Yeast', 3.20, 1.80, 0, 1, '2023-02-01'),
    (5, 'Quiche', 'Pastries', 'Flour, Eggs, Cheese, Milk, Ham', 3.50, 2.00, 0, 1, '2023-03-10');

-- Insert sample data into Customers table
INSERT INTO Customers (customer_id, name, age, gender, postal_code, email, phone_number, membership_status, join_date, last_purchase_date, total_spending, average_order_value, frequency, preferred_category, churn_status)
VALUES
    (1, 'Alice Johnson', 28, 'F', '69000', 'alice@example.com', '1234567890', 'Gold', '2023-01-05', '2023-10-12', 150.00, 15.00, 10, 'Pastries', 'Active'),
    (2, 'Bob Smith', 35, 'M', '75000', 'bob@example.com', '0987654321', 'Silver', '2022-11-15', '2023-09-20', 85.00, 8.50, 10, 'Bread', 'Active'),
    (3, 'Clara Williams', 42, 'F', '69001', 'clara@example.com', '1122334455', 'Basic', '2023-04-25', '2023-07-10', 50.00, 5.00, 10, 'Tarte', 'Churned'),
    (4, 'David Brown', 30, 'M', '69002', 'david@example.com', '5566778899', 'Gold', '2022-06-18', '2023-11-01', 200.00, 20.00, 10, 'Pastries', 'Active'),
    (5, 'Emma Wilson', 27, 'F', '69003', 'emma@example.com', '6677889900', 'Silver', '2023-02-10', '2023-08-30', 120.00, 12.00, 10, 'Bread', 'Churned');

-- Insert sample data into Sales_Transactions table
INSERT INTO Sales_Transactions (transaction_id, customer_id, date, product_id, quantity, price)
VALUES
    (1, 1, '2023-10-10 10:30:00', 1, 2, 5.00),
    (2, 2, '2023-09-20 14:00:00', 2, 3, 5.40),
    (3, 3, '2023-07-10 11:15:00', 3, 1, 3.00),
    (4, 4, '2023-11-01 13:45:00', 4, 4, 12.80),
    (5, 5, '2023-08-30 09:20:00', 5, 2, 7.00);

-- Insert sample data into Sales_Forecasting table
INSERT INTO Sales_Forecasting (date, predicted_sales)
VALUES
    ('2023-11-14', 300.00),
    ('2023-11-15', 320.00),
    ('2023-11-16', 310.00),
    ('2023-11-17', 305.00),
    ('2023-11-18', 325.00);

-- Insert sample data into Customer_Segmentation table
INSERT INTO Customer_Segmentation (customer_id, cluster_label, total_purchases, avg_purchase_value)
VALUES
    (1, 1, 10, 15.00),
    (2, 2, 5, 8.50),
    (3, 3, 3, 5.00),
    (4, 1, 12, 20.00),
    (5, 2, 7, 12.00);

-- Insert sample data into Product_Recommendations table
INSERT INTO Product_Recommendations (customer_id, recommended_product_1, recommended_product_2, recommended_product_3)
VALUES
    (1, 2, 3, 4),
    (2, 1, 4, 5),
    (3, 2, 3, 5),
    (4, 1, 3, 5),
    (5, 2, 4, 1);

-- Insert sample data into Price_Analysis table
INSERT INTO Price_Analysis (product_id, price_elasticity_of_demand, suggested_price_change)
VALUES
    (1, -1.2, -5.0),
    (2, -0.8, 3.0),
    (3, -1.5, -2.5),
    (4, -1.0, 4.0),
    (5, -1.3, -3.5);

-- Insert sample data into Customer_Lifetime_Value table
INSERT INTO Customer_Lifetime_Value (customer_id, cltv)
VALUES
    (1, 450.00),
    (2, 255.00),
    (3, 150.00),
    (4, 600.00),
    (5, 360.00);

-- Insert sample data into Churn_Analysis table
INSERT INTO Churn_Analysis (churn_rate, avg_cltv_churned, avg_cltv_active)
VALUES
    (25.00, 250.00, 500.00);
