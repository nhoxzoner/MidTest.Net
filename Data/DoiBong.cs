#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class DoiBong
    {
        public DoiBong()
        {
            DSCauThu = new HashSet<CauThu>();
        }

        [Key]
        public int Id { get; set; }
        [DisplayName("Mã đội")]
        [StringLength(100)]
        public string MaDoi { get; set; }
        [DisplayName("Tên đội")]
        [StringLength(250)]
        public string TenDoi { get; set; }
        [DisplayName("Tên quốc gia")]
        [StringLength(250)]
        public string TenQuocGia { get; set; }
        [DisplayName("Số cầu thủ")]
        public int? SoCauThu { get; set; }
        public virtual ICollection<CauThu> DSCauThu { get; set; }
    }
}