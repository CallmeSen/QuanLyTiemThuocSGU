using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class StaffInfoDTO
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime? HireDate { get; set; }

        public StaffInfoDTO() { }

        public StaffInfoDTO(DataRow row)
        {
            EmployeeID = Convert.ToInt32(row["EmployeeID"]);
            FullName = row["FullName"].ToString();
            Gender = row["Gender"].ToString();
            Role = row["Role"].ToString();
            Phone = row["Phone"].ToString();
            Email = row["Email"].ToString();
            Salary = Convert.ToDecimal(row["Salary"]);
            HireDate = row["HireDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["HireDate"]);
        }

    }
}
