using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class WcbcoreQuanHuyen
    {
        public WcbcoreQuanHuyen()
        {
            SecUsers = new HashSet<SecUser>();
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreDiaChiGiaoDiches = new HashSet<WcbcoreDiaChiGiaoDich>();
            WcbcoreDonHangBanLeNguoiMuaQuanHuyens = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeNguoiNhanQuanHuyens = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreKhachHangs = new HashSet<WcbcoreKhachHang>();
            WcbcorePhieuXuatKhoNguoiMuaQuanHuyens = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoNguoiNhanQuanHuyens = new HashSet<WcbcorePhieuXuatKho>();
            WcbcoreXaPhuongs = new HashSet<WcbcoreXaPhuong>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? TinhThanhId { get; set; }
        public string? Ma { get; set; }
        public string? Prefix { get; set; }
        public string? Ten { get; set; }
        public string? TenDayDu { get; set; }
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual WcbcoreTinhThanh? TinhThanh { get; set; }
        public virtual ICollection<SecUser> SecUsers { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreDiaChiGiaoDich> WcbcoreDiaChiGiaoDiches { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiMuaQuanHuyens { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiNhanQuanHuyens { get; set; }
        public virtual ICollection<WcbcoreKhachHang> WcbcoreKhachHangs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiMuaQuanHuyens { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiNhanQuanHuyens { get; set; }
        public virtual ICollection<WcbcoreXaPhuong> WcbcoreXaPhuongs { get; set; }
    }
}
