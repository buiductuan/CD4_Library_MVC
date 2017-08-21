namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Version")]
    public partial class Version
    {
        [Key]
        [Column("Version")]
        [StringLength(10)]
        public string Version1 { get; set; }
    }
}
