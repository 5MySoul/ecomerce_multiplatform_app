﻿using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class WcbcoreLoaiBaoHanh
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string Ten { get; set; } = null!;
        public string? GhiChu { get; set; }
    }
}
