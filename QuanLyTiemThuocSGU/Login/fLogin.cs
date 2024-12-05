using QuanLyThuVienSGU_Winform.BLL; 
using QuanLyThuVienSGU_Winform.DAO;
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
    public partial class fLogin : Form
    {
        #region Variables
        int employeeID; 
        #endregion

        public fLogin()
        {
            InitializeComponent();
        }

        #region Events

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            AccountBLL accountBLL = new AccountBLL(); //Dùng để gọi hàm Login từ BLL
            var (isSuccess, role, employeeID) = accountBLL.Login(username, password);

            if (isSuccess)
            {
                if (role == 1)
                {
                    fAdmin lForm = new fAdmin(employeeID, role);
                    lForm.Show();
                    this.Hide();
                }
                else if (role == 0)
                {
                    fStaff lForm = new fStaff(employeeID, role);
                    lForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}