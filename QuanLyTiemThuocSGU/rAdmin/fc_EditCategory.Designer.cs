namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fc_EditCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.employeesTableAdapter = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSetTableAdapters.EmployeesTableAdapter();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.quanlycuahangthuocDataSet = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSet();
            this.panel_Null1 = new System.Windows.Forms.Panel();
            this.panel_Null2 = new System.Windows.Forms.Panel();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel_ChinhSuaTaiKhoan = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDCapNhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label_HoVaTenUpdateInput = new System.Windows.Forms.Label();
            this.label_IDUpdateInput = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label_ChinhSuaThongTinNhomThuoc = new System.Windows.Forms.Label();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ThongTinNhomThuoc = new System.Windows.Forms.Label();
            this.timer_ChinhSuaTaiKhoanTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Null3 = new System.Windows.Forms.Panel();
            this.panel_SearchFunction = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.dataGridView_ChinhSuaTaiKhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.panel_ChinhSuaTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_Null3.SuspendLayout();
            this.panel_SearchFunction.SuspendLayout();
            this.panel_Main.SuspendLayout();
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
            this.panel_Null1.Margin = new System.Windows.Forms.Padding(8);
            this.panel_Null1.Name = "panel_Null1";
            this.panel_Null1.Size = new System.Drawing.Size(84, 1319);
            this.panel_Null1.TabIndex = 18;
            // 
            // panel_Null2
            // 
            this.panel_Null2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Null2.Location = new System.Drawing.Point(2789, 0);
            this.panel_Null2.Margin = new System.Windows.Forms.Padding(8);
            this.panel_Null2.Name = "panel_Null2";
            this.panel_Null2.Size = new System.Drawing.Size(60, 1319);
            this.panel_Null2.TabIndex = 19;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.quanlycuahangthuocDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(2032, 326);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 114);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panel_ChinhSuaTaiKhoan
            // 
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnAdd);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnDelete);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbHoTen);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbIDCapNhat);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.pictureBox_Exit);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_HoVaTenUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_IDUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnSave);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_ChinhSuaThongTinNhomThuoc);
            this.panel_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 854);
            this.panel_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(8);
            this.panel_ChinhSuaTaiKhoan.Name = "panel_ChinhSuaTaiKhoan";
            this.panel_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(2705, 465);
            this.panel_ChinhSuaTaiKhoan.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1684, 326);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 114);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txbHoTen
            // 
            this.txbHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.DefaultText = "";
            this.txbHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbHoTen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbHoTen.Location = new System.Drawing.Point(468, 145);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.PasswordChar = '\0';
            this.txbHoTen.PlaceholderText = "";
            this.txbHoTen.SelectedText = "";
            this.txbHoTen.Size = new System.Drawing.Size(660, 110);
            this.txbHoTen.TabIndex = 46;
            // 
            // txbIDCapNhat
            // 
            this.txbIDCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbIDCapNhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCapNhat.DefaultText = "";
            this.txbIDCapNhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbIDCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbIDCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbIDCapNhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbIDCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbIDCapNhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbIDCapNhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCapNhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbIDCapNhat.Location = new System.Drawing.Point(36, 145);
            this.txbIDCapNhat.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbIDCapNhat.Name = "txbIDCapNhat";
            this.txbIDCapNhat.PasswordChar = '\0';
            this.txbIDCapNhat.PlaceholderText = "";
            this.txbIDCapNhat.SelectedText = "";
            this.txbIDCapNhat.Size = new System.Drawing.Size(264, 110);
            this.txbIDCapNhat.TabIndex = 45;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(2595, 0);
            this.pictureBox_Exit.Margin = new System.Windows.Forms.Padding(8);
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
            this.label_HoVaTenUpdateInput.Size = new System.Drawing.Size(278, 65);
            this.label_HoVaTenUpdateInput.TabIndex = 25;
            this.label_HoVaTenUpdateInput.Text = "Tên Nhóm *";
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
            this.btnSave.Location = new System.Drawing.Point(2374, 326);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 114);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label_ChinhSuaThongTinNhomThuoc
            // 
            this.label_ChinhSuaThongTinNhomThuoc.AutoSize = true;
            this.label_ChinhSuaThongTinNhomThuoc.BackColor = System.Drawing.Color.White;
            this.label_ChinhSuaThongTinNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChinhSuaThongTinNhomThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.label_ChinhSuaThongTinNhomThuoc.Location = new System.Drawing.Point(28, 6);
            this.label_ChinhSuaThongTinNhomThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ChinhSuaThongTinNhomThuoc.Name = "label_ChinhSuaThongTinNhomThuoc";
            this.label_ChinhSuaThongTinNhomThuoc.Size = new System.Drawing.Size(727, 65);
            this.label_ChinhSuaThongTinNhomThuoc.TabIndex = 15;
            this.label_ChinhSuaThongTinNhomThuoc.Text = "Chỉnh sửa Thông tin Nhân viên";
            this.label_ChinhSuaThongTinNhomThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_Search.Location = new System.Drawing.Point(0, 99);
            this.panel_Search.Margin = new System.Windows.Forms.Padding(8);
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
            this.button_Search.Location = new System.Drawing.Point(2291, 95);
            this.button_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(412, 93);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label_ThongTinNhomThuoc
            // 
            this.label_ThongTinNhomThuoc.AutoSize = true;
            this.label_ThongTinNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhomThuoc.Location = new System.Drawing.Point(-12, 8);
            this.label_ThongTinNhomThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ThongTinNhomThuoc.Name = "label_ThongTinNhomThuoc";
            this.label_ThongTinNhomThuoc.Size = new System.Drawing.Size(680, 71);
            this.label_ThongTinNhomThuoc.TabIndex = 6;
            this.label_ThongTinNhomThuoc.Text = "THÔNG TIN NHÓM THUỐC";
            this.label_ThongTinNhomThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_ChinhSuaTaiKhoanTransition
            // 
            this.timer_ChinhSuaTaiKhoanTransition.Interval = 10;
            // 
            // panel_Null3
            // 
            this.panel_Null3.Controls.Add(this.panel_Search);
            this.panel_Null3.Controls.Add(this.button_Search);
            this.panel_Null3.Controls.Add(this.label_ThongTinNhomThuoc);
            this.panel_Null3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Null3.Location = new System.Drawing.Point(0, 0);
            this.panel_Null3.Margin = new System.Windows.Forms.Padding(8);
            this.panel_Null3.Name = "panel_Null3";
            this.panel_Null3.Size = new System.Drawing.Size(2705, 211);
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
            this.panel_SearchFunction.Margin = new System.Windows.Forms.Padding(8);
            this.panel_SearchFunction.Name = "panel_SearchFunction";
            this.panel_SearchFunction.Size = new System.Drawing.Size(2849, 1319);
            this.panel_SearchFunction.TabIndex = 4;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.dataGridView_ChinhSuaTaiKhoan);
            this.panel_Main.Controls.Add(this.panel_Null3);
            this.panel_Main.Controls.Add(this.panel_ChinhSuaTaiKhoan);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(84, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(8);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(2705, 1319);
            this.panel_Main.TabIndex = 20;
            // 
            // dataGridView_ChinhSuaTaiKhoan
            // 
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToAddRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeColumns = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ChinhSuaTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeight = 40;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ChinhSuaTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChinhSuaTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChinhSuaTaiKhoan.EnableHeadersVisualStyles = false;
            this.dataGridView_ChinhSuaTaiKhoan.GridColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 211);
            this.dataGridView_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView_ChinhSuaTaiKhoan.Name = "dataGridView_ChinhSuaTaiKhoan";
            this.dataGridView_ChinhSuaTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersVisible = false;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidth = 100;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_ChinhSuaTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_ChinhSuaTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(2705, 643);
            this.dataGridView_ChinhSuaTaiKhoan.TabIndex = 0;
            // 
            // fc_EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2849, 1319);
            this.Controls.Add(this.panel_SearchFunction);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fc_EditCategory";
            this.Text = "fc_EditCategory";
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.panel_ChinhSuaTaiKhoan.ResumeLayout(false);
            this.panel_ChinhSuaTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_Null3.ResumeLayout(false);
            this.panel_Null3.PerformLayout();
            this.panel_SearchFunction.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txbHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txbIDCapNhat;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label_HoVaTenUpdateInput;
        private System.Windows.Forms.Label label_IDUpdateInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label_ChinhSuaThongTinNhomThuoc;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ThongTinNhomThuoc;
        private System.Windows.Forms.Timer timer_ChinhSuaTaiKhoanTransition;
        private System.Windows.Forms.Panel panel_Null3;
        private System.Windows.Forms.Panel panel_SearchFunction;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView_ChinhSuaTaiKhoan;
    }
}