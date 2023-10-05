using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class ActiveSector
    {
        public ActiveSector()
        {
            Cns = new HashSet<Student>();
        }

        public int IdActiveSector { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Student> Cns { get; set; }
    }
}
