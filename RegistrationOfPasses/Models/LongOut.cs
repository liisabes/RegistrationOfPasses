using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class LongOut
    {
        public int CnS { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public string AbsenceReason { get; set; } = null!;

        public virtual AbsenceReason AbsenceReasonNavigation { get; set; } = null!;
        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
