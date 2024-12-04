using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CustomerDAO() { }

        public List<CustomerDTO> SearchCustomerByName(string name)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = string.Format(
                "SELECT * FROM dbo.Customers WHERE dbo.fuConvertToUnsign1(FullName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'",
                name
            );
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                list.Add(customer);
            }

            return list;
        }

        public List<CustomerDTO> SearchCustomerByPhone(string phone)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = "SELECT * FROM Customers WHERE Phone LIKE @phone";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + phone + "%" });

            foreach (DataRow row in data.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                list.Add(customer);
            }

            return list;
        }

        // Thêm khách hàng mới
        public int AddCustomer(string fullName, string phone, string email, string address)
        {
            string query = "EXEC USP_AddCustomer @FullName , @Phone , @Email , @Address";

            // Use ExecuteScalar to get the newly added CustomerID
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { fullName, phone, email, address });

            if (result != null && int.TryParse(result.ToString(), out int customerID))
            {
                return customerID; // Return the CustomerID
            }

            return -1; // Return -1 if insertion failed
        }

        // Lấy danh sách tất cả khách hàng
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();
            string query = "EXEC USP_GetAllCustomers";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                customers.Add(MapDataRowToCustomer(row));
            }
            return customers;
        }

        // Cập nhật thông tin khách hàng
        public bool UpdateCustomer(int customerID, string fullName, string phone, string email, string address)
        {
            string query = "EXEC USP_UpdateCustomer @CustomerID , @FullName , @Phone , @Email , @Address";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                customerID,
                (object)fullName ?? DBNull.Value,
                (object)phone ?? DBNull.Value,
                (object)email ?? DBNull.Value,
                (object)address ?? DBNull.Value
            });

            return result > 0; // Return true if at least one row is affected
        }

        // Xóa khách hàng
        public bool DeleteCustomer(int customerID)
        {
            string query = "EXEC USP_DeleteCustomer @CustomerID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { customerID });
            return result > 0;
        }

        // Chuyển đổi DataRow thành CustomerDTO
        private CustomerDTO MapDataRowToCustomer(DataRow row)
        {
            return new CustomerDTO
            {
                CustomerID = Convert.ToInt32(row["CustomerID"]),
                FullName = row["FullName"].ToString(),
                Phone = row["Phone"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString()
            };
        }
    }
}

