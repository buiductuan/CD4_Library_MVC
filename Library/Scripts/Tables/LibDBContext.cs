namespace Library.Tables
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibDBContext : DbContext
    {
        public LibDBContext()
            : base("name=LibDBContext")
        {
        }

        public virtual DbSet<library_bien_ban_kiem_ke> library_bien_ban_kiem_ke { get; set; }
        public virtual DbSet<library_dang_ky_ca_biet> library_dang_ky_ca_biet { get; set; }
        public virtual DbSet<library_danh_muc> library_danh_muc { get; set; }
        public virtual DbSet<library_dm_chung> library_dm_chung { get; set; }
        public virtual DbSet<Library_Ds_Ngay_Nghi> Library_Ds_Ngay_Nghi { get; set; }
        public virtual DbSet<library_du_toan> library_du_toan { get; set; }
        public virtual DbSet<library_du_toan_chi_tiet> library_du_toan_chi_tiet { get; set; }
        public virtual DbSet<library_kiem_ke> library_kiem_ke { get; set; }
        public virtual DbSet<library_nhap_an_pham> library_nhap_an_pham { get; set; }
        public virtual DbSet<library_phat_the_doc> library_phat_the_doc { get; set; }
        public virtual DbSet<library_phieu_muon_tra> library_phieu_muon_tra { get; set; }
        public virtual DbSet<library_phong_doc_mo> library_phong_doc_mo { get; set; }
        public virtual DbSet<library_ton_tuc_thoi> library_ton_tuc_thoi { get; set; }
        public virtual DbSet<library_tham_so_muon> library_tham_so_muon { get; set; }
        public virtual DbSet<library_the_doc> library_the_doc { get; set; }
        public virtual DbSet<sys_grid_config> sys_grid_config { get; set; }
        public virtual DbSet<sys_users> sys_users { get; set; }
        public virtual DbSet<sys_variable> sys_variable { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<Library_Code_Ma_An_Pham> Library_Code_Ma_An_Pham { get; set; }
        public virtual DbSet<Library_last_code> Library_last_code { get; set; }
        public virtual DbSet<Sys_Last_Code_ID> Sys_Last_Code_ID { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<library_bien_ban_kiem_ke>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dang_ky_ca_biet>()
                .Property(e => e.ma_ca_biet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dang_ky_ca_biet>()
                .Property(e => e.ma_trang_thai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dang_ky_ca_biet>()
                .Property(e => e.ma_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dang_ky_ca_biet>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dang_ky_ca_biet>()
                .Property(e => e.loai_phieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_ngon_ngu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_tac_gia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.nam_xuat_ban)
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_nha_xb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.tap_so)
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_cap_hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_khoi_hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_mon_hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_linh_vuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_loai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_nhom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_size)
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.size_ma_ca_biet)
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.ma_ca_biet)
                .IsUnicode(false);

            modelBuilder.Entity<library_danh_muc>()
                .Property(e => e.so_trang)
                .IsUnicode(false);

            modelBuilder.Entity<library_dm_chung>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dm_chung>()
                .Property(e => e.ma_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_dm_chung>()
                .Property(e => e.table_name)
                .IsUnicode(false);

            modelBuilder.Entity<Library_Ds_Ngay_Nghi>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_du_toan>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_du_toan_chi_tiet>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_du_toan_chi_tiet>()
                .Property(e => e.ma_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_du_toan_chi_tiet>()
                .Property(e => e.ma_kho)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_kiem_ke>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_kiem_ke>()
                .Property(e => e.ma_ca_biet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_kiem_ke>()
                .Property(e => e.ma_tinh_trang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_tcnx)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_nguon_von)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_ly_do)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_kho)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_kho_nx)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_nhap_an_pham>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phat_the_doc>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phat_the_doc>()
                .Property(e => e.ma_the_doc)
                .IsUnicode(false);

            modelBuilder.Entity<library_phat_the_doc>()
                .Property(e => e.loai_the)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phat_the_doc>()
                .Property(e => e.ma_ly_do)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phat_the_doc>()
                .Property(e => e.ma_hinh_thuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_the_doc)
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.loai_the)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_ca_biet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_tinh_trang0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.ma_tinh_trang1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.kieu_muon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.gio_muon)
                .IsUnicode(false);

            modelBuilder.Entity<library_phieu_muon_tra>()
                .Property(e => e.gio_tra)
                .IsUnicode(false);

            modelBuilder.Entity<library_phong_doc_mo>()
                .Property(e => e.ma_hd)
                .IsUnicode(false);

            modelBuilder.Entity<library_phong_doc_mo>()
                .Property(e => e.ma_the_doc)
                .IsUnicode(false);

            modelBuilder.Entity<library_phong_doc_mo>()
                .Property(e => e.gio)
                .IsUnicode(false);

            modelBuilder.Entity<library_phong_doc_mo>()
                .Property(e => e.gio0)
                .IsUnicode(false);

            modelBuilder.Entity<library_ton_tuc_thoi>()
                .Property(e => e.ma_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_tham_so_muon>()
                .Property(e => e.ma_hd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_tham_so_muon>()
                .Property(e => e.ma_doi_tuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_the_doc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_the_doc>()
                .Property(e => e.barcode)
                .IsUnicode(false);

            modelBuilder.Entity<library_the_doc>()
                .Property(e => e.ngay_sinh)
                .IsUnicode(false);

            modelBuilder.Entity<library_the_doc>()
                .Property(e => e.ma_loai_the)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<library_the_doc>()
                .Property(e => e.ma_trang_thai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.code_id)
                .IsFixedLength();

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.name_source)
                .IsUnicode(false);

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.col_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.alignment)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.format)
                .IsUnicode(false);

            modelBuilder.Entity<sys_grid_config>()
                .Property(e => e.type_editor)
                .IsUnicode(false);

            modelBuilder.Entity<sys_users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<sys_variable>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_variable>()
                .Property(e => e.variable)
                .IsUnicode(false);

            modelBuilder.Entity<sys_variable>()
                .Property(e => e.types)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_variable>()
                .Property(e => e.groups)
                .IsUnicode(false);

            modelBuilder.Entity<sys_variable>()
                .Property(e => e.checksum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Version>()
                .Property(e => e.Version1)
                .IsUnicode(false);

            modelBuilder.Entity<Library_last_code>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Last_Code_ID>()
                .Property(e => e.table_name)
                .IsUnicode(false);
        }
    }
}
