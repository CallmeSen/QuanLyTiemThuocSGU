using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienSGU_Winform.rAdmin;
using QuanLyThuVienSGU_Winform.rStaff;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fAdmin : Form
    {
        #region Variables
        int employeeID;
        int medicineID;
        int role;
        bool menuExpandQuanLiThuoc = false; //Biến hiển thị độ mở rộng của button con
        bool menuExpandQuanLiNhomThuoc = false; //Biến hiển thị độ mở rộng của button con
        private Form activeForm = null;
        #endregion

        public fAdmin(int employeeID, int role)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.role = role;
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

        #region Events

        private void timer_QuanLiThuocTransition_Tick(object sender, EventArgs e)
        {
            MenuExpand_Transition(ref menuExpandQuanLiThuoc, panel_ChildQuanLiThuoc, timer_QuanLiThuocTransition);
        }

        private void timer_QuanLiNhanVienTransition_Tick(object sender, EventArgs e)
        {
            MenuExpand_Transition(ref menuExpandQuanLiNhomThuoc, panel_ChildQuanLiNhomThuoc, timer_QuanLiNhanVienTransition);
        }

        private void button_TaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Thông tin nhân viên";
            label_CurrentFunction.Text = "> Tài khoản > Thông tin nhân viên";
            openChildForm(new fc_StaffDetail(employeeID, role));
        }

        private void button_QuanLiThuoc_Click(object sender, EventArgs e)
        {
            StartTimer(timer_QuanLiThuocTransition);
            label_CurrentPage.Text = "Quản lí thuốc";
            label_CurrentFunction.Text = "";
        }

        private void button_QuanLiNhanVien_Click(object sender, EventArgs e)
        {
            StartTimer(timer_QuanLiNhanVienTransition);
            label_CurrentPage.Text = "Quản lí nhân viên";
            label_CurrentFunction.Text = "";
        }

        //private void button_Thongtin_Click(object sender, EventArgs e)
        //{
        //    label_CurrentPage.Text = "Thông tin nhân viên";
        //    label_CurrentFunction.Text = "> Tài khoản > Thông tin nhân viên";
        //    openChildForm(new fc_StaffDetail(employeeID, role));
        //}

        //private void button_ChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Chức năng đang được phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void button_ThongTinThuoc_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí thuốc";
            label_CurrentFunction.Text = "> Quản lí thuốc > Kho thuốc";
            openChildForm(new fc_EditMed());
        }

        private void button_ThongTinLoaiThuoc_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí loại thuốc";
            label_CurrentFunction.Text = "> Quản lí loại thuốc > Thông tin loại thuốc";
            openChildForm(new fc_EditCategory());
        }

        private void button_ThongTinNhanVien_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí nhân viên";
            label_CurrentFunction.Text = "> Quản lí nhân viên > Thông tin nhân viên";
            openChildForm(new fc_EditStaff());
        }

        private void button_ChinhSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Quản lí nhà cung cấp";
            label_CurrentFunction.Text = "> Quản lí nhà cung cấp > Thông tin nhà cung cấp";
            openChildForm(new fc_EditSupplier());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Thống kê";
            label_CurrentFunction.Text = ">Thống kê doanh thu";
            openChildForm(new fc_Dashboard());
        }

        private void btnThuocHetHan_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Danh sách tình trạng thuốc";
            label_CurrentFunction.Text = ">Tình trạng thuốc";
            openChildForm(new fc_ExpiredMed());
        }

        private void button_QuanLiKhachHang_Click(object sender, EventArgs e)
        {
            label_CurrentPage.Text = "Danh sách quản lý khách hàng";
            label_CurrentFunction.Text = "> Quản lí khách hàng > Thông tin khách hàng";
            openChildForm(new fc_EditCustomer());
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

        private void fAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion
    }
}
