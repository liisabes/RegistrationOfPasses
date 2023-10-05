using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class FamilyComposition
    {
        public int IdRelative { get; set; }
        public string Fio { get; set; } = null!;
        public DateTime YearBirth { get; set; }
        public string WorkStudyPlace { get; set; } = null!;
        public int IdRf { get; set; }
        public string PlaceOfResidence { get; set; } = null!;
        public int CnS { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual RelativeForm IdRfNavigation { get; set; } = null!;
    }
}
