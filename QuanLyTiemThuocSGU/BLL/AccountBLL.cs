using QuanLyThuVienSGU_Winform.DAO; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class AccountBLL
    {
        public (bool isSuccess, int role, int employeeID) Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
    }
}
