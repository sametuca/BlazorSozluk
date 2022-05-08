﻿using BlazorSozluk.Common.ViewModels.Enums;

namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryVote:BaseEntity
    {
        public Guid EntryId { get; set; }
        public VoteType VoteType { get; set; }
        public Guid CreatedById { get; set; }
        public virtual Entry Entry { get; set; }
    }

}
