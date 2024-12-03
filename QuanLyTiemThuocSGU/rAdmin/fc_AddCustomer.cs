using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThuVienSGU_Winform.rAdmin
{
    public partial class fc_AddCustomer : Form
    {
        public fc_AddCustomer()
        {
            InitializeComponent();
        }

   
        private void btnThemNhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                string CustomerName = txbCustomerName.Text;
                string address = txbAddress.Text;
                string SDT = txbSDT.Text;
                string email = txbEmail.Text;




                if (string.IsNullOrWhiteSpace(CustomerName))
                {
                    MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Địa chỉ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(SDT))
                {
                    MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CustomerDTO newCustomer = new CustomerDTO
                {
                    FullName = CustomerName,
                    Phone = SDT,
                    Address = address,
                    Email = email

                };

                int isAdded = CustomerDAO.Instance.AddCustomer(CustomerName, SDT, address,email);

                // Kiểm tra kết quả
                if (isAdded == 1)
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
