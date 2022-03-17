using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class SysConfig
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
