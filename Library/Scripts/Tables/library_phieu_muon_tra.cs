namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_phieu_muon_tra
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

        [Required]
        [StringLength(4)]
        public string ma_sach { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_muon { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_ca_biet { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_tinh_trang0 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_hen_tra { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu0 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_tra { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_tinh_trang1 { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_gia_han { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_giam { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }

        [StringLength(1)]
        public string kieu_muon { get; set; }

        [StringLength(5)]
        public string gio_muon { get; set; }

        [StringLength(5)]
        public string gio_tra { get; set; }

        public double? ty_le { get; set; }

        public double? thanh_tien { get; set; }
    }
}
