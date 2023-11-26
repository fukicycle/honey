using System;
using System.Collections.Generic;

namespace Honey.backend.Models
{
    public partial class User
    {
        public User()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string? Icon { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
