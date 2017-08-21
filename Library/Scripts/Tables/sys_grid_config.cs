namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_grid_config
    {
        [Key]
        [StringLength(4)]
        public string code_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name_source { get; set; }

        [Required]
        [StringLength(20)]
        public string col_name { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        public bool enable { get; set; }

        public bool visible { get; set; }

        [Column("readonly")]
        public bool _readonly { get; set; }

        public int width { get; set; }

        [Required]
        [StringLength(2)]
        public string alignment { get; set; }

        [Required]
        [StringLength(15)]
        public string format { get; set; }

        [Required]
        [StringLength(15)]
        public string type_editor { get; set; }

        [Required]
        [StringLength(50)]
        public string tooltip { get; set; }
    }
}
