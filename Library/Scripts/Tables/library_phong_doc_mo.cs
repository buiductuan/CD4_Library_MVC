namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_phong_doc_mo
    {
        [Key]
        [StringLength(20)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_the_doc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay { get; set; }

        [Required]
        [StringLength(20)]
        public string gio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay0 { get; set; }

        [Required]
        [StringLength(20)]
        public string gio0 { get; set; }

        [StringLength(200)]
        public string ghi_chu { get; set; }
    }
}
