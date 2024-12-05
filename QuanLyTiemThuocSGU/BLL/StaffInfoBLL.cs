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

        // Singleton instance
        private static StaffInfoBLL instance;
        public static StaffInfoBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffInfoBLL();
                return instance;
            }
        }

        // Private constructor to prevent direct instantiation
        private StaffInfoBLL() { }

        private StaffInfoDAO staffInfoDAO = StaffInfoDAO.Instance;

        public List<StaffInfoDTO> GetAllEmployees()
        {
            return StaffInfoDAO.Instance.GetAllEmployees();
        }

        public StaffInfoDTO GetStaffDetails(int employeeID)
        {
            return staffInfoDAO.GetStaffByID(employeeID);
        }

        public bool UpdateStaffDetails(StaffInfoDTO staffInfo)
        {
            DateTime hireDate = staffInfo.HireDate ?? DateTime.MinValue;

            return staffInfoDAO.UpdateStaff(staffInfo.EmployeeID, staffInfo.FullName, staffInfo.Gender, staffInfo.Role, staffInfo.Phone, staffInfo.Email, staffInfo.Salary, hireDate);
        }

        public List<StaffInfoDTO> SearchProductByName(string name)
        {
            return StaffInfoDAO.Instance.SearchProductByName(name);
        }

    }
}
