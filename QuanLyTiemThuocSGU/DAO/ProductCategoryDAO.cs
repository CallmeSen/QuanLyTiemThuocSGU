using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class ProductCategoryDAO
    {
        // Singleton instance
        private static ProductCategoryDAO instance;
        public static ProductCategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductCategoryDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private ProductCategoryDAO() { }

        // Method to add a new product category
        public bool AddCategory(string categoryName)
        {
            string query = "EXEC USP_AddCategory @CategoryName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { categoryName });
            return result > 0;
        }

        // Method to retrieve all product categories
        public List<ProductCategoryDTO> GetAllCategories()
        {
            List<ProductCategoryDTO> categories = new List<ProductCategoryDTO>();
            string query = "EXEC USP_GetAllCategories";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                categories.Add(MapDataRowToProductCategory(row));
            }
            return categories;
        }

        // Method to update a product category
        public bool UpdateCategory(int categoryID, string categoryName)
        {
            string query = "EXEC USP_UpdateCategory @CategoryID, @CategoryName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { categoryID, categoryName });
            return result > 0;
        }

        // Method to delete a product category by ID
        public bool DeleteCategory(int categoryID)
        {
            string query = "EXEC USP_DeleteCategory @CategoryID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { categoryID });
            return result > 0;
        }

        // Private helper method to map DataRow to ProductCategoryDTO
        private ProductCategoryDTO MapDataRowToProductCategory(DataRow row)
        {
            return new ProductCategoryDTO
            {
                CategoryID = Convert.ToInt32(row["CategoryID"]),
                CategoryName = row["CategoryName"].ToString()
            };
        }
    }
}

