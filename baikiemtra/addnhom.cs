using System;
using baikiemtra.Model;
using baikiemtra.Services;
using baikiemtra.ViewModel;
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
    public partial class addnhom : Form
    {
        public addnhom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = new Nhom
            {
                TenNhom = textBox1.Text,
            };
            if (NhomServices.AddNhom(n) == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên Nhóm trùng!", "Thông báo");
                textBox1.Focus();
            }
        }
    }
}
