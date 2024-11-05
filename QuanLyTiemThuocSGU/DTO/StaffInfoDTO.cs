using System;
using System.Collections.Generic;
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
        public DateTime HireDate { get; set; }
    }
}
