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

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_SellMed : Form
    {
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
            //else
            {
                MessageBox.Show("Please select a customer.");
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yPos = 100;
            int leftMargin = e.MarginBounds.Left;
            Font printFont = new Font("Arial", 12);

            e.Graphics.DrawString("Hóa Đơn Khách Hàng", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            yPos += 40;

            e.Graphics.DrawString("Họ Tên: " + txtCustomerName.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString("Số Điện Thoại: " + txtCustomerContact.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 40;

            e.Graphics.DrawString("Chi Tiết Đơn Hàng:", printFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;

            foreach (ListViewItem item in lsHoaDonMua.Items)
            {
                string itemText = $"{item.SubItems[0].Text} - Số lượng: {item.SubItems[1].Text} - Giá: {item.SubItems[3].Text}";
                e.Graphics.DrawString(itemText, printFont, Brushes.Black, leftMargin, yPos);
                yPos += 25;
            }

            yPos += 20;

            e.Graphics.DrawString("Tổng Cộng: " + txbTotal.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
        }

        public int InsertOrder(int customerID, int employeeID, decimal totalAmount)
        {
            string query = "INSERT INTO Orders ( CustomerID , EmployeeID , OrderDate , TotalAmount ) " +
                           "OUTPUT INSERTED.OrderID " +
                           "VALUES ( @CustomerID , @EmployeeID , GETDATE() , @TotalAmount )";

            // Execute the query and return the generated OrderID
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { customerID, employeeID, totalAmount });
        }

        public void InsertOrderInfo(int orderID, int productID, int quantity, decimal priceAtPurchase)
        {
            string query = "INSERT INTO OrderInfo (OrderID, ProductID, Quantity, PriceAtPurchase) " +
                           "VALUES ( @OrderID , @ProductID , @Quantity , @PriceAtPurchase )";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderID, productID, quantity, priceAtPurchase });
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

            if (customerID == -1){
                return;
            }
            else //(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            int employeeID = CurrentEmployeeID;  
            decimal totalAmount = UpdateTotalAmount();

            // Insert order and get the generated OrderID
            int orderID = InsertOrder(customerID, employeeID, totalAmount);

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
