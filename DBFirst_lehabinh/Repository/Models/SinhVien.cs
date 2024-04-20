using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_lehabinh.Repository.Models;

[Table("SinhVien")]
public partial class SinhVien
{
    [Key]
    public int SinhVienId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    public int? LopId { get; set; }

    [ForeignKey("LopId")]
    [InverseProperty("SinhViens")]
    public virtual Lop? Lop { get; set; }
}
