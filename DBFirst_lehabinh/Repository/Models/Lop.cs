using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_lehabinh.Repository.Models;

[Table("Lop")]
public partial class Lop
{
    [Key]
    public int LopId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TenLop { get; set; }

    public int? KhoaId { get; set; }

    [ForeignKey("KhoaId")]
    [InverseProperty("Lops")]
    public virtual Khoa? Khoa { get; set; }

    [InverseProperty("Lop")]
    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
