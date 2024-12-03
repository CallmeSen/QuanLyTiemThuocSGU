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

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_EditMed : Form
    {
        public event EventHandler MedicineAdded;

        public fc_EditMed()
        {
            InitializeComponent();
            LoadSuppliers(); // Load data for cbNhaCungCap
            LoadCategories(); // Load data for cbNhomThuoc
            LoadMedList(); // Load products into the DataGridView

            // Automatically populate controls with the first row's data
            if (dataGridView_ChinhSuaThuoc.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaThuoc.Rows[0];
                PopulateDetails(selectedRow); // Pass the first row index
            }
        }

        #region Functions
        private void DataGridView_ChinhSuaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the selected row index is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ChinhSuaThuoc.Rows[e.RowIndex];
                PopulateDetails(selectedRow);
            }
        }
        private void LoadCategories()
        {
            string query = "EXEC USP_GetAllCategories"; // Replace with your stored procedure or query
            DataTable categories = DataProvider.Instance.ExecuteQuery(query);

            cbNhomThuoc.DataSource = categories;
            cbNhomThuoc.DisplayMember = "CategoryName"; // Replace with your category name column
            cbNhomThuoc.ValueMember = "CategoryID"; // Replace with your category ID column
        }

        private void LoadSuppliers()
        {
            string query = "EXEC USP_GetAllSuppliers"; // Replace with your stored procedure or query
            DataTable suppliers = DataProvider.Instance.ExecuteQuery(query);

            cbNhaCungCap.DataSource = suppliers;
            cbNhaCungCap.DisplayMember = "SupplierName"; // Replace with your supplier name column
            cbNhaCungCap.ValueMember = "SupplierID"; // Replace with your supplier ID column
        }

        void LoadMedList()
        {
            dataGridView_ChinhSuaThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string query = "EXEC USP_GetAllProducts";
            dataGridView_ChinhSuaThuoc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void PopulateDetails(DataGridViewRow selectedRow)
        {
            // Assign values to textboxes
            txbIDCapNhat.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? string.Empty;
            txbTenThuoc.Text = selectedRow.Cells["ProductName"].Value?.ToString() ?? string.Empty;
            txbSoLuong.Text = selectedRow.Cells["QuantityInStock"].Value != DBNull.Value
                ? selectedRow.Cells["QuantityInStock"].Value.ToString()
                : string.Empty;
            txbGiaThuoc.Text = selectedRow.Cells["Price"].Value != DBNull.Value
                ? selectedRow.Cells["Price"].Value.ToString()
                : string.Empty;

            // Assign values to ComboBoxes
            cbNhomThuoc.SelectedValue = selectedRow.Cells["CategoryID"].Value != DBNull.Value
                ? selectedRow.Cells["CategoryID"].Value
                : null;
            cbNhaCungCap.SelectedValue = selectedRow.Cells["SupplierID"].Value != DBNull.Value
                ? selectedRow.Cells["SupplierID"].Value
                : null;

            // Assign value to DateTimePicker
            if (selectedRow.Cells["ExpirationDate"].Value != DBNull.Value)
            {
                DTP_NgayHetHan.Value = Convert.ToDateTime(selectedRow.Cells["ExpirationDate"].Value);
            }
            else
            {
                DTP_NgayHetHan.Value = DateTime.Now; // Default to current date
            }
        }

        private void AddMedForm_MedicineAdded(object sender, EventArgs e)
        {
            LoadMedList(); // Reload the DataGridView
        }

        private void SearchMedicine()
        {
            string searchName = txbSearch.Text.Trim();
            List<ProductDTO> medicines = ProductBLL.Instance.SearchProductByName(searchName);

            dataGridView_ChinhSuaThuoc.DataSource = null;

            foreach (var medicine in medicines)
            {
                dataGridView_ChinhSuaThuoc.DataSource = medicines;
            }
        }

        #endregion

        #region Events

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMedicine();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fc_AddMed f = new fc_AddMed();
            f.MedicineAdded += AddMedForm_MedicineAdded;
            f.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect updated values from the controls
                int productID = int.Parse(txbIDCapNhat.Text);
                string productName = txbTenThuoc.Text;
                int categoryID = (int)cbNhomThuoc.SelectedValue;
                int supplierID = (int)cbNhaCungCap.SelectedValue;
                decimal price = decimal.Parse(txbGiaThuoc.Text);
                int quantityInStock = int.Parse(txbSoLuong.Text);
                DateTime? expirationDate = DTP_NgayHetHan.Checked ? DTP_NgayHetHan.Value : (DateTime?)null;

                // Call the UpdateProduct method
                bool isUpdated = ProductDAO.Instance.UpdateProduct(productID, productName, categoryID, supplierID, price, quantityInStock, expirationDate);

                if (isUpdated)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the product list to reflect the changes
                    LoadMedList();
                }
                else
                {
                    MessageBox.Show("Failed to update the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn hay không
                if (dataGridView_ChinhSuaThuoc.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedRow = dataGridView_ChinhSuaThuoc.SelectedRows[0];

                    // Lấy `ProductID` từ dòng được chọn
                    int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                    // Hiển thị hộp thoại xác nhận xóa
                    DialogResult dialogResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa sản phẩm này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Gọi phương thức DAO để xóa sản phẩm
                        bool isDeleted = ProductDAO.Instance.DeleteProduct(productID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMedList(); // Cập nhật lại danh sách sản phẩm
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
