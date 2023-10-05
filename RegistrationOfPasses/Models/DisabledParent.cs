using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class DisabledParent
    {
        public int CnS { get; set; }
        public string? Remarks { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
