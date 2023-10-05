using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class FamilyVisitInfo
    {
        public int CnS { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public string HouseCharacteristics { get; set; } = null!;
        public string LivingConditions { get; set; } = null!;

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
