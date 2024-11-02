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
        public fLogin()
        {
            InitializeComponent();
        }

        #region events

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
            }

        }

        //////////////////////////////////////////////////////

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string username = txbUsername.Text;
            string password = txbPassword.Text;
            var loginResult = Login(username, password);

            if (loginResult.isSuccess)
            {
                if (loginResult.role == 1)
                {
                    fAdmin lForm = new fAdmin();
                    lForm.Show();
                    this.Hide();
                }
                else if (loginResult.role == 0)
                {
                    fStaff lForm = new fStaff();
                    lForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            
        }

        //BLL


        (bool isSuccess, int role) Login(string username, string password)
        {

            return AccountDAO.Instance.Login(username, password);
        }

        //////////////////////////////////////////////////////

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

        //////////////////////////////////////////////////////


        #endregion

    }
}