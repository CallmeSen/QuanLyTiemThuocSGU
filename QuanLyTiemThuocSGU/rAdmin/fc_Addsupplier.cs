﻿using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienSGU_Winform.rAdmin
{
    public partial class fc_Addsupplier : Form
    {
        public fc_Addsupplier()
        {
            InitializeComponent();
        }

        private void btnThemSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                int id = Convert.ToInt32(txbSupplierId.Text);
                string SupplierName = tsxSupplierName.Text;
                string address = tsxAddress.Text;
                string SDT = tsxPhone.Text;
                string email = tsxSuplierEmail.Text;




                if (string.IsNullOrWhiteSpace(SupplierName))
                {
                    MessageBox.Show("Tên nhà cung cấp không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Địa chỉ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(SDT))
                {
                    MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SupplierDTO newCustomer = new SupplierDTO
                {
                    SupplierID = id,
                    SupplierName = SupplierName,
                    Phone = SDT,
                    Address = address,
                    Email = email

                };

                bool isAdded = SupplierDAO.Instance.AddSupplier(SupplierName, SDT, address, email);

                // Kiểm tra kết quả
                if (isAdded == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}