﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcocde
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBHangHoaEntitiesNH : DbContext
    {
        public DBHangHoaEntitiesNH(string v)
            : base("name=DBHangHoaEntitiesNH")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaoCaoKiemKe> BaoCaoKiemKes { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KeHang> KeHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<KiemKeHangHoa> KiemKeHangHoas { get; set; }
        public virtual DbSet<NganhHang> NganhHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhomHang> NhomHangs { get; set; }
        public virtual DbSet<PhanCongKiemKe> PhanCongKiemKes { get; set; }
        public virtual DbSet<PhanNhomHang> PhanNhomHangs { get; set; }
        public virtual DbSet<PLU> PLUs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DuyetHangHoa> DuyetHangHoas { get; set; }
    }
}
