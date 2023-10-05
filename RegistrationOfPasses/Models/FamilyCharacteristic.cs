using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class FamilyCharacteristic
    {
        public int IdFamily { get; set; }
        public int CnS { get; set; }
        public int IdType { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual FamilyType IdTypeNavigation { get; set; } = null!;
    }
}
