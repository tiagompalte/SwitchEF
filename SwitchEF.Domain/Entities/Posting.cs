using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class Posting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public string ContentUrl { get; set; }
    }
}
