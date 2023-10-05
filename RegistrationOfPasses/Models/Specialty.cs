using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Specialty
    {
        public Specialty()
        {
            Groups = new HashSet<Group>();
        }

        public string CnSpec { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? FullName { get; set; }
        public int? EducationPeriod { get; set; }
        public string? Department { get; set; }
        public string? CnT { get; set; }

        public virtual Teacher? CnTNavigation { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
