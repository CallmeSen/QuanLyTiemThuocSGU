using System;
using System.Collections.Generic;
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
        public OrderInfoDTO(int orderInfoID, int orderID, int productID, int quantity, decimal priceAtPurchase)
        {
            OrderInfoID = orderInfoID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            PriceAtPurchase = priceAtPurchase;
        }

        public OrderInfoDTO() { }

        public override string ToString()
        {
            return $"OrderInfoID: {OrderInfoID}, OrderID: {OrderID}, ProductID: {ProductID}, Quantity: {Quantity}, PriceAtPurchase: {PriceAtPurchase:C}";
        }
    }
}

