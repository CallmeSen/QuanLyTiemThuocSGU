using System;
using System.Collections.Generic;
using System.Data;
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
        public DateTime? OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Constructor to initialize all properties
        public OrderDTO(DataRow row)
        {
            OrderID = Convert.ToInt32(row["OrderID"]);
            CustomerID = Convert.ToInt32(row["CustomerID"]);
            EmployeeID = Convert.ToInt32(row["EmployeeID"]);
            OrderDate = row["OrderDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["OrderDate"]);
            TotalAmount = row["TotalAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TotalAmount"]);
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
