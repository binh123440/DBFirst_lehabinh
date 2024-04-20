using System.ComponentModel;

namespace DBFirst_lehabinh.Repository.Models
{
    public class SinhVienViewModel
    {
        [DisplayName("Mã sinh viên")]
        public int SinhVienId { get; set; }

        [DisplayName("Họ Tên sinh viên")]
        public string Ten { get; set; }

        [DisplayName("Tuổi sinh viên")]
        public int Tuoi { get; set; }

        // Khóa ngoại
        [DisplayName("Mã Lớp học")]
        public int LopId { get; set; }

        [DisplayName("Tên khoa")]
        public string TenKhoa { get; set; }
    }
}
