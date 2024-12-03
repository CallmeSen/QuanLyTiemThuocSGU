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
    public partial class fc_EditCategory : Form
    {
        public fc_EditCategory()
        {
            InitializeComponent();
        }

        void LoadCategoryList()
        {
            string query = "EXEC dbo.USP_GetCategoryByID ";

            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_ChinhSuaTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void dataGridView_ChinhSuaTaiKhoan_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaTaiKhoan.Rows[e.RowIndex];
                CategoryDetail(selectedRow);
            }
        }

        private void CategoryDetail(DataGridViewRow selectedRow)
        {
            // Populate details into the controls
            txbIDCapNhat.Text = selectedRow.Cells["EmployeeID"].Value?.ToString();
            txbHoTen.Text = selectedRow.Cells["FullName"].Value?.ToString();

        }


        private void AddStaffForm_StaffAdded(object sender, EventArgs e)
        {
            LoadCategoryList(); // Reload the DataGridView
        }


        #region Events


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_AddCategory f = new fc_AddCategory();

            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_ChinhSuaTaiKhoan.SelectedRows.Count > 0)
                {



                    int ID = int.Parse(txbIDCapNhat.Text);
                    string name = txbHoTen.Text;
                


                    // Call the new UpdateStaff method
                    bool isUpdated = ProductCategoryDAO.Instance.UpdateCategory(ID,name);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryList(); 
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
                    int CategoryID = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool isDeleted = ProductCategoryDAO.Instance.DeleteCategory(CategoryID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCategoryList(); // Refresh DataGridView
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            fc_AddCategory f = new fc_AddCategory();
            f.Show();
        }
    }
}
