namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_nhap_an_pham
    {
        [Key]
        public int ma_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay { get; set; }

        [Required]
        [StringLength(50)]
        public string serial { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_tcnx { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_nguon_von { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_ly_do { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_kho { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_kho_nx { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_kho_nx { get; set; }

        [Required]
        [StringLength(100)]
        public string dia_chi_kho_nx { get; set; }

        [Required]
        [StringLength(20)]
        public string so_hdtc { get; set; }

        [Required]
        [StringLength(20)]
        public string ky_hieu_hdtc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_hdtc { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_sach { get; set; }

        [Required]
        [StringLength(200)]
        public string ten { get; set; }

        public double so_luong { get; set; }

        public double don_gia { get; set; }

        public double vat { get; set; }

        public double chiet_khau { get; set; }

        public double thanh_tien { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu { get; set; }

        [Required]
        [StringLength(100)]
        public string ghi_chu0 { get; set; }

        [Required]
        [StringLength(100)]
        public string ghi_chu1 { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }

        public bool is_bien_muc { get; set; }

        public bool is_dk_ca_biet { get; set; }
    }
}
