using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.BLL;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform
{
    public partial class fc_StaffDetail : Form
    {
        #region Variables
        private Label label_NhanVienNameAfter;
        private Label label_SoDienThoaiAfter;
        private Label label_EmailAfter;
        private Label label_GioiTinhAfter;
        private Label label_ChucVuAfter;
        private int employeeID;
        private int role;
        private StaffInfoBLL staffInfoBLL = StaffInfoBLL.Instance;
        #endregion

        public fc_StaffDetail(int employeeID, int role)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.role = role;
            LoadData(employeeID);
        }

        #region Functions
        private void LoadData(int employeeID)
        {
            StaffInfoDTO staff = staffInfoBLL.GetStaffDetails(employeeID);
            if (staff != null)
            {
                label_IDInfo.Text = staff.EmployeeID.ToString();
                label_NhanVienName.Text = staff.FullName;
                label_GioiTinhInfo.Text = staff.Gender;
                label_ChucVuInfo.Text = staff.Role;
                label_SoDienThoaiInfo.Text = staff.Phone;
                label_EmailInfo.Text = staff.Email;
                label_NgayNhanViecInfo.Text = staff.HireDate.HasValue ? staff.HireDate.Value.ToString("dd/MM/yyyy") : "N/A";
            }
        }
        #endregion

        #region Events

        #endregion
    }
}
