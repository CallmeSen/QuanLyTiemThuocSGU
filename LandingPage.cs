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
    public partial class LandingPage : Form
    {
        private ContextMenuStrip contextMenu;

        public LandingPage()
        {
            InitializeComponent();

            threeDotButton.ContextMenuStrip = contextMenu;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Point location = new Point(120, 128);
            threeDotButton.Show(this, location);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check profile complete", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
            }
        }


        private void guna2Panel16_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 1); 
            e.Graphics.DrawLine(myPen, 0, 0, 256, 0);
            myPen.Dispose();
        }

        private void guna2Panel17_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 1);  
            e.Graphics.DrawLine(myPen, 0, 0, 256, 0);
            myPen.Dispose();
        }
    }
}
