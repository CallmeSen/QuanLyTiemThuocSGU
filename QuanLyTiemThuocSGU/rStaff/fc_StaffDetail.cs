﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.BLL;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_StaffDetail : Form
    {
        #region Variables
        private TextBox textBox_NhanVienName;
        private TextBox textBox_SoDienThoaiInfo;
        private TextBox textBox_Email;
        private TextBox textBox_GioiTinhInfo;
        private TextBox textBox_ChucVuInfo;
        private Label label_NhanVienNameAfter;
        private Label label_SoDienThoaiAfter;
        private Label label_EmailAfter;
        private Label label_GioiTinhAfter;
        private Label label_ChucVuAfter;
        private int employeeID;
        private StaffInfoBLL staffInfoBLL = new StaffInfoBLL();
        //
        #endregion
        public fc_StaffDetail(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            LoadData(employeeID);
        }
        private void LoadData(int employeeID)
        {
            StaffInfoDTO staff = staffInfoBLL.GetStaffDetails(employeeID);
            if (staff != null)
            {
                label_IDInfo.Text = staff.EmployeeID.ToString();
                label_NhanVienName.Text = staff.FullName;
                label_GioiTinhInfo.Text = staff.Gender;
                label_ChucVuInfo.Text = staff.Role;
                label_SoDienThoaiInfo.Text = staff.Phone;
                label_EmailInfo.Text = staff.Email;
                label_NgayNhanViecInfo.Text = staff.HireDate.ToString("dd/MM/yyyy");
            }
        }
        #region Functions

        private TextBox ConvertLabelToTextBox(Label label)
        {
            TextBox textBox = new TextBox
            {
                Text = label.Text,
                Font = label.Font,
                ForeColor = label.ForeColor,
                BackColor = Color.Gainsboro,
                Location = label.Location,
                Size = label.Size
            };
            this.Controls.Add(textBox);
            textBox.BringToFront();
            this.Controls.Remove(label);
            return textBox;
        }

        private Label ConvertTextBoxToLabel(TextBox textBox)
        {
            Label label = new Label
            {
                Text = textBox.Text,
                Font = textBox.Font,
                ForeColor = textBox.ForeColor,
                BackColor = Color.Transparent,
                Location = textBox.Location,
                Size = textBox.Size
            };
            this.Controls.Add(label);
            label.BringToFront();
            this.Controls.Remove(textBox);
            return label;
        }

        #endregion

        #region Events

        private void button_Edit_Click(object sender, EventArgs e)
        {
            textBox_NhanVienName = ConvertLabelToTextBox(label_NhanVienName);
            textBox_SoDienThoaiInfo = ConvertLabelToTextBox(label_SoDienThoaiInfo);
            textBox_Email = ConvertLabelToTextBox(label_EmailInfo);
            textBox_GioiTinhInfo = ConvertLabelToTextBox(label_GioiTinhInfo); 
            textBox_ChucVuInfo = ConvertLabelToTextBox(label_ChucVuInfo);    
        }


        private void button_SaveInsert_Click(object sender, EventArgs e)
        {
            StaffInfoDTO staff = new StaffInfoDTO {
                EmployeeID = this.employeeID,
                FullName = textBox_NhanVienName.Text,
                Gender = label_GioiTinhInfo.Text,
                Phone = textBox_SoDienThoaiInfo.Text,
                Email = label_EmailInfo.Text
            };

            staffInfoBLL.UpdateStaffDetails(staff);

            MessageBox.Show("Chỉnh sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(employeeID);
        }

        private void button_ResetInsert_Click(object sender, EventArgs e)
        {
            ApplyChangesToLabels();
            LoadData(employeeID);
        }

        private void ApplyChangesToLabels()
        {
            // Add logic to apply necessary changes to labels if needed
            label_NhanVienName.Text = "";
            label_GioiTinhInfo.Text = "";
            label_SoDienThoaiInfo.Text = "";
            label_EmailInfo.Text = "";
            label_NgayNhanViecInfo.Text = "";
        }

        #endregion
    }
}
