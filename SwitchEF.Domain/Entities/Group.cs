using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Posting> Postings { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}
