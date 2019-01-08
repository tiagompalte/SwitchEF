using SwitchEF.Domain.Enums;
using System;

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
    }
}
