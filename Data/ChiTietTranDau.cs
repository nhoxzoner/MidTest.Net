#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class ChiTietTranDau
    {
        [Key]
        [DisplayName("Trận đấu")]
        public int IdTranDau { get; set; }
        [DisplayName("Cầu thủ")]
        [Key]
        public int IdCauThu { get; set; }
        [DisplayName("Số bàn thắng")]
        public int? SoBanThang { get; set; }

        [ForeignKey(nameof(IdCauThu))]
        [DisplayName("Cầu thủ")]
        public virtual CauThu CauThu { get; set; }
        [ForeignKey(nameof(IdTranDau))]
        [DisplayName("Trận đấu")]
        public virtual TranDau TranDau { get; set; }
    }
}