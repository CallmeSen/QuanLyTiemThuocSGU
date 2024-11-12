using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime? ExpirationDate { get; set; }

        // Optional constructor and ToString method for easier debugging
        public ProductDTO(int productID, string productName, int categoryID, int supplierID, decimal price, int quantityInStock, DateTime? expirationDate)
        {
            ProductID = productID;
            ProductName = productName;
            CategoryID = categoryID;
            SupplierID = supplierID;
            Price = price;
            QuantityInStock = quantityInStock;
            ExpirationDate = expirationDate;
        }

        public ProductDTO() { }

        public override string ToString()
        {
            return $"ProductID: {ProductID}, ProductName: {ProductName}, CategoryID: {CategoryID}, SupplierID: {SupplierID}, Price: {Price}, QuantityInStock: {QuantityInStock}, ExpirationDate: {ExpirationDate?.ToShortDateString()}";
        }
    }
}

