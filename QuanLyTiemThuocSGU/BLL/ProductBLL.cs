using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class ProductBLL
    {
        // Singleton instance
        private static ProductBLL instance;
        public static ProductBLL Instance
        {
            get
            {
                if (instance == null) instance = new ProductBLL();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private ProductBLL() { }

        public List<ProductDTO> SearchProductByName(string name)
        {
            return ProductDAO.Instance.SearchProductByName(name);
        }
        public string GetCategoryByProductId(int productId)
        {
            return ProductDAO.Instance.GetCategoryByProductId(productId);
        }

        // Method to add a new product
        public bool AddProduct(string productName, int categoryID, int supplierID, decimal price, int quantityInStock, DateTime? expirationDate)
        {
            try
            {
                return ProductDAO.Instance.AddProduct(productName, categoryID, supplierID, price, quantityInStock, expirationDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
                return false;
            }
        }

        // Method to retrieve all products
        public List<ProductDTO> GetAllProducts()
        {
            try
            {
                return ProductDAO.Instance.GetAllProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving products: {ex.Message}");
                return new List<ProductDTO>();
            }
        }

        // Method to update a product
        public bool UpdateProduct(int productID, string productName, int categoryID, int supplierID, decimal price, int quantityInStock, DateTime? expirationDate)
        {
            try
            {
                return ProductDAO.Instance.UpdateProduct(productID, productName, categoryID, supplierID, price, quantityInStock, expirationDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product: {ex.Message}");
                return false;
            }
        }

        // Method to delete a product by ID
        public bool DeleteProduct(int productID)
        {
            try
            {
                return ProductDAO.Instance.DeleteProduct(productID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting product: {ex.Message}");
                return false;
            }
        }

        //Method to retrieve the expired medicines
        public List<ProductDTO> GetExpiredMedicines()
        {
            try
            {
                List<ProductDTO> expiredMedicines = new List<ProductDTO>();

                foreach (ProductDTO product in ProductDAO.Instance.GetExpiredMedicines())
                {
                    expiredMedicines.Add(product);
                }

                return expiredMedicines;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving : {ex.Message}");
                return new List<ProductDTO>();
            }
        }

        public List<ProductDTO> GetLowStockMedicines(int threshold)
        {
            return ProductDAO.Instance.GetLowStockMedicines(threshold);
        }

    }
}

