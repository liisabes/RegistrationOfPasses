using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Category
    {
        public Category()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Payment { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
