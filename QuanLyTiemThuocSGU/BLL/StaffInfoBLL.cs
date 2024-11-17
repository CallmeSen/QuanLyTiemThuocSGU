using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class StaffInfoBLL
    {
        private StaffInfoDAO staffInfoDAO = StaffInfoDAO.Instance;

        public StaffInfoDTO GetStaffDetails(int employeeID)
        {
            return staffInfoDAO.GetStaffByID(employeeID);
        }

        public bool UpdateStaffDetails(StaffInfoDTO staffInfo)
        {
            return staffInfoDAO.UpdateStaff(staffInfo.EmployeeID, staffInfo.FullName, staffInfo.Gender, staffInfo.Role, staffInfo.Phone, staffInfo.Email, staffInfo.Salary, staffInfo.HireDate);
        }
    }
}
