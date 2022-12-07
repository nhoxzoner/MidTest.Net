#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class TranDau
    {
        public TranDau()
        {
            ChiTietTranDau = new HashSet<ChiTietTranDau>();
        }

        [Key]
        public int Id { get; set; }
        public int? DoiBongA { get; set; }
        public int? DoiBongB { get; set; }
        public int? SoBanThangA { get; set; }
        public int? SoBanThangB { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ThoiGian { get; set; }

        [ForeignKey(nameof(DoiBongA))] 
        public virtual DoiBong DoiA { get; set; }

        [ForeignKey(nameof(DoiBongB))]
        public virtual DoiBong DoiB { get; set; }

        public virtual ICollection<ChiTietTranDau> ChiTietTranDau { get; set; }
    }
}