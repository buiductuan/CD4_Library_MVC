namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_danh_muc
    {
        [Key]
        [StringLength(4)]
        public string ma { get; set; }

        [Required]
        [StringLength(250)]
        public string ten { get; set; }

        [Required]
        [StringLength(250)]
        public string ten0 { get; set; }

        [Required]
        [StringLength(20)]
        public string ky_hieu { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_vtat { get; set; }

        [Required]
        [StringLength(20)]
        public string serial { get; set; }

        [Required]
        [StringLength(10)]
        public string dvt { get; set; }

        [Required]
        [StringLength(200)]
        public string noi_dung { get; set; }

        [Required]
        [StringLength(200)]
        public string tt_trach_nhiem { get; set; }

        [Required]
        [StringLength(200)]
        public string tu_khoa { get; set; }

        [Required]
        [StringLength(200)]
        public string de_muc { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_ngon_ngu { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_tac_gia { get; set; }

        [Required]
        [StringLength(100)]
        public string tac_gia { get; set; }

        [Required]
        [StringLength(300)]
        public string ds_tac_gia { get; set; }

        [Required]
        [StringLength(200)]
        public string noi_xuat_ban { get; set; }

        [Required]
        [StringLength(4)]
        public string nam_xuat_ban { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_nha_xb { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_nha_xb { get; set; }

        [Required]
        [StringLength(50)]
        public string lan_xuat_ban { get; set; }

        [Required]
        [StringLength(200)]
        public string tung_thu { get; set; }

        [Required]
        [StringLength(2)]
        public string tap_so { get; set; }

        [Required]
        [StringLength(2)]
        public string ma_cap_hoc { get; set; }

        [Required]
        [StringLength(2)]
        public string ma_khoi_hoc { get; set; }

        [Required]
        [StringLength(2)]
        public string ma_mon_hoc { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_linh_vuc { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_loai { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_nhom { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_size { get; set; }

        [Required]
        [StringLength(100)]
        public string minh_hoa { get; set; }

        [Required]
        [StringLength(100)]
        public string tai_lieu_nghe_nhin { get; set; }

        [Required]
        [StringLength(2)]
        public string size_ma_ca_biet { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_ca_biet { get; set; }

        [Required]
        [StringLength(5)]
        public string so_trang { get; set; }

        public double don_gia { get; set; }

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
        [StringLength(100)]
        public string ghi_chu2 { get; set; }

        public bool active { get; set; }

        [Required]
        [StringLength(20)]
        public string so_isbn { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_ddc { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_chu_bien { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
