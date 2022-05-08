using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public class Entry:BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public Guid CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual ICollection<EntryComments> EntryComments { get; set; }
        public virtual ICollection<EntryVote> EntryVote { get; set; }
        public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }

    }
}
