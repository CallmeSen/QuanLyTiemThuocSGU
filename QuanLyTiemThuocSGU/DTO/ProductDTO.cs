using System;
using System.Collections.Generic;
using System.Data;
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

        public ProductDTO() { }

        public ProductDTO(DataRow row)
        {
            ProductID = Convert.ToInt32(row["ProductID"]);
            ProductName = row["ProductName"].ToString();
            CategoryID = Convert.ToInt32(row["CategoryID"]);
            SupplierID = Convert.ToInt32(row["SupplierID"]);
            Price = Convert.ToDecimal(row["Price"]);
            QuantityInStock = Convert.ToInt32(row["QuantityInStock"]);
            ExpirationDate = row["ExpirationDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ExpirationDate"]);
        }


        public override string ToString()
        {
            return $"ProductID: {ProductID}, ProductName: {ProductName}, CategoryID: {CategoryID}, SupplierID: {SupplierID}, Price: {Price}, QuantityInStock: {QuantityInStock}, ExpirationDate: {ExpirationDate?.ToShortDateString()}";
        }
    }
}

