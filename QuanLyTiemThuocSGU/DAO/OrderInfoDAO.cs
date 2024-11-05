using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class OrderInfoDAO
    {
        // Singleton instance
        private static OrderInfoDAO instance;
        public static OrderInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderInfoDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private OrderInfoDAO() { }

        // Method to add a new item to an order
        public bool AddOrderItem(int orderID, int productID, int quantity, decimal priceAtPurchase)
        {
            string query = "EXEC USP_AddOrderItem @OrderID, @ProductID, @Quantity, @PriceAtPurchase";
            object[] parameters = { orderID, productID, quantity, priceAtPurchase };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to get order items by order ID
        public List<OrderInfoDTO> GetOrderItemsByOrderID(int orderID)
        {
            List<OrderInfoDTO> orderItems = new List<OrderInfoDTO>();
            string query = "EXEC USP_GetOrderItemsByOrderID @OrderID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { orderID });

            foreach (DataRow row in data.Rows)
            {
                orderItems.Add(MapDataRowToOrderInfo(row));
            }
            return orderItems;
        }

        // Method to delete an item from an order
        public bool DeleteOrderItem(int orderInfoID)
        {
            string query = "EXEC USP_DeleteOrderItem @OrderInfoID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderInfoID });
            return result > 0;
        }

        // Private helper method to map DataRow to OrderInfoDTO
        private OrderInfoDTO MapDataRowToOrderInfo(DataRow row)
        {
            return new OrderInfoDTO
            {
                OrderInfoID = Convert.ToInt32(row["OrderInfoID"]),
                OrderID = Convert.ToInt32(row["OrderID"]),
                ProductID = Convert.ToInt32(row["ProductID"]),
                Quantity = Convert.ToInt32(row["Quantity"]),
                PriceAtPurchase = Convert.ToDecimal(row["PriceAtPurchase"])
            };
        }
    }
}

