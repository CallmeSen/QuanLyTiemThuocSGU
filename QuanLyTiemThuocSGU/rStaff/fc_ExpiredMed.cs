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

namespace QuanLyThuVienSGU_Winform.rStaff
{
    public partial class fc_ExpiredMed : Form
    {
        public fc_ExpiredMed()
        {
            InitializeComponent();
            LoadExpiredMedicines();
        }

        private void LoadExpiredMedicines()
        {
            DataTable expiredMeds = GetExpiredMedicines(); // Fetch expired medicines

            listViewExpiredMeds.Items.Clear();

            foreach (DataRow row in expiredMeds.Rows)
            {
                // Create a new ListViewItem
                ListViewItem item = new ListViewItem(row["ProductName"].ToString());
                item.SubItems.Add(row["CategoryName"].ToString());
                item.SubItems.Add(row["SupplierName"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ExpirationDate"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["QuantityInStock"].ToString());

                listViewExpiredMeds.Items.Add(item);
            }

            foreach (ColumnHeader column in listViewExpiredMeds.Columns)
            {
                column.Width = -2; // -2 means auto-size to fit the content
            }
        }

        private DataTable GetExpiredMedicines()
        {
            string query = "EXEC USP_GetExpiredMedicines"; // Call the stored procedure
            return DataProvider.Instance.ExecuteQuery(query); // Assuming DataProvider is implemented
        }
    }
}
