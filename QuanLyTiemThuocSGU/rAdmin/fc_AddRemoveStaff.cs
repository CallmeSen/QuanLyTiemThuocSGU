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
    public partial class fc_AddRemoveStaff : Form
    {
        public fc_AddRemoveStaff()
        {
            InitializeComponent();
            LoadEmployeeList();
        }


        void LoadEmployeeList()
        {
            string query = "EXEC dbo.USP_GetEmployeeByName @nameEmployee";


            dataGridView_ChinhSuaTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query , new object[] { "Tran Quang Huy" });


        }
    }
}
