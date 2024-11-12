using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class ProductCategoryBLL
    {
        private static ProductCategoryBLL instance;
        public static ProductCategoryBLL Instance
        {
            get
            {
                if (instance == null) instance = new ProductCategoryBLL();
                return instance;
            }
            private set => instance = value;
        }

        private ProductCategoryBLL() { }

        public bool AddCategory(string categoryName)
        {
            try
            {
                return ProductCategoryDAO.Instance.AddCategory(categoryName);
            }
            catch (Exception ex) // kiem loi tuong tu nhu may BLL khac
            {
                Console.WriteLine($"Error adding category: {ex.Message}");
                return false;
            }
        }

        public List<ProductCategoryDTO> GetAllCategories()
        {
            try
            {
                return ProductCategoryDAO.Instance.GetAllCategories();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving categories: {ex.Message}");
                return new List<ProductCategoryDTO>();
            }
        }

        public bool UpdateCategory(int categoryID, string categoryName)
        {
            try
            {
                return ProductCategoryDAO.Instance.UpdateCategory(categoryID, categoryName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating category: {ex.Message}");
                return false;
            }
        }

        public bool DeleteCategory(int categoryID)
        {
            try
            {
                return ProductCategoryDAO.Instance.DeleteCategory(categoryID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting category: {ex.Message}");
                return false;
            }
        }
    }
}

