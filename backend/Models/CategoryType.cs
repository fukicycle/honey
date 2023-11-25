using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class CategoryType
    {
        public CategoryType()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Category> Categories { get; set; }
    }
}
