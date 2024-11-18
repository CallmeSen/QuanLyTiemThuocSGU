using QuanLyThuVienSGU_Winform.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.Charts.WinForms;


namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_Dashboard : Form
    {
        public fc_Dashboard()
        {
            InitializeComponent();
            btnXacNhan.Click += BtnXacNhan_Click; // Event to fetch data
            btnInThongKe.Click += BtnInThongKe_Click; // Event to print statistics
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Get date range from DateTimePickers
                DateTime startDate = dtpTuNgay.Value.Date;
                DateTime endDate = dtpDenNgay.Value.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be after the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Fetch data using BLL
                DataTable orders = OrderBLL.Instance.GetOrdersByDateRange(startDate, endDate);

                // Populate ListView and Chart
                PopulateListView(orders);
                PopulateChart(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateListView(DataTable orders)
        {
            // Clear existing items
            lsvThongKe.Items.Clear();

            if (orders == null || orders.Rows.Count == 0)
            {
                MessageBox.Show("No orders found in the specified date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set the culture for Vietnamese Dong
            var culture = new System.Globalization.CultureInfo("vi-VN");

            foreach (DataRow row in orders.Rows)
            {
                // Create a new ListViewItem
                ListViewItem item = new ListViewItem(row["OrderID"].ToString());

                // Add subitems
                item.SubItems.Add(Convert.ToDateTime(row["OrderDate"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["CustomerName"].ToString());
                item.SubItems.Add(row["EmployeeName"].ToString());

                // Format TotalAmount in Vietnamese Dong (₫)
                decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);
                item.SubItems.Add(totalAmount.ToString("C0", culture)); // "C0" removes decimal places

                // Add the item to the ListView
                lsvThongKe.Items.Add(item);
            }
        }


        private void PopulateChart(DataTable orders)
        {
            // Clear existing datasets
            btkThongKe.Datasets.Clear();

            if (orders.Rows.Count == 0)
            {
                MessageBox.Show("No orders found in the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a line dataset
            var lineDataset = new Guna.Charts.WinForms.GunaLineDataset
            {
                Label = "Total Sales"
            };

            foreach (DataRow row in orders.Rows)
            {
                string orderDate = Convert.ToDateTime(row["OrderDate"]).ToString("yyyy-MM-dd");
                double totalAmount = Convert.ToDouble(row["TotalAmount"]);

                // Add data points to the dataset
                lineDataset.DataPoints.Add(orderDate, totalAmount);
            }

            // Add dataset to the chart
            btkThongKe.Datasets.Add(lineDataset);

            // Refresh chart
            btkThongKe.Update();
        }


        private void BtnInThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality is not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
