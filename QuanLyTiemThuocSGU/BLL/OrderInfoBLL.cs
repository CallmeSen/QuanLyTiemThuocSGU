using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class OrderInfoBLL
    {
        // Singleton instance
        private static OrderInfoBLL instance;
        public static OrderInfoBLL Instance
        {
            get
            {
                if (instance == null) instance = new OrderInfoBLL();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private OrderInfoBLL() { }

        // Method to add a new item to an order
        public bool AddOrderItem(int orderID, int productID, int quantity, decimal priceAtPurchase)
        {
            try
            {
                return OrderInfoDAO.Instance.AddOrderItem(orderID, productID, quantity, priceAtPurchase);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding order item: {ex.Message}");
                return false;
            }
        }

        // Method to get all items for a specific order
        public List<OrderInfoDTO> GetOrderItemsByOrderID(int orderID)
        {
            try
            {
                return OrderInfoDAO.Instance.GetOrderItemsByOrderID(orderID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving order items: {ex.Message}");
                return new List<OrderInfoDTO>();
            }
        }

        // Method to delete an item from an order
        public bool DeleteOrderItem(int orderInfoID)
        {
            try
            {
                return OrderInfoDAO.Instance.DeleteOrderItem(orderInfoID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order item: {ex.Message}");
                return false;
            }
        }
    }
}
