using System;
using System.Collections.Generic;

namespace Honey.backend.Models
{
    public partial class Category
    {
        public Category()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryTypeId { get; set; }

        public virtual CategoryType CategoryType { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
