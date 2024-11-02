using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }

        private AccountDAO() {}

        public (bool isSuccess, int role) Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});
            if (result.Rows.Count > 0)
            {
                int role = Convert.ToInt32(result.Rows[0]["Role"]); // Lấy trường Role từ kết quả trả về
                return (true, role);
            }
            return (false, -1);
            //, new object[] { username, password }
        }
    }
}
