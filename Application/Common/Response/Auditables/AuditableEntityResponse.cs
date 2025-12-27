namespace Application.Common.Response.Auditables
{
    public class AuditableEntityResponse
    {
        public DateTimeOffset CreatedAt { get; private set; }
        public DateTimeOffset? UpdatedAt { get; private set; }
        public DateTimeOffset? DeletedAt { get; private set; }

        public AuditableEntityResponse(
            DateTimeOffset createdAt,
            DateTimeOffset? updatedAt,
            DateTimeOffset? deletedAt)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
        }
    }
}
