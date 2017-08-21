namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_Code_Ma_An_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_id { get; set; }
    }
}
