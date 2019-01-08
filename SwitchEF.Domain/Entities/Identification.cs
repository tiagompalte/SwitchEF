using SwitchEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class Identification
    {
        public int Id { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
