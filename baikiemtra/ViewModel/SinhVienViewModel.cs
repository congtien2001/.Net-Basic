using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
    }
    public class SinhVienViewModel
    {
        public int ID { get; set; }

        public string TenGoi { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public string SoDienThoai { get; set; }

        
    }
}
