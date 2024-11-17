//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace template.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CTDATHANGs = new HashSet<CTDATHANG>();
            this.VIETSACHes = new HashSet<VIETSACH>();
        }
    
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<decimal> DonGia { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
        public string HinhMinhHoa { get; set; }
        public Nullable<int> MaCD { get; set; }
        public Nullable<int> MaNXB { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public Nullable<int> SoLanXem { get; set; }
    
        public virtual CHUDE CHUDE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
