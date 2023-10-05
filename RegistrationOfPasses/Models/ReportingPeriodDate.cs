using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class ReportingPeriodDate
    {
        public ReportingPeriodDate()
        {
            SphSends = new HashSet<SphSend>();
        }

        public int IdPeriod { get; set; }
        public DateTime DateSph { get; set; }

        public virtual ICollection<SphSend> SphSends { get; set; }
    }
}
