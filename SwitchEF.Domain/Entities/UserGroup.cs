using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class UserGroup
    {
        public DateTime DateCreated { get; set; }
        public bool Admin { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
