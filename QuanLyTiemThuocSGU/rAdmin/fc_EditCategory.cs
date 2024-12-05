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
    public partial class fc_EditCategory : Form
    {
        public fc_EditCategory()
        {
            InitializeComponent();
            LoadCategoryList();
            if (dataGridView_ChinhSuaTaiKhoan.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[0];
                PopulateDetails(selectedRow);
            }
        }

        #region Functions

        private void LoadCategoryList()
        {
            try
            {
                List<ProductCategoryDTO> categories = ProductCategoryBLL.Instance.GetAllCategories();
                dataGridView_ChinhSuaTaiKhoan.DataSource = categories;
                dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView_ChinhSuaTaiKhoan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                txbIDCapNhat.Text = selectedRow.Cells["CategoryID"].Value?.ToString() ?? string.Empty;
                txbTenNhomThuoc.Text = selectedRow.Cells["CategoryName"].Value?.ToString() ?? string.Empty;
            }
        }
        #endregion

        #region Events

        private void dataGridView_ChinhSuaTaiKhoan_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[e.RowIndex];
                PopulateDetails(selectedRow);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_AddCategory f = new fc_AddCategory();
            f.CategoryAdded += LoadCategoryList;
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {
                    int ID = int.Parse(txbIDCapNhat.Text);
                    string name = txbTenNhomThuoc.Text;
                


                    // Call the new UpdateStaff method
                    bool isUpdated = ProductCategoryDAO.Instance.UpdateCategory(ID,name);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật tên nhóm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryList(); 
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tên nhóm thuốc thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tên nhóm thuốc để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    int CategoryID = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa tên nhóm thuốc này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool isDeleted = ProductCategoryDAO.Instance.DeleteCategory(CategoryID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa tên nhóm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCategoryList(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa tên nhóm thuốc thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tên nhóm thuốc để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
