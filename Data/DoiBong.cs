#nullable disable
using System;
using System.Collections.Generic;
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
        [StringLength(100)]
        public string MaDoi { get; set; }
        [StringLength(250)]
        public string TenDoi { get; set; }
        [StringLength(250)]
        public string TenQuocGia { get; set; }
        public int? SoCauThu { get; set; }
        public virtual ICollection<CauThu> DSCauThu { get; set; }
    }
}