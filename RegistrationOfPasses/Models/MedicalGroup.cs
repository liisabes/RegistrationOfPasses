using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class MedicalGroup
    {
        public MedicalGroup()
        {
            Students = new HashSet<Student>();
        }

        public int IdMg { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
