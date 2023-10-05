using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Ck
    {
        public Ck()
        {
            Analyses = new HashSet<Analysis>();
            Teachers = new HashSet<Teacher>();
        }

        public int IdCk { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
