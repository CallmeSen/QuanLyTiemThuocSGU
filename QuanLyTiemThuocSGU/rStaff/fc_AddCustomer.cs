using QuanLyThuVienSGU_Winform.BLL;
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
        public event Action CustomerAdded;

        public fc_AddCustomer()
        {
            InitializeComponent();
        }

        #region Events
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the input fields
                string fullName = txbCustomerName.Text.Trim();
                string phone = txbSDT.Text.Trim();
                string email = txbEmail.Text.Trim();
                string address = txbAddress.Text.Trim();

                // Validate required fields
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call the BLL method to add the customer
                int customerID = CustomerBLL.Instance.AddCustomer(fullName, phone, email, address);

                if (customerID > 0)
                {
                    MessageBox.Show($"Thêm khách hàng thành công! Mã khách hàng: {customerID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trigger the CustomerAdded event
                    CustomerAdded?.Invoke();

                    this.Close(); // Close the form after successful addition
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
