using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class SupplierDTO
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Constructor and ToString method for debugging
        public SupplierDTO(DataRow row)
        {
            SupplierID = Convert.ToInt32(row["SupplierID"]);
            SupplierName = row["SupplierName"].ToString();
            Phone = row["Phone"]?.ToString();
            Email = row["Email"]?.ToString();
            Address = row["Address"]?.ToString();
        }


        public SupplierDTO() { }

        public override string ToString()
        {
            return $"SupplierID: {SupplierID}, SupplierName: {SupplierName}, Phone: {Phone}, Email: {Email}, Address: {Address}";
        }
    }
}

