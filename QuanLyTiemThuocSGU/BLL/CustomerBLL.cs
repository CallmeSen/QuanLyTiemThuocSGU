using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class CustomerBLL
    {
        private static CustomerBLL instance;
        public static CustomerBLL Instance
        {
            get
            {
                if (instance == null) instance = new CustomerBLL();
                return instance;
            }
            private set => instance = value;
        }

        private CustomerBLL() { }
        public List<CustomerDTO> SearchCustomerByPhone(string phone)
        {
            return CustomerDAO.Instance.SearchCustomerByPhone(phone);
        }

        // Thêm khách hàng mới
        public int AddCustomer(string fullName, string phone, string email, string address)
        {
            try
            {
                return CustomerDAO.Instance.AddCustomer(fullName, phone, email, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding customer: {ex.Message}");
                return -1;
            }
        }


        // Lấy danh sách khách hàng
        public List<CustomerDTO> GetAllCustomers()
        {
            try
            {
                return CustomerDAO.Instance.GetAllCustomers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving customers: {ex.Message}");
                return new List<CustomerDTO>();
            }
        }

        // Cập nhật thông tin khách hàng
        public bool UpdateCustomer(int customerID, string fullName, string phone, string email, string address)
        {
            try
            {
                return CustomerDAO.Instance.UpdateCustomer(customerID, fullName, phone, email, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating customer: {ex.Message}");
                return false;
            }
        }

        // Xóa khách hàng
        public bool DeleteCustomer(int customerID)
        {
            try
            {
                return CustomerDAO.Instance.DeleteCustomer(customerID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                return false;
            }
        }
    }
}

