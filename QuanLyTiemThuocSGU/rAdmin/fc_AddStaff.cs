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
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThuVienSGU_Winform.rAdmin
{
    public partial class fc_AddStaff : Form
    {

        public event EventHandler StaffAdded;

        public fc_AddStaff()
        {
            InitializeComponent();
            LoadGenderComboBox();
            LoadRoleComboBox();
        }

        private void OnStaffAdded()
        {
            StaffAdded?.Invoke(this, EventArgs.Empty);
        }

        private void LoadGenderComboBox()
        {
            string query = "SELECT DISTINCT Gender FROM Employees ";
            DataTable genders = DataProvider.Instance.ExecuteQuery(query);

            cmbGioiTinh.DataSource = genders;
            cmbGioiTinh.DisplayMember = "Gender";
            cmbGioiTinh.ValueMember = "Gender"; // Nếu Gender không phải là cột ID
            cmbGioiTinh.SelectedIndex = -1; // Để không chọn mặc định
        }

        private void LoadRoleComboBox()
        {
            string query = "SELECT DISTINCT Role FROM Employees ";
            DataTable roles = DataProvider.Instance.ExecuteQuery(query);

            cmbChucVu.DataSource = roles;
            cmbChucVu.DisplayMember = "Role";
            cmbChucVu.ValueMember = "Role"; // Nếu Role không phải là cột ID
            cmbChucVu.SelectedIndex = -1;
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các trường nhập liệu
                string fullName = txbTenNhanVien.Text;
                string gender = cmbGioiTinh.SelectedValue?.ToString();
                string role = cmbChucVu.SelectedValue?.ToString();
                string phone = txbSoDienThoai.Text;
                string email = txbEmail.Text;
                decimal salary = decimal.Parse(txbLuong.Text);
                DateTime hireDate = dtpNgayNhanViec.Value;

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng StaffInfoDTO
                StaffInfoDTO newStaff = new StaffInfoDTO
                {
                    FullName = fullName,
                    Gender = gender,
                    Role = role,
                    Phone = phone,
                    Email = email,
                    Salary = salary,
                    HireDate = hireDate
                };

                // Gọi phương thức DAO để thêm nhân viên
                bool isAdded = StaffInfoDAO.Instance.AddStaff(fullName, gender, role, phone, email, salary, hireDate);

                // Kiểm tra kết quả
                if (isAdded)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnStaffAdded();
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
