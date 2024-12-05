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
using System.Drawing.Printing;


namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_Dashboard : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private int currentRowIndex = 0; // Track the current row index for pagination

        public fc_Dashboard()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        #region Functions
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yPos = 100; // Vị trí dọc bắt đầu
            int leftMargin = e.MarginBounds.Left - 20; // Nhích bảng sang trái
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);
            int itemsPerPage = 20; // Số dòng tối đa trên một trang
            int rowsPrinted = 0; // Đếm số dòng đã in trên trang
            decimal totalAmount = 0; // Biến tính tổng tiền

            // Định nghĩa độ rộng từng cột
            int colOrderIDWidth = 80;
            int colDateWidth = 120;
            int colCustomerWidth = 200;
            int colEmployeeWidth = 250;
            int colTotalWidth = 120;

            // Tiêu đề báo cáo
            string headerTitle = "BÁO CÁO THỐNG KÊ";
            SizeF titleSize = e.Graphics.MeasureString(headerTitle, headerFont);
            e.Graphics.DrawString(headerTitle, headerFont, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, yPos);
            yPos += 50;

            // Phạm vi thời gian
            e.Graphics.DrawString($"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Tiêu đề cột
            int colStartX = leftMargin;
            e.Graphics.DrawString("Mã Đơn", boldFont, Brushes.Black, colStartX, yPos);
            colStartX += colOrderIDWidth;
            e.Graphics.DrawString("Ngày", boldFont, Brushes.Black, colStartX, yPos);
            colStartX += colDateWidth;
            e.Graphics.DrawString("Khách Hàng", boldFont, Brushes.Black, colStartX, yPos);
            colStartX += colCustomerWidth;
            e.Graphics.DrawString("Nhân Viên", boldFont, Brushes.Black, colStartX, yPos);
            colStartX += colEmployeeWidth;
            e.Graphics.DrawString("Tổng Tiền", boldFont, Brushes.Black, colStartX, yPos);
            yPos += 30;

            // In từng dòng dữ liệu
            while (currentRowIndex < lsvThongKe.Items.Count && rowsPrinted < itemsPerPage)
            {
                colStartX = leftMargin;

                e.Graphics.DrawString(lsvThongKe.Items[currentRowIndex].SubItems[0].Text, regularFont, Brushes.Black, colStartX, yPos);
                colStartX += colOrderIDWidth;
                e.Graphics.DrawString(lsvThongKe.Items[currentRowIndex].SubItems[1].Text, regularFont, Brushes.Black, colStartX, yPos);
                colStartX += colDateWidth;
                e.Graphics.DrawString(lsvThongKe.Items[currentRowIndex].SubItems[2].Text, regularFont, Brushes.Black, colStartX, yPos);
                colStartX += colCustomerWidth;
                e.Graphics.DrawString(lsvThongKe.Items[currentRowIndex].SubItems[3].Text, regularFont, Brushes.Black, colStartX, yPos);
                colStartX += colEmployeeWidth;
                e.Graphics.DrawString(lsvThongKe.Items[currentRowIndex].SubItems[4].Text, regularFont, Brushes.Black, colStartX, yPos);

                // Tính tổng tiền
                string amountText = lsvThongKe.Items[currentRowIndex].SubItems[4].Text.Replace("₫", "").Replace(".", "").Trim();
                if (decimal.TryParse(amountText, out decimal itemAmount))
                {
                    totalAmount += itemAmount;
                }
                 
                yPos += 30; // Khoảng cách giữa các dòng
                currentRowIndex++;
                rowsPrinted++;
            }

            // Hiển thị tổng tiền trên trang cuối
            if (!e.HasMorePages && currentRowIndex >= lsvThongKe.Items.Count)
            {
                yPos += 20; // Thêm khoảng cách trước khi in tổng tiền
                e.Graphics.DrawString($"Tổng Tiền: {totalAmount.ToString("#,##0").Replace(",", ".")} ₫", boldFont, Brushes.Black, leftMargin, yPos);
            }

            // Kiểm tra nếu cần thêm trang
            if (currentRowIndex < lsvThongKe.Items.Count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                currentRowIndex = 0; // Đặt lại chỉ số dòng cho lần in tiếp theo
            }

        }


        #endregion

        #region Events
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
        private void BtnInThongKe_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        #endregion
    }
}
