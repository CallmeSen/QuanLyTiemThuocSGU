using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;
using System.Data;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class OrderBLL
    {
        // Singleton instance
        private static OrderBLL instance;
        public static OrderBLL Instance
        {
            get
            {
                if (instance == null) instance = new OrderBLL();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private OrderBLL() { }

        // Method to create a new order
        public bool CreateOrder(int customerID, int employeeID, DateTime orderDate, decimal totalAmount)
        {
            try
            {
                int result = OrderDAO.Instance.CreateOrder(customerID, employeeID, orderDate, totalAmount);
                return result > 0; // Returns true if the order was successfully created
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating order: {ex.Message}");
                return false;
            }
        }

        // Method to get an order by ID
        public OrderDTO GetOrderByID(int orderID)
        {
            try
            {
                return OrderDAO.Instance.GetOrderByID(orderID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving order: {ex.Message}");
                return null;
            }
        }

        // Method to update an order
        public bool UpdateOrder(int orderID, int customerID, int employeeID, DateTime orderDate, decimal totalAmount)
        {
            try
            {
                return OrderDAO.Instance.UpdateOrder(orderID, customerID, employeeID, orderDate, totalAmount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating order: {ex.Message}");
                return false;
            }
        }

        // Method to delete an order
        public bool DeleteOrder(int orderID)
        {
            try
            {
                return OrderDAO.Instance.DeleteOrder(orderID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order: {ex.Message}");
                return false;
            }
        }

        // Additional method to retrieve all orders (if needed)
        public List<OrderDTO> GetAllOrders()
        {
            try
            {
                List<OrderDTO> orders = new List<OrderDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Orders");

                foreach (DataRow row in data.Rows)
                {
                    orders.Add(new OrderDTO
                    {
                        OrderID = Convert.ToInt32(row["OrderID"]),
                        CustomerID = Convert.ToInt32(row["CustomerID"]),
                        EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                        OrderDate = Convert.ToDateTime(row["OrderDate"]),
                        TotalAmount = Convert.ToDecimal(row["TotalAmount"])
                    });
                }
                return orders;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving all orders: {ex.Message}");
                return new List<OrderDTO>();
            }
        }
    }
}

