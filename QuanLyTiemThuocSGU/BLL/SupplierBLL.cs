using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class SupplierBLL
    {
        // Singleton instance
        private static SupplierBLL instance;
        public static SupplierBLL Instance
        {
            get
            {
                if (instance == null) instance = new SupplierBLL();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private SupplierBLL() { }

        // Method to add a new supplier
        public bool AddSupplier(string supplierName, string phone, string email, string address)
        {
            try
            {
                return SupplierDAO.Instance.AddSupplier(supplierName, phone, email, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding supplier: {ex.Message}");
                return false;
            }
        }

        // Method to retrieve all suppliers
        public List<SupplierDTO> GetAllSuppliers()
        {
            try
            {
                return SupplierDAO.Instance.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving suppliers: {ex.Message}");
                return new List<SupplierDTO>();
            }
        }

        // Method to update a supplier
        public bool UpdateSupplier(int supplierID, string supplierName, string phone, string email, string address)
        {
            try
            {
                return SupplierDAO.Instance.UpdateSupplier(supplierID, supplierName, phone, email, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating supplier: {ex.Message}");
                return false;
            }
        }

        // Method to delete a supplier by ID
        public bool DeleteSupplier(int supplierID)
        {
            try
            {
                return SupplierDAO.Instance.DeleteSupplier(supplierID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting supplier: {ex.Message}");
                return false;
            }
        }

        public List<SupplierDTO> SearchSupplierByName(string name)
        {
            return SupplierDAO.Instance.SearchSupplierByName(name);
        }

    }
}
