namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_du_toan_chi_tiet
    {
        [Key]
        public int ma_id { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(200)]
        public string ten { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_sach { get; set; }

        public double so_luong { get; set; }

        public double don_gia { get; set; }

        public double vat { get; set; }

        public double chiet_khau { get; set; }

        public double thanh_tien { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_kho { get; set; }
    }
}
