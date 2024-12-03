using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Security;
using QuanLyThuVienSGU_Winform.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThuVienSGU_Winform.DAO
{
    internal class StaffInfoDAO
    {
        private static StaffInfoDAO instance;

        public static StaffInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffInfoDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private StaffInfoDAO() { }

        public StaffInfoDTO GetStaffByID(int employeeID)
        {
            try
            {
                string query = "USP_GetEmployeeByID @EmployeeID ";
                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { employeeID });

                if (data.Rows.Count > 0)
                {
                    return MapDataRowToStaffInfo(data.Rows[0]);
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving employee: {ex.Message}"); // check lỗi thử 
                return null;
            }
        }

        public bool AddStaff(string FullName, string Gender, string Role, string Phone, String Email, decimal Salary, DateTime HireDate)
        {
            string query = "EXEC USP_AddEmployee @FullName , @Gender , @Role , @Phone , @Email , @Salary , @HireDate ";
            object[] parameters = { FullName, Gender, Role, Phone, Email, Salary, HireDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0; // Returns true if the query executed successfully
        }

        public bool DeleteStaff(int employeeID)
        {
            try
            {
                string query = "EXEC USP_DeleteEmployee @EmployeeID";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { employeeID });

                return result > 0; // Returns true if rows were affected
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting staff: {ex.Message}");
                return false;
            }
        }


        // Method to update employee details
        public bool UpdateStaff(int employeeID, string fullName, string gender, string role, string phone, string email, decimal salary, DateTime hireDate)
        {
            string query = "EXEC USP_UpdateEmployee @EmployeeID , @FullName , @Gender , @Role , @Phone , @Email , @Salary , @HireDate ";
            object[] parameters = { employeeID, fullName, gender, role, phone, email, salary, hireDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Private helper method to map DataRow to StaffInfo object
        private StaffInfoDTO MapDataRowToStaffInfo(DataRow row)
        {
            return new StaffInfoDTO
            {
                EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                FullName = row["FullName"].ToString(),
                Gender = row["Gender"].ToString(),
                Role = row["Role"].ToString(),
                Phone = row["Phone"].ToString(),
                Email = row["Email"].ToString(),
                Salary = Convert.ToDecimal(row["Salary"]),
                HireDate = Convert.ToDateTime(row["HireDate"])
            };
        }

        public List<StaffInfoDTO> SearchProductByName(string name)
        {
            List<StaffInfoDTO> list = new List<StaffInfoDTO>();
            string query = string.Format("SELECT * FROM dbo.Employees WHERE dbo.fuConvertToUnsign1(FullName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                StaffInfoDTO product = new StaffInfoDTO(row);
                list.Add(product);
            }

            return list;
        }
    }
}
