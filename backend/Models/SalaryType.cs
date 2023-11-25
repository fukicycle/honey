using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class SalaryType
    {
        public SalaryType()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
