namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_the_doc
    {
        [Key]
        [StringLength(4)]
        public string ma { get; set; }

        [Required]
        [StringLength(20)]
        public string serial { get; set; }

        [Required]
        [StringLength(20)]
        public string barcode { get; set; }

        [Required]
        [StringLength(30)]
        public string ho_dem { get; set; }

        [Required]
        [StringLength(20)]
        public string ten { get; set; }

        [Required]
        [StringLength(5)]
        public string gioi_tinh { get; set; }

        [Required]
        [StringLength(10)]
        public string ngay_sinh { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu { get; set; }

        [Required]
        [StringLength(50)]
        public string ghi_chu0 { get; set; }

        [Required]
        [StringLength(50)]
        public string ghi_chu1 { get; set; }

        [Required]
        [StringLength(50)]
        public string ghi_chu2 { get; set; }

        [Required]
        [StringLength(50)]
        public string ghi_chu3 { get; set; }

        [Required]
        [StringLength(1)]
        public string ma_loai_the { get; set; }

        [Required]
        [StringLength(1)]
        public string ma_trang_thai { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? hansd_tu { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? hansd_toi { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
