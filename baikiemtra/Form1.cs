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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            }
        }

        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }


        void NapDSNhom()
        {
            var ls = NhomServices.GetList();
            nhomViewModelBindingSource.DataSource = ls;
            dataGridView1.DataSource = nhomViewModelBindingSource;
        }

        void NapDSSinhVien()
        {
            if (selectedNhom != null)
            {
                var ls = SinhVienServices.GetList(selectedNhom.ID);
                sinhVienViewModelBindingSource.DataSource = ls;
                dataGridView2.DataSource = sinhVienViewModelBindingSource;
            }

        }
    }
    
}
