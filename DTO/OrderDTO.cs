using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Constructor to initialize all properties
        public OrderDTO(int orderID, int customerID, int employeeID, DateTime orderDate, decimal totalAmount)
        {
            OrderID = orderID;
            CustomerID = customerID;
            EmployeeID = employeeID;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }

        // Default constructor
        public OrderDTO() { }

        // Optional: Override ToString() for easier debugging and display
        public override string ToString()
        {
            return $"OrderID: {OrderID}, CustomerID: {CustomerID}, EmployeeID: {EmployeeID}, OrderDate: {OrderDate}, TotalAmount: {TotalAmount:C}";
        }
    }
}
