namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_bien_ban_kiem_ke
    {
        [Key]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [StringLength(100)]
        public string ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tu_ngay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? toi_ngay { get; set; }

        [StringLength(200)]
        public string ghi_chu { get; set; }
    }
}
