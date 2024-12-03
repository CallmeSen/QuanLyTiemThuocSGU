using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienSGU_Winform.rAdmin
{
    public partial class fc_AddCategory : Form
    {
        public fc_AddCategory()
        {
            InitializeComponent();
        }

        private void lbKhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                int id = Convert.ToInt32(txbCategoryId.Text);
                string CategoryName = txbCategoryName.Text;




                if (string.IsNullOrWhiteSpace(CategoryName))
                {
                    MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                ProductCategoryDTO newCustomer = new ProductCategoryDTO
                {
                    CategoryID = id,
                    CategoryName = CategoryName,
                 

                };

                bool isAdded = ProductCategoryDAO.Instance.AddCategory(CategoryName);

                // Kiểm tra kết quả
                if (isAdded == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
