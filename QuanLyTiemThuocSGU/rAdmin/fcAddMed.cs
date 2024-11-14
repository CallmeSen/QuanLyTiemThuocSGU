using Guna.UI2.WinForms;
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
    public partial class fcAddMed : Form
    {
        private List<string> supplierList;
        public fcAddMed()
        {
            InitializeComponent();


            // Configure the ComboBox to be editable
            cmbNhaCungCap.DropDownStyle = ComboBoxStyle.DropDown;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Console.WriteLine($"User typed: {comboBox.Text}");
        }
    }
}
