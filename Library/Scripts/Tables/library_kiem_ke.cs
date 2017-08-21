namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_kiem_ke
    {
        [Key]
        public int ma_id { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_ca_biet { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_tinh_trang { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
