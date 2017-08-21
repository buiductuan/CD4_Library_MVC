namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_dm_chung
    {
        [Key]
        [StringLength(4)]
        public string ma { get; set; }

        [Required]
        [StringLength(80)]
        public string ten { get; set; }

        [Required]
        [StringLength(20)]
        public string ky_hieu { get; set; }

        [Required]
        [StringLength(100)]
        public string ghi_chu { get; set; }

        public bool active { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_parent { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }

        [Required]
        [StringLength(50)]
        public string table_name { get; set; }

        public int last_code { get; set; }
    }
}
