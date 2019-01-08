using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchEF.Domain.Entities
{
    public class Workplace
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public bool ActualJob { get; set; }
    }
}
