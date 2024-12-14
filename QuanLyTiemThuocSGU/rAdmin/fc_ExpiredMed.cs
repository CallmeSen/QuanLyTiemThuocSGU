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

namespace QuanLyThuVienSGU_Winform.rStaff
{
    public partial class fc_ExpiredMed : Form
    {
        public fc_ExpiredMed()
        {
            InitializeComponent();
            LoadExpiredMedicines();
            LoadLowStockMedicines(100);
        }

        private void LoadExpiredMedicines()
        {
            try
            {
                List<ProductDTO> expiredMeds = ProductBLL.Instance.GetExpiredMedicines();

                // Bind data to DataGridView
                dataGridView_DanhSachThuocHetHan.DataSource = expiredMeds;
                dataGridView_DanhSachThuocHetHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Hide unwanted columns
                dataGridView_DanhSachThuocHetHan.Columns["ProductID"].Visible = false;
                dataGridView_DanhSachThuocHetHan.Columns["CategoryID"].Visible = false;
                dataGridView_DanhSachThuocHetHan.Columns["SupplierID"].Visible = false;
                dataGridView_DanhSachThuocHetHan.Columns["Price"].Visible = false;

                // Refresh the DataGridView
                dataGridView_DanhSachThuocHetHan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expired medicines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLowStockMedicines(int threshold)
        {
            try
            {
                // Fetch low-stock medicines
                List<ProductDTO> lowStockMeds = ProductBLL.Instance.GetLowStockMedicines(threshold);

                // Bind data to DataGridView
                dataGridView_DanhSachThuocSapHet.DataSource = lowStockMeds;
                dataGridView_DanhSachThuocSapHet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Hide unwanted columns
                dataGridView_DanhSachThuocSapHet.Columns["CategoryID"].Visible = false;
                dataGridView_DanhSachThuocSapHet.Columns["SupplierID"].Visible = false;
                dataGridView_DanhSachThuocSapHet.Columns["ExpirationDate"].Visible = false;
                dataGridView_DanhSachThuocSapHet.Columns["Price"].Visible = false;

                // Refresh DataGridView
                dataGridView_DanhSachThuocSapHet.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading low stock medicines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
