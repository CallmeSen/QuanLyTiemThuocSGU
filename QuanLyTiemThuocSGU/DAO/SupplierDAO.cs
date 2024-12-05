using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class SupplierDAO
    {
        // Singleton instance
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null) instance = new SupplierDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private SupplierDAO() { }

        // Method to add a new supplier
        public bool AddSupplier(string supplierName, string phone, string email, string address)
        {
            string query = "EXEC USP_AddSupplier @SupplierName , @Phone , @Email , @Address";
            object[] parameters = { supplierName, phone, email, address };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to retrieve all suppliers
        public List<SupplierDTO> GetAllSuppliers()
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            string query = "EXEC USP_GetAllSuppliers";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                suppliers.Add(MapDataRowToSupplier(row));
            }
            return suppliers;
        }

        // Method to update a supplier's details
        public bool UpdateSupplier(int supplierID, string supplierName, string phone, string email, string address)
        {
            string query = "EXEC USP_UpdateSupplier @SupplierID , @SupplierName , @Phone , @Email , @Address";
            object[] parameters = { supplierID, supplierName, phone, email, address };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to delete a supplier by ID
        public bool DeleteSupplier(int supplierID)
        {
            string query = "EXEC USP_DeleteSupplier @SupplierID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { supplierID });
            return result > 0;
        }

        // Private helper method to map DataRow to SupplierDTO
        private SupplierDTO MapDataRowToSupplier(DataRow row)
        {
            return new SupplierDTO
            {
                SupplierID = Convert.ToInt32(row["SupplierID"]),
                SupplierName = row["SupplierName"].ToString(),
                Phone = row["Phone"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString()
            };
        }

        public List<SupplierDTO> SearchSupplierByName(string name)
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            string query = $"SELECT * FROM dbo.Suppliers WHERE dbo.fuConvertToUnsign1(SupplierName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{name}') + '%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                suppliers.Add(new SupplierDTO(row));
            }

            return suppliers;
        }

    }
}

