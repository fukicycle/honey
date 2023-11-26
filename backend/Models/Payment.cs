using System;
using System.Collections.Generic;

namespace Honey.backend.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public int ShopId { get; set; }
        public int Amount { get; set; }
        public int Count { get; set; }
        public int UnitTypeId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Shop Shop { get; set; } = null!;
        public virtual UnitType UnitType { get; set; } = null!;
    }
}
