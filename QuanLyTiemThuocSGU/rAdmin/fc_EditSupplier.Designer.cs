namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_EditSupplier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fc_EditSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.employeesTableAdapter = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSetTableAdapters.EmployeesTableAdapter();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.quanlycuahangthuocDataSet = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSet();
            this.panel_Null1 = new System.Windows.Forms.Panel();
            this.panel_Null2 = new System.Windows.Forms.Panel();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_Search = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.timer_ChinhSuaTaiKhoanTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Null3 = new System.Windows.Forms.Panel();
            this.panel_SearchFunction = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_ChinhSuaTaiKhoan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label_HoVaTenUpdateInput = new System.Windows.Forms.Label();
            this.label_IDUpdateInput = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label_ChinhSuaThongTinNhaCungCap = new System.Windows.Forms.Label();
            this.dataGridView_ChinhSuaTaiKhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.panel_Null3.SuspendLayout();
            this.panel_SearchFunction.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_ChinhSuaTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // quanlycuahangthuocDataSet
            // 
            this.quanlycuahangthuocDataSet.DataSetName = "quanlycuahangthuocDataSet";
            this.quanlycuahangthuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_Null1
            // 
            this.panel_Null1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Null1.Location = new System.Drawing.Point(0, 0);
            this.panel_Null1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_Null1.Name = "panel_Null1";
            this.panel_Null1.Size = new System.Drawing.Size(84, 1864);
            this.panel_Null1.TabIndex = 18;
            // 
            // panel_Null2
            // 
            this.panel_Null2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Null2.Location = new System.Drawing.Point(3470, 0);
            this.panel_Null2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_Null2.Name = "panel_Null2";
            this.panel_Null2.Size = new System.Drawing.Size(60, 1864);
            this.panel_Null2.TabIndex = 19;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.quanlycuahangthuocDataSet;
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_Search.Location = new System.Drawing.Point(0, 99);
            this.panel_Search.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(1280, 93);
            this.panel_Search.TabIndex = 9;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(2972, 95);
            this.button_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(412, 93);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(-12, 8);
            this.label_ThongTinNhanVien.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(708, 71);
            this.label_ThongTinNhanVien.TabIndex = 6;
            this.label_ThongTinNhanVien.Text = "THÔNG TIN NHÀ CUNG CẤP";
            this.label_ThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_ChinhSuaTaiKhoanTransition
            // 
            this.timer_ChinhSuaTaiKhoanTransition.Interval = 10;
            // 
            // panel_Null3
            // 
            this.panel_Null3.Controls.Add(this.panel_Search);
            this.panel_Null3.Controls.Add(this.button_Search);
            this.panel_Null3.Controls.Add(this.label_ThongTinNhanVien);
            this.panel_Null3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Null3.Location = new System.Drawing.Point(0, 0);
            this.panel_Null3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_Null3.Name = "panel_Null3";
            this.panel_Null3.Size = new System.Drawing.Size(3386, 211);
            this.panel_Null3.TabIndex = 0;
            // 
            // panel_SearchFunction
            // 
            this.panel_SearchFunction.BackColor = System.Drawing.Color.White;
            this.panel_SearchFunction.Controls.Add(this.panel_Main);
            this.panel_SearchFunction.Controls.Add(this.panel_Null1);
            this.panel_SearchFunction.Controls.Add(this.panel_Null2);
            this.panel_SearchFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchFunction.Location = new System.Drawing.Point(0, 0);
            this.panel_SearchFunction.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_SearchFunction.Name = "panel_SearchFunction";
            this.panel_SearchFunction.Size = new System.Drawing.Size(3530, 1864);
            this.panel_SearchFunction.TabIndex = 4;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_ChinhSuaTaiKhoan);
            this.panel_Main.Controls.Add(this.dataGridView_ChinhSuaTaiKhoan);
            this.panel_Main.Controls.Add(this.panel_Null3);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(84, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(3386, 1864);
            this.panel_Main.TabIndex = 20;
            // 
            // panel_ChinhSuaTaiKhoan
            // 
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label3);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbAddress);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbEmail);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label2);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbPhone);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label1);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnAdd);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnDelete);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbTen);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbID);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.pictureBox_Exit);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_HoVaTenUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_IDUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnSave);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_ChinhSuaThongTinNhaCungCap);
            this.panel_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 1337);
            this.panel_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_ChinhSuaTaiKhoan.Name = "panel_ChinhSuaTaiKhoan";
            this.panel_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(3386, 527);
            this.panel_ChinhSuaTaiKhoan.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(30, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 65);
            this.label3.TabIndex = 62;
            this.label3.Text = "Address";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.DefaultText = "";
            this.txbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Location = new System.Drawing.Point(34, 347);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PasswordChar = '\0';
            this.txbAddress.PlaceholderText = "";
            this.txbAddress.SelectedText = "";
            this.txbAddress.Size = new System.Drawing.Size(660, 110);
            this.txbAddress.TabIndex = 61;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(2000, 145);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(660, 110);
            this.txbEmail.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1996, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 65);
            this.label2.TabIndex = 59;
            this.label2.Text = "Email";
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.DefaultText = "";
            this.txbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Location = new System.Drawing.Point(1230, 145);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PasswordChar = '\0';
            this.txbPhone.PlaceholderText = "";
            this.txbPhone.SelectedText = "";
            this.txbPhone.Size = new System.Drawing.Size(660, 110);
            this.txbPhone.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1226, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 65);
            this.label1.TabIndex = 57;
            this.label1.Text = "Phone";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(2402, 395);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 114);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1738, 395);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 114);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txbTen
            // 
            this.txbTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTen.DefaultText = "";
            this.txbTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTen.Location = new System.Drawing.Point(468, 145);
            this.txbTen.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbTen.Name = "txbTen";
            this.txbTen.PasswordChar = '\0';
            this.txbTen.PlaceholderText = "";
            this.txbTen.SelectedText = "";
            this.txbTen.Size = new System.Drawing.Size(660, 110);
            this.txbTen.TabIndex = 46;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.DefaultText = "";
            this.txbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbID.Location = new System.Drawing.Point(36, 145);
            this.txbID.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbID.Name = "txbID";
            this.txbID.PasswordChar = '\0';
            this.txbID.PlaceholderText = "";
            this.txbID.SelectedText = "";
            this.txbID.Size = new System.Drawing.Size(264, 110);
            this.txbID.TabIndex = 45;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(3276, 0);
            this.pictureBox_Exit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(108, 99);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 31;
            this.pictureBox_Exit.TabStop = false;
            // 
            // label_HoVaTenUpdateInput
            // 
            this.label_HoVaTenUpdateInput.AutoSize = true;
            this.label_HoVaTenUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_HoVaTenUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoVaTenUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_HoVaTenUpdateInput.Location = new System.Drawing.Point(464, 76);
            this.label_HoVaTenUpdateInput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_HoVaTenUpdateInput.Name = "label_HoVaTenUpdateInput";
            this.label_HoVaTenUpdateInput.Size = new System.Drawing.Size(342, 65);
            this.label_HoVaTenUpdateInput.TabIndex = 25;
            this.label_HoVaTenUpdateInput.Text = "Supplier Name";
            // 
            // label_IDUpdateInput
            // 
            this.label_IDUpdateInput.AutoSize = true;
            this.label_IDUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_IDUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_IDUpdateInput.Location = new System.Drawing.Point(32, 76);
            this.label_IDUpdateInput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_IDUpdateInput.Name = "label_IDUpdateInput";
            this.label_IDUpdateInput.Size = new System.Drawing.Size(108, 65);
            this.label_IDUpdateInput.TabIndex = 20;
            this.label_IDUpdateInput.Text = "ID *";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(2084, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 114);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label_ChinhSuaThongTinNhaCungCap
            // 
            this.label_ChinhSuaThongTinNhaCungCap.AutoSize = true;
            this.label_ChinhSuaThongTinNhaCungCap.BackColor = System.Drawing.Color.White;
            this.label_ChinhSuaThongTinNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChinhSuaThongTinNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.label_ChinhSuaThongTinNhaCungCap.Location = new System.Drawing.Point(28, 6);
            this.label_ChinhSuaThongTinNhaCungCap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ChinhSuaThongTinNhaCungCap.Name = "label_ChinhSuaThongTinNhaCungCap";
            this.label_ChinhSuaThongTinNhaCungCap.Size = new System.Drawing.Size(820, 65);
            this.label_ChinhSuaThongTinNhaCungCap.TabIndex = 15;
            this.label_ChinhSuaThongTinNhaCungCap.Text = "Chỉnh sửa Thông tin Nhà Cung Cấp";
            this.label_ChinhSuaThongTinNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_ChinhSuaTaiKhoan
            // 
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToAddRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeColumns = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ChinhSuaTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeight = 40;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ChinhSuaTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChinhSuaTaiKhoan.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChinhSuaTaiKhoan.EnableHeadersVisualStyles = false;
            this.dataGridView_ChinhSuaTaiKhoan.GridColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 211);
            this.dataGridView_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView_ChinhSuaTaiKhoan.Name = "dataGridView_ChinhSuaTaiKhoan";
            this.dataGridView_ChinhSuaTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersVisible = false;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidth = 100;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_ChinhSuaTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_ChinhSuaTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(3386, 1653);
            this.dataGridView_ChinhSuaTaiKhoan.TabIndex = 0;
            // 
            // fc_EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3530, 1864);
            this.Controls.Add(this.panel_SearchFunction);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fc_EditSupplier";
            this.Text = "fc_EditSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.panel_Null3.ResumeLayout(false);
            this.panel_Null3.PerformLayout();
            this.panel_SearchFunction.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel_ChinhSuaTaiKhoan.ResumeLayout(false);
            this.panel_ChinhSuaTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private quanlycuahangthuocDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private quanlycuahangthuocDataSet quanlycuahangthuocDataSet;
        private System.Windows.Forms.Panel panel_Null1;
        private System.Windows.Forms.Panel panel_Null2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.Timer timer_ChinhSuaTaiKhoanTransition;
        private System.Windows.Forms.Panel panel_Null3;
        private System.Windows.Forms.Panel panel_SearchFunction;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Panel panel_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txbTen;
        private Guna.UI2.WinForms.Guna2TextBox txbID;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label_HoVaTenUpdateInput;
        private System.Windows.Forms.Label label_IDUpdateInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label_ChinhSuaThongTinNhaCungCap;
        private Guna.UI2.WinForms.Guna2TextBox txbPhone;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txbAddress;
    }
}