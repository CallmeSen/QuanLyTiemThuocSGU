namespace QuanLyThuVienSGU_Winform
{
    partial class fc_SellMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerateBill = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbTimThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbGiaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTongGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNhomThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbFindPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFindPN = new System.Windows.Forms.Label();
            this.lsDanhSachThuoc = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsDanhSachKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsHoaDonMua = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(800, 607);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "Tên khách hàng";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(353, 44);
            this.txtCustomerName.TabIndex = 27;
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerContact.DefaultText = "";
            this.txtCustomerContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerContact.Location = new System.Drawing.Point(800, 658);
            this.txtCustomerContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.PasswordChar = '\0';
            this.txtCustomerContact.PlaceholderText = "SĐT khách hàng";
            this.txtCustomerContact.SelectedText = "";
            this.txtCustomerContact.Size = new System.Drawing.Size(353, 44);
            this.txtCustomerContact.TabIndex = 28;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThuoc.BorderRadius = 8;
            this.btnThemThuoc.FillColor = System.Drawing.Color.Green;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(1451, 255);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(200, 55);
            this.btnThemThuoc.TabIndex = 30;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveMedicine.BorderRadius = 8;
            this.btnRemoveMedicine.FillColor = System.Drawing.Color.Red;
            this.btnRemoveMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMedicine.Location = new System.Drawing.Point(1243, 255);
            this.btnRemoveMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(200, 55);
            this.btnRemoveMedicine.TabIndex = 31;
            this.btnRemoveMedicine.Text = "Xóa Thuốc";
            this.btnRemoveMedicine.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1193, 614);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 23);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateBill.BorderRadius = 8;
            this.btnGenerateBill.FillColor = System.Drawing.Color.Blue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(1447, 647);
            this.btnGenerateBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(200, 55);
            this.btnGenerateBill.TabIndex = 35;
            this.btnGenerateBill.Text = "In Hóa đơn";
            this.btnGenerateBill.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(1263, 607);
            this.txbTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(383, 29);
            this.txbTotal.TabIndex = 36;
            // 
            // txbTimThuoc
            // 
            this.txbTimThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTimThuoc.DefaultText = "";
            this.txbTimThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTimThuoc.Location = new System.Drawing.Point(21, 44);
            this.txbTimThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTimThuoc.Name = "txbTimThuoc";
            this.txbTimThuoc.PasswordChar = '\0';
            this.txbTimThuoc.PlaceholderText = "Nhập tên thuốc";
            this.txbTimThuoc.SelectedText = "";
            this.txbTimThuoc.Size = new System.Drawing.Size(371, 44);
            this.txbTimThuoc.TabIndex = 37;
            this.txbTimThuoc.TextChanged += new System.EventHandler(this.txbTimThuoc_TextChanged);
            // 
            // txbIDThuoc
            // 
            this.txbIDThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDThuoc.DefaultText = "";
            this.txbIDThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbIDThuoc.Location = new System.Drawing.Point(800, 44);
            this.txbIDThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIDThuoc.Name = "txbIDThuoc";
            this.txbIDThuoc.PasswordChar = '\0';
            this.txbIDThuoc.PlaceholderText = "";
            this.txbIDThuoc.ReadOnly = true;
            this.txbIDThuoc.SelectedText = "";
            this.txbIDThuoc.Size = new System.Drawing.Size(400, 44);
            this.txbIDThuoc.TabIndex = 38;
            // 
            // txbTenThuoc
            // 
            this.txbTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenThuoc.DefaultText = "";
            this.txbTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTenThuoc.Location = new System.Drawing.Point(800, 123);
            this.txbTenThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.PasswordChar = '\0';
            this.txbTenThuoc.PlaceholderText = "";
            this.txbTenThuoc.ReadOnly = true;
            this.txbTenThuoc.SelectedText = "";
            this.txbTenThuoc.Size = new System.Drawing.Size(400, 44);
            this.txbTenThuoc.TabIndex = 39;
            // 
            // txbGiaThuoc
            // 
            this.txbGiaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGiaThuoc.DefaultText = "";
            this.txbGiaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbGiaThuoc.Location = new System.Drawing.Point(1251, 44);
            this.txbGiaThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbGiaThuoc.Name = "txbGiaThuoc";
            this.txbGiaThuoc.PasswordChar = '\0';
            this.txbGiaThuoc.PlaceholderText = "";
            this.txbGiaThuoc.ReadOnly = true;
            this.txbGiaThuoc.SelectedText = "";
            this.txbGiaThuoc.Size = new System.Drawing.Size(400, 44);
            this.txbGiaThuoc.TabIndex = 41;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoLuong.DefaultText = "";
            this.txbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoLuong.Location = new System.Drawing.Point(1251, 123);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.PasswordChar = '\0';
            this.txbSoLuong.PlaceholderText = "Enter Customer Contact";
            this.txbSoLuong.SelectedText = "";
            this.txbSoLuong.Size = new System.Drawing.Size(400, 44);
            this.txbSoLuong.TabIndex = 42;
            this.txbSoLuong.TextChanged += new System.EventHandler(this.txbQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tìm thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(796, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID Thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1247, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1247, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giá thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1247, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tổng giá";
            // 
            // txbTongGia
            // 
            this.txbTongGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTongGia.DefaultText = "";
            this.txbTongGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTongGia.Location = new System.Drawing.Point(1251, 203);
            this.txbTongGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTongGia.Name = "txbTongGia";
            this.txbTongGia.PasswordChar = '\0';
            this.txbTongGia.PlaceholderText = "";
            this.txbTongGia.ReadOnly = true;
            this.txbTongGia.SelectedText = "";
            this.txbTongGia.Size = new System.Drawing.Size(400, 44);
            this.txbTongGia.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nhóm thuốc";
            // 
            // txbNhomThuoc
            // 
            this.txbNhomThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNhomThuoc.DefaultText = "";
            this.txbNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNhomThuoc.Location = new System.Drawing.Point(800, 203);
            this.txbNhomThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNhomThuoc.Name = "txbNhomThuoc";
            this.txbNhomThuoc.PasswordChar = '\0';
            this.txbNhomThuoc.PlaceholderText = "";
            this.txbNhomThuoc.ReadOnly = true;
            this.txbNhomThuoc.SelectedText = "";
            this.txbNhomThuoc.Size = new System.Drawing.Size(400, 44);
            this.txbNhomThuoc.TabIndex = 77;
            // 
            // txbFindPN
            // 
            this.txbFindPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFindPN.DefaultText = "";
            this.txbFindPN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbFindPN.Location = new System.Drawing.Point(459, 43);
            this.txbFindPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFindPN.Name = "txbFindPN";
            this.txbFindPN.PasswordChar = '\0';
            this.txbFindPN.PlaceholderText = "Nhập SĐT";
            this.txbFindPN.SelectedText = "";
            this.txbFindPN.Size = new System.Drawing.Size(313, 44);
            this.txbFindPN.TabIndex = 79;
            this.txbFindPN.TextChanged += new System.EventHandler(this.txbFindPN_TextChanged);
            // 
            // lbFindPN
            // 
            this.lbFindPN.AutoSize = true;
            this.lbFindPN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindPN.Location = new System.Drawing.Point(455, 18);
            this.lbFindPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFindPN.Name = "lbFindPN";
            this.lbFindPN.Size = new System.Drawing.Size(168, 23);
            this.lbFindPN.TabIndex = 81;
            this.lbFindPN.Text = "Tìm SĐT khách hàng";
            // 
            // lsDanhSachThuoc
            // 
            this.lsDanhSachThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsDanhSachThuoc.FullRowSelect = true;
            this.lsDanhSachThuoc.HideSelection = false;
            this.lsDanhSachThuoc.Location = new System.Drawing.Point(21, 140);
            this.lsDanhSachThuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsDanhSachThuoc.Name = "lsDanhSachThuoc";
            this.lsDanhSachThuoc.Size = new System.Drawing.Size(428, 560);
            this.lsDanhSachThuoc.TabIndex = 84;
            this.lsDanhSachThuoc.UseCompatibleStateImageBehavior = false;
            this.lsDanhSachThuoc.View = System.Windows.Forms.View.Details;
            this.lsDanhSachThuoc.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachThuoc_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "ID";
            this.columnHeader0.Width = 25;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Thuốc";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 91;
            // 
            // lsDanhSachKhachHang
            // 
            this.lsDanhSachKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader5});
            this.lsDanhSachKhachHang.FullRowSelect = true;
            this.lsDanhSachKhachHang.HideSelection = false;
            this.lsDanhSachKhachHang.Location = new System.Drawing.Point(459, 140);
            this.lsDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsDanhSachKhachHang.Name = "lsDanhSachKhachHang";
            this.lsDanhSachKhachHang.Size = new System.Drawing.Size(312, 560);
            this.lsDanhSachKhachHang.TabIndex = 85;
            this.lsDanhSachKhachHang.UseCompatibleStateImageBehavior = false;
            this.lsDanhSachKhachHang.View = System.Windows.Forms.View.Details;
            this.lsDanhSachKhachHang.SelectedIndexChanged += new System.EventHandler(this.lsDanhSachKhachHang_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Họ tên";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số điện thoại";
            this.columnHeader5.Width = 130;
            // 
            // lsHoaDonMua
            // 
            this.lsHoaDonMua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsHoaDonMua.HideSelection = false;
            this.lsHoaDonMua.Location = new System.Drawing.Point(800, 318);
            this.lsHoaDonMua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsHoaDonMua.Name = "lsHoaDonMua";
            this.lsHoaDonMua.Size = new System.Drawing.Size(849, 265);
            this.lsHoaDonMua.TabIndex = 86;
            this.lsHoaDonMua.UseCompatibleStateImageBehavior = false;
            this.lsHoaDonMua.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên thuốc";
            this.columnHeader6.Width = 145;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tổng";
            this.columnHeader9.Width = 166;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(796, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 23);
            this.label8.TabIndex = 87;
            this.label8.Text = "Hóa đơn bán hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 88;
            this.label9.Text = "Danh sách thuốc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 23);
            this.label10.TabIndex = 89;
            this.label10.Text = "danh sách khách hàng";
            // 
            // fc_SellMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 716);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lsHoaDonMua);
            this.Controls.Add(this.lsDanhSachKhachHang);
            this.Controls.Add(this.lsDanhSachThuoc);
            this.Controls.Add(this.lbFindPN);
            this.Controls.Add(this.txbFindPN);
            this.Controls.Add(this.txbNhomThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTongGia);
            this.Controls.Add(this.txbSoLuong);
            this.Controls.Add(this.txbGiaThuoc);
            this.Controls.Add(this.txbTenThuoc);
            this.Controls.Add(this.txbIDThuoc);
            this.Controls.Add(this.txbTimThuoc);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGenerateBill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fc_SellMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSellMed";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerContact;
        private Guna.UI2.WinForms.Guna2Button btnThemThuoc;
        private Guna.UI2.WinForms.Guna2Button btnRemoveMedicine;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnGenerateBill;
        private System.Windows.Forms.TextBox txbTotal;
        private Guna.UI2.WinForms.Guna2TextBox txbTimThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbIDThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbTenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txbTongGia;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txbNhomThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbFindPN;
        private System.Windows.Forms.Label lbFindPN;
        private System.Windows.Forms.ListView lsDanhSachThuoc;
        private System.Windows.Forms.ListView lsDanhSachKhachHang;
        private System.Windows.Forms.ListView lsHoaDonMua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}