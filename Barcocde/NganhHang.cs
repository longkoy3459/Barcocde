//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NganhHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NganhHang()
        {
            this.HangHoas = new HashSet<HangHoa>();
            this.NhomHangs = new HashSet<NhomHang>();
        }
    
        public string MaNganh { get; set; }
        public string MaGoiNho { get; set; }
        public string TenNganh { get; set; }
        public string MoTa { get; set; }
        public string MaNVNhap { get; set; }
        public System.DateTime NgayTao { get; set; }
        public string MaNVCapNhat { get; set; }
        public System.DateTime NgayCapNhat { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> PTTinhGia { get; set; }
        public Nullable<int> PTTinhLai { get; set; }
        public Nullable<int> PTQuanLy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhomHang> NhomHangs { get; set; }
    }
}