#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class ChiTietTranDau
    {
        [Key]
        public int IdTranDau { get; set; }
        [Key]
        public int IdCauThu { get; set; }
        public int? SoBanThang { get; set; }

        [ForeignKey(nameof(IdCauThu))]
        public virtual CauThu CauThu { get; set; }
        [ForeignKey(nameof(IdTranDau))]
        public virtual TranDau TranDau { get; set; }
    }
}