using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class WcbcoreDonViTinh
    {
        public WcbcoreDonViTinh()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBieuGhiLuuTruTonKhos = new HashSet<WcbcoreBieuGhiLuuTruTonKho>();
            WcbcoreBieuGhiTonKhos = new HashSet<WcbcoreBieuGhiTonKho>();
            WcbcorePhieuBaoHanhCuaBbgns = new HashSet<WcbcorePhieuBaoHanhCuaBbgn>();
            WcbcoreSanPhamCuaBbgns = new HashSet<WcbcoreSanPhamCuaBbgn>();
            WcbcoreSanPhamCuaCckmDonViTinhKms = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaCckmDonViTinhs = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaDhbls = new HashSet<WcbcoreSanPhamCuaDhbl>();
            WcbcoreSanPhamCuaPxks = new HashSet<WcbcoreSanPhamCuaPxk>();
            WcbcoreSanPhamCuaSoDuDauKies = new HashSet<WcbcoreSanPhamCuaSoDuDauKy>();
            WcbcoreSanPhamCuaTiepNhanHangHoas = new HashSet<WcbcoreSanPhamCuaTiepNhanHangHoa>();
            WcbcoreSanPhamDonViCoSos = new HashSet<WcbcoreSanPham>();
            WcbcoreSanPhamDonViQuyDoi1s = new HashSet<WcbcoreSanPham>();
            WcbcoreSanPhamDonViQuyDoi2s = new HashSet<WcbcoreSanPham>();
            WcbcoreSanPhamDonViTinhs = new HashSet<WcbcoreSanPham>();
            WcbcoreSanPhamKmDhbls = new HashSet<WcbcoreSanPhamKmDhbl>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string Ma { get; set; } = null!;
        public string Ten { get; set; } = null!;
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreBieuGhiLuuTruTonKho> WcbcoreBieuGhiLuuTruTonKhos { get; set; }
        public virtual ICollection<WcbcoreBieuGhiTonKho> WcbcoreBieuGhiTonKhos { get; set; }
        public virtual ICollection<WcbcorePhieuBaoHanhCuaBbgn> WcbcorePhieuBaoHanhCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaBbgn> WcbcoreSanPhamCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmDonViTinhKms { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmDonViTinhs { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaDhbl> WcbcoreSanPhamCuaDhbls { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaPxk> WcbcoreSanPhamCuaPxks { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaSoDuDauKy> WcbcoreSanPhamCuaSoDuDauKies { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaTiepNhanHangHoa> WcbcoreSanPhamCuaTiepNhanHangHoas { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamDonViCoSos { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamDonViQuyDoi1s { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamDonViQuyDoi2s { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamDonViTinhs { get; set; }
        public virtual ICollection<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhbls { get; set; }
    }
}
