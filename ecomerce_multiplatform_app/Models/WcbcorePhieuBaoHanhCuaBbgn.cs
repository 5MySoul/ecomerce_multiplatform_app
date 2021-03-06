using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class WcbcorePhieuBaoHanhCuaBbgn
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid BaoHanhId { get; set; }
        public Guid? SanPhamId { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? MaSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? DonViTinhId { get; set; }
        public string? TenDonViTinh { get; set; }
        public Guid? BienBanGiaoNhanHangHoaVoiNccId { get; set; }
        public decimal? SoLuong { get; set; }

        public virtual WcbcoreBaoHanh BaoHanh { get; set; } = null!;
        public virtual WcbcoreBienBanGiaoNhanHangHoaVoiNcc? BienBanGiaoNhanHangHoaVoiNcc { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreSanPham? SanPham { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
    }
}
