namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_du_toan
    {
        [Key]
        [StringLength(10)]
        public string ma_hd { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay { get; set; }

        [Required]
        [StringLength(20)]
        public string serial { get; set; }

        [Required]
        [StringLength(200)]
        public string dien_giai { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu0 { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu1 { get; set; }

        [Required]
        [StringLength(200)]
        public string ghi_chu2 { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
