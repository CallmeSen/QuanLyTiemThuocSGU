using System;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

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

        // Method to update employee details
        public void UpdateStaff(StaffInfoDTO staff)
        {
            try
            {
                string query = "EXEC USP_UpdateEmployee @EmployeeID, @FullName, @Gender, @Role, @Phone, @Email, @Salary, @HireDate";
                DataProvider.Instance.ExecuteNonQuery(query, new object[]
                {
                    staff.EmployeeID,
                    staff.FullName,
                    staff.Gender,
                    staff.Role,
                    staff.Phone,
                    staff.Email,
                    staff.Salary,
                    staff.HireDate
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
            }
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
    }
}
