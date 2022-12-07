#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidTest.Net.Data
{
    public partial class ViTri
    {
        public ViTri()
        {
            CauThu = new HashSet<CauThu>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string TenViTri { get; set; }

        public virtual ICollection<CauThu> CauThu { get; set; }
    }
}