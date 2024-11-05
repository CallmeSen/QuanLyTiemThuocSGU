using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class ProductCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // Optional constructor
        public ProductCategoryDTO(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

        public ProductCategoryDTO() { }

        public override string ToString()
        {
            return $"CategoryID: {CategoryID}, CategoryName: {CategoryName}";
        }
    }
}

