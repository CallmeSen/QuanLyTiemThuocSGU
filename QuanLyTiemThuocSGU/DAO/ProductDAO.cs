﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class ProductDAO
    {
        // Singleton instance
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private ProductDAO() { }

        // Method to add a new product
        public bool AddProduct(string productName, int categoryID, int supplierID, decimal price, int quantityInStock, DateTime? expirationDate)
        {
            string query = "EXEC USP_AddProduct @ProductName, @CategoryID, @SupplierID, @Price, @QuantityInStock, @ExpirationDate";
            object[] parameters = { productName, categoryID, supplierID, price, quantityInStock, expirationDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to retrieve all products
        public List<ProductDTO> GetAllProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            string query = "EXEC USP_GetAllProducts";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                products.Add(MapDataRowToProduct(row));
            }
            return products;
        }

        // Method to update a product
        public bool UpdateProduct(int productID, string productName, int categoryID, int supplierID, decimal price, int quantityInStock, DateTime? expirationDate)
        {
            string query = "EXEC USP_UpdateProduct @ProductID, @ProductName, @CategoryID, @SupplierID, @Price, @QuantityInStock, @ExpirationDate";
            object[] parameters = { productID, productName, categoryID, supplierID, price, quantityInStock, expirationDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to delete a product by ID
        public bool DeleteProduct(int productID)
        {
            string query = "EXEC USP_DeleteProduct @ProductID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { productID });
            return result > 0;
        }

        // Private helper method to map DataRow to ProductDTO
        private ProductDTO MapDataRowToProduct(DataRow row)
        {
            return new ProductDTO
            {
                ProductID = Convert.ToInt32(row["ProductID"]),
                ProductName = row["ProductName"].ToString(),
                CategoryID = Convert.ToInt32(row["CategoryID"]),
                SupplierID = Convert.ToInt32(row["SupplierID"]),
                Price = Convert.ToDecimal(row["Price"]),
                QuantityInStock = Convert.ToInt32(row["QuantityInStock"]),
                ExpirationDate = row["ExpirationDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ExpirationDate"])
            };
        }
    }
}
