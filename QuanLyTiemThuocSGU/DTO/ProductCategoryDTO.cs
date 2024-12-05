using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class ProductCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Constructor
        public ProductCategoryDTO(DataRow row)
        {
            CategoryID = Convert.ToInt32(row["CategoryID"]);
            CategoryName = row["CategoryName"].ToString();
        }

        public ProductCategoryDTO() { }

        public override string ToString()
        {
            return $"CategoryID: {CategoryID}, CategoryName: {CategoryName}";
        }
    }
}

