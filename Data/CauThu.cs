#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class CauThu
    {
        public CauThu()
        {
            ChiTietTranDau = new HashSet<ChiTietTranDau>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string TenCauThu { get; set; }
        public int? SoAo { get; set; }
        public int? IdViTri { get; set; }
        public int? IdDoiBong { get; set; }

        [ForeignKey(nameof(IdDoiBong))]
        public virtual DoiBong DoiBong { get; set; }
        [ForeignKey(nameof(IdViTri))]
        public virtual ViTri ViTri { get; set; }
        public virtual ICollection<ChiTietTranDau> ChiTietTranDau { get; set; }
    }
}