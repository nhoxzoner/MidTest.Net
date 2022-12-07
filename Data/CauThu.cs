#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tên cầu thủ")]
        [StringLength(250)]
        public string TenCauThu { get; set; }
        [DisplayName("Số áo")]
        public int? SoAo { get; set; }

        [DisplayName("Vị trí")]
        public int? IdViTri { get; set; }

        [DisplayName("Đội bóng")]
        public int? IdDoiBong { get; set; }

        [DisplayName("Đội bóng")]
        [ForeignKey(nameof(IdDoiBong))]
        public virtual DoiBong DoiBong { get; set; }

        [DisplayName("Vị trí")]
        [ForeignKey(nameof(IdViTri))]
        public virtual ViTri ViTri { get; set; }
        public virtual ICollection<ChiTietTranDau> ChiTietTranDau { get; set; }
    }
}