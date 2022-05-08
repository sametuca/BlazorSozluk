namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryCommentFavorite : BaseEntity
    {
        public Guid EntryCommentId { get; set; }
        public Guid CreatedById { get; set; }
        public virtual EntryComments EntryComments { get; set; }
        public virtual User CreatedUser { get; set; }
    }
}
