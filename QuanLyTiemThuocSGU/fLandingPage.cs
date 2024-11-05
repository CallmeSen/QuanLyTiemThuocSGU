using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fLandingPage : Form
    {
        private ContextMenuStrip contextMenu;

        public fLandingPage()
        {
            InitializeComponent();

            threeDotButton.ContextMenuStrip = contextMenu;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Point location = new Point(950, 50);
            threeDotButton.Show(this, location);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check profile complete", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fLogin loginForm = new fLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        private void viewlistmed_Click(object sender, EventArgs e)
        {
            fListMed f = new fListMed();
            f.ShowDialog();
        }



        private void viewgrmed_Click(object sender, EventArgs e)
        {
            fListGroup f = new fListGroup();
            f.ShowDialog();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
