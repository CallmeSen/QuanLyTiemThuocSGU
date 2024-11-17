using QuanLyThuVienSGU_Winform.BLL;
using QuanLyThuVienSGU_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using System.Data.SqlClient;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_SellMed : Form
    {
        private int orderID;
        private int CurrentEmployeeID;
        private PrintDocument printDocument = new PrintDocument();
        public fc_SellMed(int employeeID)
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            this.CurrentEmployeeID = employeeID;

        }

        private int GetSelectedCustomerID()
        {
            if (lsDanhSachKhachHang.SelectedItems.Count > 0)
            {
                // Assuming CustomerID is stored in the first column
                return int.Parse(lsDanhSachKhachHang.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                return -1; // Return -1 or handle this case appropriately
            }
        }


        private void SearchMedicine()
        {
            string searchName = txbTimThuoc.Text.Trim();
            List<ProductDTO> medicines = ProductBLL.Instance.SearchProductByName(searchName);

            lsDanhSachThuoc.Items.Clear();

            foreach (var medicine in medicines)
            {
                ListViewItem item = new ListViewItem(medicine.ProductID.ToString());
                item.SubItems.Add(medicine.ProductName);
                item.SubItems.Add(medicine.QuantityInStock.ToString());
                item.SubItems.Add(medicine.Price.ToString("#,##0") + " ₫");

                lsDanhSachThuoc.Items.Add(item);
            }
        }

        private void SearchCustomerByPhone()
        {
            string phone = txbFindPN.Text.Trim();
            List<CustomerDTO> customers = CustomerBLL.Instance.SearchCustomerByPhone(phone);

            lsDanhSachKhachHang.Items.Clear(); // Clear previous results

            foreach (var customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.CustomerID.ToString());
                item.SubItems.Add(customer.FullName);
                item.SubItems.Add(customer.Phone);

                lsDanhSachKhachHang.Items.Add(item);
            }
        }

        private decimal UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ListViewItem item in lsHoaDonMua.Items)
            {
                string totalPriceText = Regex.Replace(item.SubItems[3].Text, @"[^\d.]", "");

                if (!string.IsNullOrEmpty(totalPriceText) && decimal.TryParse(totalPriceText, out decimal itemTotalPrice))
                {
                    totalAmount += itemTotalPrice;
                }
            }

            txbTongGia.Text = totalAmount.ToString("#,##0") + " ₫";
            return totalAmount;
        }

        private void CalculateFinalTotal()
        {
            decimal finalTotal = 0;

            foreach (ListViewItem item in lsHoaDonMua.Items)
            {
                // Ensure the item has enough sub-items and clean up the total text
                if (item.SubItems.Count > 3)
                {
                    string itemTotalText = Regex.Replace(item.SubItems[3].Text, @"[^\d.]", ""); // Keep only digits and decimal point

                    if (!string.IsNullOrEmpty(itemTotalText) && decimal.TryParse(itemTotalText, out decimal itemTotal))
                    {
                        finalTotal += itemTotal;
                    }
                }
            }

            txbTotal.Text = finalTotal.ToString("#,##0") + " ₫"; // Display as currency
        }

        private string GetEmployeeName(int employeeID)
        {
            StaffInfoBLL staffInfoBLL = new StaffInfoBLL();
            StaffInfoDTO employeeDetails = staffInfoBLL.GetStaffDetails(employeeID);
            return employeeDetails != null ? employeeDetails.FullName : "Unknown Employee";
        }

        public int InsertOrder(int customerID, int employeeID, decimal totalAmount)
        {
            string query = "INSERT INTO Orders ( CustomerID , EmployeeID , OrderDate , TotalAmount ) " +
                           "OUTPUT INSERTED.OrderID " +
                           "VALUES ( @CustomerID , @EmployeeID , GETDATE() , @TotalAmount )";

            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { customerID, employeeID, totalAmount });

        }

        public void InsertOrderInfo(int orderID, int productID, int quantity, decimal priceAtPurchase)
        {
            string query = "INSERT INTO OrderInfo (OrderID, ProductID, Quantity, PriceAtPurchase) " +
                           "VALUES ( @OrderID , @ProductID , @Quantity , @PriceAtPurchase )";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderID, productID, quantity, priceAtPurchase });
        }


        public int GetLatestOrderID()
        {
            string query = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
            object result = DataProvider.Instance.ExecuteScalar(query);

            return result != null ? Convert.ToInt32(result) : -1; // Return -1 if no orders exist
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int employeeID = CurrentEmployeeID;
            string employeeName = GetEmployeeName(employeeID);
            int latestOrderID = GetLatestOrderID();

            int yPos = 100;
            int leftMargin = e.MarginBounds.Left;
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);
            Font tableFont = new Font("Arial", 12);

            // Header title centered
            string headerTitle = "HÓA ĐƠN BÁN LẺ";
            SizeF titleSize = e.Graphics.MeasureString(headerTitle, headerFont);
            e.Graphics.DrawString(headerTitle, headerFont, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, yPos);
            yPos += 40;

            // Order information
            e.Graphics.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString($"Đơn hàng: {latestOrderID + 1}", boldFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString($"NV: {employeeID} – {employeeName}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString("KH: " + txtCustomerName.Text, regularFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString("ĐT: " + txtCustomerContact.Text, regularFont, Brushes.Black, leftMargin, yPos);
            yPos += 40;

            // Define table columns and row settings
            int tableStartX = leftMargin;
            int colWidthName = 250;
            int colWidthQuantity = 60;
            int colWidthPrice = 120;
            int colWidthTotal = 140;

            // Draw header row with centered text
            e.Graphics.DrawRectangle(Pens.Black, tableStartX, yPos, colWidthName, 25);
            e.Graphics.DrawString("Tên sản phẩm", boldFont, Brushes.Black,
                tableStartX + (colWidthName / 2) - (e.Graphics.MeasureString("Tên sản phẩm", boldFont).Width / 2), yPos + 5);

            e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName, yPos, colWidthQuantity, 25);
            e.Graphics.DrawString("SL", boldFont, Brushes.Black,
                tableStartX + colWidthName + (colWidthQuantity / 2) - (e.Graphics.MeasureString("SL", boldFont).Width / 2), yPos + 5);

            e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName + colWidthQuantity, yPos, colWidthPrice, 25);
            e.Graphics.DrawString("Đơn giá", boldFont, Brushes.Black,
                tableStartX + colWidthName + colWidthQuantity + (colWidthPrice / 2) - (e.Graphics.MeasureString("Đơn giá", boldFont).Width / 2), yPos + 5);

            e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName + colWidthQuantity + colWidthPrice, yPos, colWidthTotal, 25);
            e.Graphics.DrawString("Thành tiền", boldFont, Brushes.Black,
                tableStartX + colWidthName + colWidthQuantity + colWidthPrice + (colWidthTotal / 2) - (e.Graphics.MeasureString("Thành tiền", boldFont).Width / 2), yPos + 5);

            yPos += 25;

            // Table rows for each product with borders around each cell
            decimal finalTotal = 0;
            foreach (ListViewItem item in lsHoaDonMua.Items)
            {
                string productName = item.SubItems[0].Text;
                string quantity = item.SubItems[1].Text;
                string price = item.SubItems[2].Text;
                string total = item.SubItems[3].Text;

                // Draw each cell with borders
                e.Graphics.DrawRectangle(Pens.Black, tableStartX, yPos, colWidthName, 25);
                e.Graphics.DrawString(productName, tableFont, Brushes.Black, tableStartX + 5, yPos + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName, yPos, colWidthQuantity, 25);
                e.Graphics.DrawString(quantity, tableFont, Brushes.Black,
                    tableStartX + colWidthName + (colWidthQuantity / 2) - (e.Graphics.MeasureString(quantity, tableFont).Width / 2), yPos + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName + colWidthQuantity, yPos, colWidthPrice, 25);
                e.Graphics.DrawString(price, tableFont, Brushes.Black,
                    tableStartX + colWidthName + colWidthQuantity + (colWidthPrice / 2) - (e.Graphics.MeasureString(price, tableFont).Width / 2), yPos + 5);

                e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName + colWidthQuantity + colWidthPrice, yPos, colWidthTotal, 25);
                e.Graphics.DrawString(total, tableFont, Brushes.Black,
                    tableStartX + colWidthName + colWidthQuantity + colWidthPrice + colWidthTotal - e.Graphics.MeasureString(total, tableFont).Width - 5, yPos + 5);

                finalTotal += decimal.Parse(total.Replace(",", "").Replace("₫", "").Trim());
                yPos += 25;
            }

            // Draw the final total row with the same border layout and alignment
            e.Graphics.DrawRectangle(Pens.Black, tableStartX, yPos, colWidthName + colWidthQuantity + colWidthPrice, 25);
            e.Graphics.DrawString("Tổng tiền", boldFont, Brushes.Black,
                tableStartX + colWidthName + colWidthQuantity + colWidthPrice - e.Graphics.MeasureString("Tổng tiền", boldFont).Width - 5, yPos + 5);

            e.Graphics.DrawRectangle(Pens.Black, tableStartX + colWidthName + colWidthQuantity + colWidthPrice, yPos, colWidthTotal, 25);
            e.Graphics.DrawString(finalTotal.ToString("#,##0") + " ₫", boldFont, Brushes.Black,
                tableStartX + colWidthName + colWidthQuantity + colWidthPrice + colWidthTotal - e.Graphics.MeasureString(finalTotal.ToString("#,##0") + " ₫", boldFont).Width - 5, yPos + 5);
        }

        private void txbTimThuoc_TextChanged(object sender, EventArgs e)
        {
            SearchMedicine();
        }

        private void txbFindPN_TextChanged(object sender, EventArgs e)
        {
            SearchCustomerByPhone();
        }

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("txbQuantity_TextChanged triggered");

            // Remove any non-numeric characters from txbGiaThuoc.Text
            string priceText = Regex.Replace(txbGiaThuoc.Text, @"[^0-9]", ""); // Keep only digits
            string quantityText = Regex.Replace(txbSoLuong.Text, @"[^0-9]", ""); // Keep only digits

            // Try parsing the cleaned strings
            if (!string.IsNullOrEmpty(priceText) && !string.IsNullOrEmpty(quantityText) &&
                decimal.TryParse(priceText, out decimal price) && int.TryParse(quantityText, out int quantity))
            {
                decimal totalPrice = price * quantity;
                txbTongGia.Text = totalPrice.ToString("#,##0") + " ₫"; // Format with thousands separator and currency symbol
                Console.WriteLine($"Total Price Calculated: {txbTongGia.Text}");
            }
            else
            {
                txbTongGia.Text = string.Empty; // Clear total price if input is invalid or empty
                Console.WriteLine("Invalid input detected. Clearing txbTongGia.");
            }
        }

        private void lvDanhSachThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsDanhSachThuoc.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsDanhSachThuoc.SelectedItems[0];

                txbIDThuoc.Text = selectedItem.SubItems.Count > 0 ? selectedItem.SubItems[0].Text : "";
                txbTenThuoc.Text = selectedItem.SubItems.Count > 1 ? selectedItem.SubItems[1].Text : "";
                txbGiaThuoc.Text = selectedItem.SubItems.Count > 3 ? selectedItem.SubItems[3].Text : "";
                txbNhomThuoc.Text = selectedItem.SubItems.Count > 4 ? selectedItem.SubItems[4].Text : "";

                int productId = int.Parse(selectedItem.SubItems[0].Text);
                string categoryName = ProductBLL.Instance.GetCategoryByProductId(productId); // Fetch category
                txbNhomThuoc.Text = categoryName;
            }
        }

        private void lsDanhSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsDanhSachKhachHang.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lsDanhSachKhachHang.SelectedItems[0];

                // Assuming Customer Name is in the 1st column and Contact is in the 2nd column
                string customerName = selectedItem.SubItems[1].Text; // Adjust index if necessary
                string customerContact = selectedItem.SubItems[2].Text; // Adjust index if necessary

                // Display in the text boxes
                txtCustomerName.Text = customerName;
                txtCustomerContact.Text = customerContact;
            }
            else
            {
                // Clear the text boxes if no item is selected
                txtCustomerName.Text = string.Empty;
                txtCustomerContact.Text = string.Empty;
            }
        }


        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (lsHoaDonMua.SelectedItems.Count > 0)
            {
                lsHoaDonMua.Items.Remove(lsHoaDonMua.SelectedItems[0]);
                UpdateTotalAmount();
                CalculateFinalTotal(); // Recalculate the total after removing an item
            }
        }


        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (lsDanhSachThuoc.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsDanhSachThuoc.SelectedItems[0];
                string medID = selectedItem.SubItems[0].Text; // Product ID
                string medName = selectedItem.SubItems[1].Text; // Product Name

                // Clean the price to remove any non-numeric characters
                string medPriceText = Regex.Replace(selectedItem.SubItems[3].Text, @"[^\d.]", "");
                if (!decimal.TryParse(medPriceText, out decimal medPrice))
                {
                    MessageBox.Show("Invalid price format.");
                    return;
                }

                if (!int.TryParse(txbSoLuong.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity format.");
                    return;
                }

                decimal totalPrice = medPrice * quantity;

                // Populate the ListViewItem with the correct details
                ListViewItem orderItem = new ListViewItem(medName); // Set `Tên thuốc` to product name
                orderItem.SubItems.Add(quantity.ToString()); // Set quantity
                orderItem.SubItems.Add(medPrice.ToString("#,##0") + " ₫"); // Set price
                orderItem.SubItems.Add(totalPrice.ToString("#,##0") + " ₫"); // Set total price

                lsHoaDonMua.Items.Add(orderItem); // Add to order ListView

                // Update the grand total
                UpdateTotalAmount();
                CalculateFinalTotal();
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            int customerID = GetSelectedCustomerID();

            if (customerID == -1 && !string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtCustomerContact.Text))
            {
                string customerName = txtCustomerName.Text.Trim();
                string customerPhone = txtCustomerContact.Text.Trim();
                string customerEmail = string.Empty; // Can fetch from input if required
                string customerAddress = string.Empty; // Can fetch from input if required

                // Add the new customer and get the generated CustomerID
                customerID = CustomerBLL.Instance.AddCustomer(customerName, customerPhone, customerEmail, customerAddress);
                if (customerID == -1)
                {
                    MessageBox.Show("Failed to add new customer.");
                    return;
                }
            }

            // If no customer is selected or added, stop the process
            if (customerID == -1)
            {
                MessageBox.Show("Please select or enter a valid customer.");
                return;
            }
            else if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            int employeeID = CurrentEmployeeID;  
            decimal totalAmount = UpdateTotalAmount();

            // Insert order and get the generated OrderID
            orderID = InsertOrder(customerID, employeeID, totalAmount);

            foreach (ListViewItem item in lsHoaDonMua.Items)
            {
                string productName = item.SubItems[0].Text;
                int quantity = int.Parse(item.SubItems[1].Text);

                // Clean price text and parse
                string priceText = Regex.Replace(item.SubItems[3].Text, @"[^\d.]", "");
                decimal priceAtPurchase = decimal.Parse(priceText);

                // Get ProductID using ProductDAO
                int productID = ProductDAO.Instance.GetProductIDByName(productName);
                if (productID == -1)
                {
                    MessageBox.Show($"Product ID not found for product: {productName}");
                    continue; // Skip if ProductID not found
                }

                // Insert OrderInfo record for this item
                InsertOrderInfo(orderID, productID, quantity, priceAtPurchase);
            }
        }
    }
}
