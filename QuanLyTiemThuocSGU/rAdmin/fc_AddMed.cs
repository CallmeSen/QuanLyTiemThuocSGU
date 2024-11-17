using Guna.UI2.WinForms;
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

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_AddMed : Form
    {
        public event EventHandler MedicineAdded;
        private List<string> supplierList;
        public fc_AddMed()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadProductCategories();

        }
     
        private void OnMedicineAdded()
        {
            MedicineAdded?.Invoke(this, EventArgs.Empty);
        }

        private void LoadSuppliers()
        {
            string query = "EXEC USP_GetAllSuppliers"; // Replace with your stored procedure
            DataTable suppliers = DataProvider.Instance.ExecuteQuery(query);

            cmbNhaCungCap.DataSource = suppliers;
            cmbNhaCungCap.DisplayMember = "SupplierName"; // Column to display
            cmbNhaCungCap.ValueMember = "SupplierID"; // Column to use as value
            cmbNhaCungCap.SelectedIndex = -1; // Clear selection initially
        }

        // Load product category data into cmbNhomThuoc
        private void LoadProductCategories()
        {
            string query = "EXEC USP_GetAllCategories"; // Replace with your stored procedure
            DataTable categories = DataProvider.Instance.ExecuteQuery(query);

            cmbNhomThuoc.DataSource = categories;
            cmbNhomThuoc.DisplayMember = "CategoryName"; // Column to display
            cmbNhomThuoc.ValueMember = "CategoryID"; // Column to use as value
            cmbNhomThuoc.SelectedIndex = -1; // Clear selection initially
        }
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                string productName = txbTenThuoc.Text;
                decimal price = decimal.Parse(txbGiaThuoc.Text);
                int quantityInStock = int.Parse(txbSoLuong.Text);
                DateTime? expirationDate = dtpNgayHetHan.Checked ? dtpNgayHetHan.Value : (DateTime?)null;
                int supplierID = (int)cmbNhaCungCap.SelectedValue;
                int categoryID = (int)cmbNhomThuoc.SelectedValue;

                // Validate input
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Tên thuốc không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (price <= 0 || quantityInStock <= 0)
                {
                    MessageBox.Show("Giá và số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (supplierID <= 0 || categoryID <= 0)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp và nhóm thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call DAO method to add the product
                bool isSuccess = ProductDAO.Instance.AddProduct(productName, categoryID, supplierID, price, quantityInStock, expirationDate);

                if (isSuccess)
                {
                    MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnMedicineAdded();
                    this.Close(); // Close the form after successful addition
                }
                else
                {
                    MessageBox.Show("Thêm thuốc thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
