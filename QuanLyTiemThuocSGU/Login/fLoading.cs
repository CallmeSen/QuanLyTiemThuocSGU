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
    public partial class fLoading : Form
    {

        public fLoading()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 6;
            if (panel1.Width > 585)
            {
                timer1.Stop();
                //fc_AddRemoveStaff f = new fc_AddRemoveStaff();
                //f.Show();
                fLogin loginForm = new fLogin();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}
