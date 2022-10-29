using System;
using baikiemtra.ViewModel;
using baikiemtra.Model;
using baikiemtra.Services;
using baikiemtra.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikiemtra
{
    public partial class addlienlac : Form
    {
        public addlienlac()
        {
            InitializeComponent();
            NapDSNhom();
        }
        void NapDSNhom()
        {
            var ls = NhomViewModel.GetList();
            cbTenNhom.DataSource = ls;
            cbTenNhom.DisplayMember = "TenNhom";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addlienlac_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            #region Thêm mới sinh viên
            var sv = new SinhVien
            {
                IDNhom = cbTenNhom.SelectedIndex,
                ID = cbTenNhom.SelectedIndex,
                TenGoi = txtTenGoi.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,              
                SoDienThoai = txtSdt.Text,
            };
            if (SinhVienService.AddSinhVien(sv) == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                txtID.Focus();
            }
            #endregion
        }

        private void cbTenNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
