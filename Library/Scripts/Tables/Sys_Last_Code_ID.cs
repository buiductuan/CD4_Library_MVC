namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Last_Code_ID
    {
        [Key]
        [StringLength(50)]
        public string table_name { get; set; }

        public int? code_id { get; set; }

        public int? length { get; set; }

        [StringLength(10)]
        public string prefix { get; set; }

        [StringLength(10)]
        public string suffix { get; set; }

        [StringLength(200)]
        public string ghi_chu { get; set; }
    }
}
