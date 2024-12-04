using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class OrderInfoDTO
    {
        public int OrderInfoID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }

        // Optional: Constructor and ToString() method for debugging
        public OrderInfoDTO(DataRow row)
        {
            OrderInfoID = Convert.ToInt32(row["OrderInfoID"]);
            OrderID = Convert.ToInt32(row["OrderID"]);
            ProductID = Convert.ToInt32(row["ProductID"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
            PriceAtPurchase = row["PriceAtPurchase"] == DBNull.Value ? 0 : Convert.ToDecimal(row["PriceAtPurchase"]);
        }


        public OrderInfoDTO() { }

        public override string ToString()
        {
            return $"OrderInfoID: {OrderInfoID}, OrderID: {OrderID}, ProductID: {ProductID}, Quantity: {Quantity}, PriceAtPurchase: {PriceAtPurchase:C}";
        }
    }
}

