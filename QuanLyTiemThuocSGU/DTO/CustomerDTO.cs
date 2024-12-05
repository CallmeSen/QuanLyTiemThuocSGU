using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Constructor
        public CustomerDTO(DataRow row)
        {
            CustomerID = Convert.ToInt32(row["CustomerID"]);
            FullName = row["FullName"].ToString();
            Phone = row["Phone"].ToString();
            Email = row["Email"].ToString();
            Address = row["Address"].ToString();
        }

        public CustomerDTO() { }

        public override string ToString()
        {
            return $"CustomerID: {CustomerID}, FullName: {FullName}, Phone: {Phone}, Email: {Email}, Address: {Address}";
        }
    }
}

