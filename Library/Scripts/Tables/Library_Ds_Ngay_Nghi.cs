namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_Ds_Ngay_Nghi
    {
        [Key]
        [StringLength(4)]
        public string ma_hd { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tu_ngay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? den_ngay { get; set; }

        public int kieu_thoi_gian { get; set; }

        public bool thu2 { get; set; }

        public bool thu3 { get; set; }

        public bool thu4 { get; set; }

        public bool thu5 { get; set; }

        public bool thu6 { get; set; }

        public bool thu7 { get; set; }

        public bool thu8 { get; set; }
    }
}
