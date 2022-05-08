using BlazorSozluk.Common.ViewModels.Enums;

namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryCommentVote : BaseEntity
    {
        public Guid EntryCommentId { get; set; }
        public VoteType VoteType { get; set; }
        public Guid CreatedById { get; set; }
        public virtual EntryComments EntryComments { get; set; }
    }

}
