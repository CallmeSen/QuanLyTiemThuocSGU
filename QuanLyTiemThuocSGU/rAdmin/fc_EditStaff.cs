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
    public partial class fc_EditStaff : Form
    {
        public fc_EditStaff()
        {
            InitializeComponent();
            LoadEmployeeList();
        }


        void LoadEmployeeList()
        {
            string query = "EXEC dbo.USP_GetEmployeeByID";

            dataGridView_ChinhSuaTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// chỉnh sửa kích thước của các cột
            dataGridView_ChinhSuaTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
            // neu ma cu the de test thi xai them ", new object[] { "Tran Quang Huy" }"

        }
    }
}
