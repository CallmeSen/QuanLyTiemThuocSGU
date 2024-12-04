using QuanLyThuVienSGU_Winform.BLL;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;
using QuanLyThuVienSGU_Winform.rAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_EditStaff : Form
    {
        public fc_EditStaff()
        {
            InitializeComponent();
            LoadEmployeeList();
            LoadGenderComboBox();
            LoadRoleComboBox();
            if (dataGridView_ChinhSuaTaiKhoan.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[0];
                PopulateDetails(selectedRow);
            }
        }

        #region Functions

        private void ReloadStaffGridView()
        {
            LoadEmployeeList(); // Reload DataGridView with updated data
        }

        void LoadEmployeeList()
        {
            List<StaffInfoDTO> employees = StaffInfoDAO.Instance.GetAllEmployees();
            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// chỉnh sửa kích thước của các cột
            dataGridView_ChinhSuaTaiKhoan.DataSource = employees;
        }

        private void LoadGenderComboBox()
        {
            string query = "SELECT DISTINCT Gender FROM Employees WHERE Gender IS NOT NULL";
            DataTable genders = DataProvider.Instance.ExecuteQuery(query);

            cbGioiTinh.DataSource = genders;
            cbGioiTinh.DisplayMember = "Gender";
            cbGioiTinh.ValueMember = "Gender"; // Nếu Gender không phải là cột ID
            cbGioiTinh.SelectedIndex = -1; // Để không chọn mặc định
        }

        private void LoadRoleComboBox()
        {
            string query = "SELECT DISTINCT Role FROM Employees WHERE Role IS NOT NULL";
            DataTable roles = DataProvider.Instance.ExecuteQuery(query);

            cbChucVu.DataSource = roles;
            cbChucVu.DisplayMember = "Role";
            cbChucVu.ValueMember = "Role"; // Nếu Role không phải là cột ID
            cbChucVu.SelectedIndex = -1;
        }

        private void DataGridView_ChinhSuaTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[e.RowIndex];
                PopulateDetails(selectedRow);
            }
        }

        private void PopulateDetails(DataGridViewRow selectedRow)
        {
            // Populate details into the controls
            txbIDCapNhat.Text = selectedRow.Cells["EmployeeID"].Value?.ToString();
            txbHoTen.Text = selectedRow.Cells["FullName"].Value?.ToString();
            cbGioiTinh.SelectedValue = selectedRow.Cells["Gender"].Value?.ToString();
            cbChucVu.SelectedValue = selectedRow.Cells["Role"].Value?.ToString();
            txbSoDienThoai.Text = selectedRow.Cells["Phone"].Value?.ToString();
            txbEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            txbLuong.Text = selectedRow.Cells["Salary"].Value?.ToString();

            // Populate DateTimePicker
            if (DateTime.TryParse(selectedRow.Cells["HireDate"].Value?.ToString(), out DateTime hireDate))
            {
                DTP_NgayNhanViec.Value = hireDate;
            }
        }

        private void AddStaffForm_StaffAdded(object sender, EventArgs e)
        {
            LoadEmployeeList(); // Reload the DataGridView
        }

        private void SearchEmployees()
        {
            string searchName = txbSearch.Text.Trim();
            List<StaffInfoDTO> employees = StaffInfoBLL.Instance.SearchProductByName(searchName);

            dataGridView_ChinhSuaTaiKhoan.DataSource = null;

            foreach (var medicine in employees)
            {
                dataGridView_ChinhSuaTaiKhoan.DataSource = employees;
            }
        }

        #endregion

        #region Events


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_AddStaff f = new fc_AddStaff();
            f.StaffAdded += AddStaffForm_StaffAdded;
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.SelectedRows[0];
                    int employeeID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool isDeleted = StaffInfoDAO.Instance.DeleteStaff(employeeID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployeeList(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {
                    int employeeID = int.Parse(txbIDCapNhat.Text);
                    string fullName = txbHoTen.Text;
                    string gender = cbGioiTinh.SelectedValue.ToString();
                    string role = cbChucVu.SelectedValue.ToString();
                    string phone = txbSoDienThoai.Text;
                    string email = txbEmail.Text;
                    decimal salary = decimal.Parse(txbLuong.Text);
                    DateTime hireDate = DTP_NgayNhanViec.Value;

                    // Call the new UpdateStaff method
                    bool isUpdated = StaffInfoDAO.Instance.UpdateStaff(employeeID, fullName, gender, role, phone, email, salary, hireDate);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeList(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEmployees();
        }
    }
}

