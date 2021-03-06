using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class WcbcoreBieuGhiTonKho
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public int? Loai { get; set; }
        public string? IdChungTu { get; set; }
        public Guid SanPhamId { get; set; }
        public string? MaSanPham { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? KhoHangId { get; set; }
        public Guid? DonViTinhId { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? Huong { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? TongSoLuong { get; set; }
        public decimal? SoTien { get; set; }
        public int? TrangThai { get; set; }
        public string? IdChungTuGoc { get; set; }
        public DateTime? BaoHanh { get; set; }

        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreKhoHang? KhoHang { get; set; }
        public virtual WcbcoreSanPham SanPham { get; set; } = null!;
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
    }
}
