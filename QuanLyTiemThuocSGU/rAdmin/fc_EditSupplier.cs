using QuanLyThuVienSGU_Winform.DAO;
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
        }

        private void ReloadStaffGridView()
        {
            LoadSupplierList(); // Reload DataGridView with updated data
        }

        void LoadSupplierList()
        {
            string query = "EXEC dbo.USP_GetAllSuppliers ";

            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_ChinhSuaTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void AddStaffForm_StaffAdded(object sender, EventArgs e)
        {
            LoadSupplierList(); // Reload the DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_Addsupplier f = new fc_Addsupplier();
        
            f.ShowDialog();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
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
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierList(); // Refresh DataGridView
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
                    int SupplierID = Convert.ToInt32(selectedRow.Cells["SupplierID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
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
    }
}
