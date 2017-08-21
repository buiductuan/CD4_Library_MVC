namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_last_code
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nam { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ma { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ten { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string code_id { get; set; }
    }
}
