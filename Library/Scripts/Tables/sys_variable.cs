namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_variable
    {
        [Key]
        public int ma_id { get; set; }

        [Required]
        [StringLength(4)]
        public string ma { get; set; }

        [Required]
        [StringLength(30)]
        public string variable { get; set; }

        [Required]
        [StringLength(100)]
        public string comments { get; set; }

        [Required]
        [StringLength(1)]
        public string types { get; set; }

        [Required]
        [StringLength(100)]
        public string defaulvalue { get; set; }

        [Required]
        [StringLength(100)]
        public string realvalue { get; set; }

        [Required]
        [StringLength(20)]
        public string groups { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }

        [Required]
        [StringLength(32)]
        public string checksum { get; set; }
    }
}
