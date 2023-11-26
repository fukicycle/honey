using System;
using System.Collections.Generic;

namespace Honey.backend.Models
{
    public partial class UnitType
    {
        public UnitType()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Unit { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
