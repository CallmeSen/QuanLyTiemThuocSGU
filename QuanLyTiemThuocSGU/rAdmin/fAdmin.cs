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
    public partial class fAdmin : Form
    {
        int employeeID;
        int medicineID;
        bool menuExpandTaiKhoanNhanVien = false; //Biến hiển thị độ mở rộng của button con
        bool menuExpandQuanLiThuoc = false; //Biến hiển thị độ mở rộng của button con
        bool menuExpandQuanLiNhomThuoc = false; //Biến hiển thị độ mở rộng của button con
        private Form activeForm = null;

        public fAdmin(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            panel_ChildTaiKhoanNhanVien.Height = 0; //Mặc định button con của TKNV có height = 0
            panel_ChildQuanLiThuoc.Height = 0; //Mặc định button con của QLS có height = 0
            panel_ChildQuanLiNhomThuoc.Height = 0; //Mặc định button con của QLDG có height = 0
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
        private void timer_TaiKhoanNhanVienTransition_Tick(object sender, EventArgs e)
        {
            MenuExpand_Transition(ref menuExpandTaiKhoanNhanVien, panel_ChildTaiKhoanNhanVien, timer_TaiKhoanNhanVienTransition);
        }

        private void timer_QuanLiThuocTransition_Tick(object sender, EventArgs e)
        {
            MenuExpand_Transition(ref menuExpandQuanLiThuoc, panel_ChildQuanLiThuoc, timer_QuanLiThuocTransition);
        }

        private void timer_QuanLiNhomThuocTransition_Tick(object sender, EventArgs e)
        {
            MenuExpand_Transition(ref menuExpandQuanLiNhomThuoc, panel_ChildQuanLiNhomThuoc, timer_QuanLiNhomThuocTransition);
        }

        private void button_TaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            StartTimer(timer_TaiKhoanNhanVienTransition);
            label_CurrentPage.Text = "Tài khoản nhân viên";
            label_CurrentFunction.Text = "";
        }

        private void button_QuanLiThuoc_Click(object sender, EventArgs e)
        {
            StartTimer(timer_QuanLiThuocTransition);
            label_CurrentPage.Text = "Quản lí thuốc";
            label_CurrentFunction.Text = "";
        }

        private void button_QuanLiNhomThuoc_Click(object sender, EventArgs e)
        {
            StartTimer(timer_QuanLiNhomThuocTransition);
            label_CurrentPage.Text = "Quản lí nhóm thuốc";
            label_CurrentFunction.Text = "";
        }

        #endregion

        private void button_Thongtin_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Thông tin nhân viên";
            label_CurrentFunction.Text = "> Tài khoản > Thông tin nhân viên";
            openChildForm(new fc_StaffDetail(employeeID)); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_ThongTinThuoc_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí thuốc";
            label_CurrentFunction.Text = "> Quản lí thuốc > Thông tin thuốc";
            openChildForm(new fc_EditMed()); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_ThongTinNhomThuoc_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí thuốc";
            label_CurrentFunction.Text = "> Quản lí thuốc > Thông tin thuốc";
            openChildForm(new fc_EditStaff()); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fc_Dashboard f = new fc_Dashboard();
            f.Show();

        }
    }
}
