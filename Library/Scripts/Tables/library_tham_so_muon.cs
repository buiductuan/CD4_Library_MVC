namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_tham_so_muon
    {
        [Key]
        [StringLength(4)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(2)]
        public string ma_doi_tuong { get; set; }

        [Required]
        [StringLength(50)]
        public string ten_doi_tuong { get; set; }

        public int so_luong_max { get; set; }

        public int thoi_gian_max { get; set; }

        public bool kieu_muon { get; set; }
    }
}
