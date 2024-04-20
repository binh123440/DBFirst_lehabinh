using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_lehabinh.Repository.Models;

[Table("Khoa")]
public partial class Khoa
{
    [Key]
    public int KhoaId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TenKhoa { get; set; }

    [InverseProperty("Khoa")]
    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
