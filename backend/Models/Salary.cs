using System;
using System.Collections.Generic;

namespace Honey.backend.Models
{
    public partial class Salary
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int SalaryTypeId { get; set; }
        public int Amount { get; set; }

        public virtual SalaryType SalaryType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
