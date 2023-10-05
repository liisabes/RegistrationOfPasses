using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class RelativeForm
    {
        public RelativeForm()
        {
            FamilyCompositions = new HashSet<FamilyComposition>();
            Relatives = new HashSet<Relative>();
        }

        public int IdRf { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<FamilyComposition> FamilyCompositions { get; set; }
        public virtual ICollection<Relative> Relatives { get; set; }
    }
}
