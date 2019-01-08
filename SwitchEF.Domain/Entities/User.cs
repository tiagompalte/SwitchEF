using SwitchEF.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SwitchEF.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public string PhotoUrl { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public virtual Identification Identification { get; set; }
        public virtual ICollection<Posting> Postings { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<Workplace> Workplaces { get; set; }
        public virtual ICollection<EducationalInstitution> EducationalInstitutions { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
