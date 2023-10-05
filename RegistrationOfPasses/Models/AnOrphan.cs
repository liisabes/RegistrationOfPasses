using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AnOrphan
    {
        public int CnS { get; set; }
        public bool? StateSupport { get; set; }
        public bool? FosterFamily { get; set; }
        public bool? Guardianship { get; set; }
        public bool? Trusteeship { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
