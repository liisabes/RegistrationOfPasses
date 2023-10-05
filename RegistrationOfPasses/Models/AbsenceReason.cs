using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AbsenceReason
    {
        public AbsenceReason()
        {
            LongOuts = new HashSet<LongOut>();
        }

        public string AbsenceReason1 { get; set; } = null!;

        public virtual ICollection<LongOut> LongOuts { get; set; }
    }
}
