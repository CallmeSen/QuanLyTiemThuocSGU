using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;


namespace QuanLyThuVienSGU_Winform.DAO
{
    public class OrderDAO
    {
        // Singleton instance
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private OrderDAO() {}

        // Method to create a new order
        public int CreateOrder(int customerID, int employeeID, DateTime orderDate, decimal totalAmount)
        {
            string query = "EXEC USP_CreateOrder @CustomerID, @EmployeeID, @OrderDate, @TotalAmount";
            object[] parameters = { customerID, employeeID, orderDate, totalAmount };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        // Method to get order details by order ID
        public OrderDTO GetOrderByID(int orderID)
        {
            string query = "EXEC USP_GetOrderByID @OrderID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { orderID });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return MapDataRowToOrder(row);
            }
            return null;
        }

        // Method to update an existing order
        public bool UpdateOrder(int orderID, int customerID, int employeeID, DateTime orderDate, decimal totalAmount)
        {
            string query = "EXEC USP_UpdateOrder @OrderID, @CustomerID, @EmployeeID, @OrderDate, @TotalAmount";
            object[] parameters = { orderID, customerID, employeeID, orderDate, totalAmount };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to delete an order by ID
        public bool DeleteOrder(int orderID)
        {
            string query = "EXEC USP_DeleteOrder @OrderID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderID });
            return result > 0;
        }

        // Private helper method to map DataRow to Order object
        private OrderDTO MapDataRowToOrder(DataRow row)
        {
            return new OrderDTO
            {
                OrderID = Convert.ToInt32(row["OrderID"]),
                CustomerID = Convert.ToInt32(row["CustomerID"]),
                EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                OrderDate = Convert.ToDateTime(row["OrderDate"]),
                TotalAmount = Convert.ToDecimal(row["TotalAmount"])
            };
        }

        public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "EXEC USP_GetOrdersByDateRange @StartDate , @EndDate ";
            object[] parameters = { startDate, endDate };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}

