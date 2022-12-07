#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Đội bóng A")]
        public int? DoiBongA { get; set; }
        [DisplayName("Đội bóng B")]
        public int? DoiBongB { get; set; }
        [DisplayName("Bàn thắng đội A")]
        public int? SoBanThangA { get; set; }
        [DisplayName("Bàn thắng đội B")]
        public int? SoBanThangB { get; set; }

        [DisplayName("Ngày thi đấu")]
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGian { get; set; }

        [ForeignKey(nameof(DoiBongA))]
        [DisplayName("Đội bóng A")]
        public virtual DoiBong DoiA { get; set; }

        [ForeignKey(nameof(DoiBongB))]
        [DisplayName("Đội bóng B")]
        public virtual DoiBong DoiB { get; set; }

        [NotMapped]
        [DisplayName("Tên trận đấu")]
        public string TenTranDau { get
            {
                if (DoiA != null && DoiB != null)
                {
                    return string.Format("{0} - {1}", DoiA.TenDoi, DoiB.TenDoi);
                }

                return "";
            }
        }
        
        public virtual ICollection<ChiTietTranDau> ChiTietTranDau { get; set; }
    }
}