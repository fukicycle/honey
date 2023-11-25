using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Shop
    {
        public Shop()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
