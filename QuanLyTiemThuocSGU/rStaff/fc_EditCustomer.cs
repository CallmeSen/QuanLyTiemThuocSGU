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

        #region Functions
        private void LoadCustomerList()
        {
            List<CustomerDTO> customers = CustomerBLL.Instance.GetAllCustomers(); // Fetch all customers
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
        #endregion
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
            f.CustomerAdded += LoadCustomerList; // Subscribe to the event
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch updated data from textboxes
                int customerID = int.Parse(txbID.Text.Trim());
                string fullName = string.IsNullOrWhiteSpace(txbHoTen.Text) ? null : txbHoTen.Text.Trim();
                string phone = string.IsNullOrWhiteSpace(txbSoDienThoai.Text) ? null : txbSoDienThoai.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txbEmail.Text) ? null : txbEmail.Text.Trim();
                string address = string.IsNullOrWhiteSpace(txbAddress.Text) ? null : txbAddress.Text.Trim();

                // Call the BLL method to update customer information
                bool isUpdated = CustomerBLL.Instance.UpdateCustomer(customerID, fullName, phone, email, address);

                if (isUpdated)
                {
                    MessageBox.Show("Customer information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerList(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update customer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.SelectedRows[0];

                    // Fetch the CustomerID from the selected row
                    int customerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                    // Confirm deletion
                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa khách hàng này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Call the BLL method to delete the customer
                        bool isDeleted = CustomerBLL.Instance.DeleteCustomer(customerID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomerList(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
