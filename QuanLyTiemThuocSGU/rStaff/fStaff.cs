using QuanLyThuVienSGU_Winform.rAdmin; 
using QuanLyThuVienSGU_Winform.rStaff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fStaff : Form
    {
        int employeeID;
        int role;
        bool menuExpandTaiKhoanNhanVien = false; //Biến hiển thị độ mở rộng của button con
        bool menuExpandQuanLiThuoc = false; //Biến hiển thị độ mở rộng của button con
        bool menuExpandQuanLiNhomThuoc = false; //Biến hiển thị độ mở rộng của button con
        private Form activeForm = null;
        public fStaff(int employeeID, int role)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.role = role;
        }

        #region Functions
        //Hàm để mở rộng và thu nhỏ các button con
        private void MenuExpand_Transition(ref bool menuExpand, Panel panel, Timer timer)
        {
            if (menuExpand == false)
            {
                panel.Height += 5;
                if (panel.Height >= 100)
                {
                    StopTimer(timer);
                    menuExpand = true;
                }
            }
            else
            {
                panel.Height -= 5;
                if (panel.Height <= 0)
                {
                    StopTimer(timer);
                    menuExpand = false;
                }
            }
        }

        private void StartTimer(Timer timer) //Hàm để Start Timer
        {
            timer.Start();
        }

        private void StopTimer(Timer timer) //Hàm để stop Timer
        {
            timer.Stop();
        }

        //Hàm mở ChildForm vào 1 panel cố định trong giao diện
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        //Events
        #region Events

        private void button_Thongtin_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Thông tin nhân viên";
            label_CurrentFunction.Text = "> Tài khoản > Thông tin nhân viên";
            openChildForm(new fc_StaffDetail(employeeID, role)); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_BanThuoc_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Hóa Đơn Khách Hàng";
            label_CurrentFunction.Text = "> Bán Thuốc";
            openChildForm(new fc_SellMed(employeeID)); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void btnThuocHetHan_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Kho thuốc";
            label_CurrentFunction.Text = ">Danh sách tình trạng thuốc";
            openChildForm(new fc_ExpiredMed());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                fLogin f = new fLogin();
                f.Show();
            }
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Thống kê";
            label_CurrentFunction.Text = ">Thống kê doanh thu";

            openChildForm(new fc_Dashboard());
        }

        #endregion

    }
}
