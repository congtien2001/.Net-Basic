using System;
using baikiemtra.ViewModel;
using baikiemtra.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra.Services
{
    internal class NhomServices
    {
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom,
            }).ToList();

            return rs;
        }

        public static List<NhomViewModel> GetList(int idNhom)
        {
            var db = new AppDBContext();
            var rs = db.Nhoms
                .Where(e => e.ID == idNhom)
                .Select(e => new NhomViewModel
                {
                    ID = e.ID,
                    TenNhom = e.TenNhom,
                }).ToList();

            return rs;
        }

        public static KetQua AddNhom(Nhom n)
        {
            var db = new AppDBContext();
            var count = db.Nhoms.Where(e => e.ID == n.ID).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.Nhoms.Add(n);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }


        public static KetQua RemoveNhom(NhomViewModel n)
        {
            var db = new AppDBContext();
            var lopHoc = db.Nhoms.Where(e => e.ID == n.ID).FirstOrDefault();
            db.Nhoms.Remove(lopHoc);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
