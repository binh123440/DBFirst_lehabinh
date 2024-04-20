using DBFirst_lehabinh.Repository;
using DBFirst_lehabinh.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DBFirst_lehabinh.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly SinhVienDBFirstDbContext _content;

        public SinhVienController(SinhVienDBFirstDbContext content)
        {
            _content = content;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var sinhviens = _content.SinhViens
                                    .Include(s => s.Lop)
                                        .ThenInclude(l => l.Khoa)
                                    .Where(s => s.Tuoi >= 18 && s.Tuoi <= 20
                                                && s.Lop.Khoa.TenKhoa == "Cong nghe so")
                                    .ToList();
            List<SinhVienViewModel> sinhvienlist = new List<SinhVienViewModel>();

            if (sinhviens != null)
            {
                foreach (var sinhvien in sinhviens)
                {
                    var SinhVienViewModel = new SinhVienViewModel()
                    {
                        SinhVienId = sinhvien.SinhVienId,
                        Ten = sinhvien.Ten,
                        Tuoi = (int)sinhvien.Tuoi,
                        LopId = (int)sinhvien.LopId,
                        
                    };
                    sinhvienlist.Add(SinhVienViewModel);
                }
                return View(sinhvienlist);
            }
            return View();
        }
    }
}
