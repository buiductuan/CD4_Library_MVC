namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_phat_the_doc
    {
        [Key]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_the_doc { get; set; }

        [Required]
        [StringLength(1)]
        public string loai_the { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_ly_do { get; set; }

        [Required]
        [StringLength(1)]
        public string ma_hinh_thuc { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_hinh_thuc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? phat_tu_ngay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? phat_toi_ngay { get; set; }

        public double phat_so_tien { get; set; }

        [Required]
        [StringLength(500)]
        public string phat_ht_khac { get; set; }

        [Required]
        [StringLength(500)]
        public string ghi_chu { get; set; }

        [Required]
        [StringLength(20)]
        public string user_name { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
