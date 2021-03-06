using System;
using System.Collections.Generic;

namespace ecomerce_multiplatform_app.Models
{
    public partial class SecEntityLog
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public DateTime? EventTs { get; set; }
        public Guid? UserId { get; set; }
        public string? ChangeType { get; set; }
        public string? Entity { get; set; }
        public string? EntityInstanceName { get; set; }
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
        public string? Changes { get; set; }

        public virtual SecUser? User { get; set; }
    }
}
