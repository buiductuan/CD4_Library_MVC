namespace Library.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class library_dang_ky_ca_biet
    {
        [Key]
        public int ma_id { get; set; }

        public int? id_hoa_don { get; set; }

        [StringLength(4)]
        public string ma_ca_biet { get; set; }

        [StringLength(20)]
        public string ky_hieu_ca_biet { get; set; }

        [StringLength(200)]
        public string dac_tinh { get; set; }

        [StringLength(200)]
        public string ghi_chu { get; set; }

        [StringLength(4)]
        public string ma_trang_thai { get; set; }

        public bool active { get; set; }

        [StringLength(4)]
        public string ma_sach { get; set; }

        [StringLength(10)]
        public string ma_hd { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngay_giam { get; set; }

        [StringLength(20)]
        public string serial { get; set; }

        [StringLength(1)]
        public string loai_phieu { get; set; }
    }
}
