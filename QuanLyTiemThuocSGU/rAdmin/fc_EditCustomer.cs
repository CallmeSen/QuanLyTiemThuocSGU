using QuanLyThuVienSGU_Winform.BLL;
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
    public partial class fc_EditCustomer : Form
    {
        public fc_EditCustomer()
        {
            InitializeComponent();
            LoadCustomerList();
            if (dataGridView_ChinhSuaTaiKhoan.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[0];
                PopulateDetails(selectedRow);
            }
        }

        private void LoadCustomerList()
        {
            List<CustomerDTO> customers = CustomerBLL.Instance.GetAllCustomers(); // Fetch all customers
            dataGridView_ChinhSuaTaiKhoan.DataSource = null;
            dataGridView_ChinhSuaTaiKhoan.DataSource = customers;

            // Optional: Auto resize columns
            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void CustomerDetails(DataGridViewRow selectedRow)
        {
            // Populate details into the controls
            txbID.Text = selectedRow.Cells["EmployeeID"].Value?.ToString();
            txbHoTen.Text = selectedRow.Cells["FullName"].Value?.ToString();
            txbSoDienThoai.Text = selectedRow.Cells["Phone"].Value?.ToString();
            txbEmail.Text = selectedRow.Cells["Email"].Value?.ToString();

        }

        private void SearchCustomer()
        {
            string searchName = txbSearch.Text.Trim();
            List<CustomerDTO> customers = CustomerBLL.Instance.SearchCustomerByName(searchName);

            // Update DataGridView
            dataGridView_ChinhSuaTaiKhoan.DataSource = null;
            dataGridView_ChinhSuaTaiKhoan.DataSource = customers;

            // Optional: Resize columns for better visibility
            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #region Events

        private void dataGridView_ChinhSuaTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[e.RowIndex];
                PopulateDetails(selectedRow);
            }
        }

        private void PopulateDetails(DataGridViewRow selectedRow)
        {
            // Assign values to textboxes
            txbID.Text = selectedRow.Cells["CustomerID"].Value?.ToString() ?? string.Empty;
            txbHoTen.Text = selectedRow.Cells["FullName"].Value?.ToString() ?? string.Empty;
            txbSoDienThoai.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
            txbEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
            txbAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
        }


        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer(); // Call the search method
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_AddCustomer f = new fc_AddCustomer();
            
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {
                    string fullName = txbHoTen.Text;
                    string phone = txbSoDienThoai.Text;
                    string email = txbEmail.Text;
                    string address = txbAddress.Text;
                   

                    // Call the new UpdateStaff method
                    bool isUpdated = CustomerDAO.Instance.UpdateCustomer( 21,fullName, phone, email,address);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomerList(); // Refresh DataGridView
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
                            LoadCustomerList(); // Refresh DataGridView
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
        #endregion
    }
}
