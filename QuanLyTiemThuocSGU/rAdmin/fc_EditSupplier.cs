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
    public partial class fc_EditSupplier : Form
    {
        public fc_EditSupplier()
        {
            InitializeComponent();
            LoadSupplierList();
            if (dataGridView_ChinhSuaNhaCungCap.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaNhaCungCap.Rows[0];
                PopulateDetails(selectedRow); // Pass the first row index
            }
        }

        #region Functions

        void LoadSupplierList()
        {
            List<SupplierDTO> suppliers = SupplierDAO.Instance.GetAllSuppliers();
            dataGridView_ChinhSuaNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_ChinhSuaNhaCungCap.DataSource = suppliers;
        }

        private void PopulateDetails(DataGridViewRow selectedRow)
        {
            // Assign values to textboxes
            txbID.Text = selectedRow.Cells["SupplierID"].Value?.ToString() ?? string.Empty;
            txbTen.Text = selectedRow.Cells["SupplierName"].Value?.ToString() ?? string.Empty;
            txbPhone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
            txbEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
            txbAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
        }
        #endregion

        #region Events
        private void dataGridView_ChinhSuaTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is valid (not a header or empty row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaNhaCungCap.Rows[e.RowIndex];
                PopulateDetails(selectedRow);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_Addsupplier f = new fc_Addsupplier();
            f.SupplierAdded += LoadSupplierList;
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaNhaCungCap.SelectedRows.Count > 0)
                {
                    int SupplierID = int.Parse(txbID.Text);
                    string fullName = txbTen.Text;
                    string phone = txbPhone.Text;
                    string email = txbEmail.Text;
                    string address = txbAddress.Text;

                    // Call the new UpdateStaff method
                    bool isUpdated = SupplierDAO.Instance.UpdateSupplier(SupplierID, fullName,phone, email,address);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierList(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (dataGridView_ChinhSuaNhaCungCap.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_ChinhSuaNhaCungCap.SelectedRows[0];
                    int SupplierID = Convert.ToInt32(selectedRow.Cells["SupplierID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhà cung cấp này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool isDeleted = SupplierDAO.Instance.DeleteSupplier(SupplierID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSupplierList(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhà cung cấp thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
