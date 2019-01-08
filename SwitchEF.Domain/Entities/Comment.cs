using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; private set; }

        public Comment()
        {
            Date = DateTime.Now;
        }

        public void setUser(User user)
        {
            if(user != null) {
                User = user;
            }
        }

    }
}
