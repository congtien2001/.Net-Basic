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
            NapDSNhom();


            NapDSSinhVien();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDSSinhVien();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                var ls = SinhVienService.GetList(selectedNhom.ID);
                sinhVienViewModelBindingSource.DataSource = ls;
                dataGridView2.DataSource = sinhVienViewModelBindingSource;
            }

        }

        private void btnthemnhom_Click(object sender, EventArgs e)
        {
            var a = new addnhom();
            var rs = a.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSNhom();
            }
        }

        private void btnxoanhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomServices.RemoveNhom(selectedNhom);
                    NapDSNhom();
                }
            }
        }

        private void btnthemlienlac_Click(object sender, EventArgs e)
        {
            var a = new addlienlac();
            var rs = a.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSSinhVien();
            }
        }

        private void Btnxoalienlac(object sender, EventArgs e)
        {
            if (selectedSinhVien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    SinhVienService.RemoveSinhVien(selectedSinhVien);
                    NapDSSinhVien();
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
