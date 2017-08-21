namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_ton_tuc_thoi
    {
        [Key]
        public int record_id { get; set; }

        [Required]
        [StringLength(4)]
        public string ma_sach { get; set; }

        public double so_luong { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        public DateTime? edit_date { get; set; }
    }
}
