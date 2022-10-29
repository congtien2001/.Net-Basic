using System;
using baikiemtra.ViewModel;
using baikiemtra.Model;
using baikiemtra.Services;
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
            cbNhom.DataSource = ls;
            cbNhom.DisplayMember = "TenNhom";
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

        }
    }
}
