using System;
using baikiemtra.Model;
using baikiemtra.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra.Services
{
    internal class SinhVienService
    {
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                DiaChi = e.DiaChi,
                Email = e.Email,
                SoDienThoai = e.SoDienThoai,

            }).ToList();

            return rs;
        }

        public static List<SinhVienViewModel> GetList(int idLopHoc)
        {
            var db = new AppDBContext();
            var rs = db.SinhViens
                .Where(e => e.IDNhom == idLopHoc)
                .Select(e => new SinhVienViewModel
                {
                    ID = e.ID,
                    TenGoi = e.TenGoi,
                    DiaChi = e.DiaChi,
                    Email = e.Email,
                    SoDienThoai = e.SoDienThoai,

                }).ToList();

            return rs;
        }

        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            var count = db.SinhViens.Where(e => e.ID == sv.ID).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua UpdateSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhVien.TenGoi = sv.TenGoi;
            sinhVien.DiaChi = sv.DiaChi;
            sinhVien.Email = sv.Email;
            sinhVien.SoDienThoai = sv.SoDienThoai;
            sinhVien.IDNhom = sv.ID;
            
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhVien);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
