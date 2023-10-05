using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class WeekendOut
    {
        public int IdWeekendOut { get; set; }
        public int CnS { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public string Adress { get; set; } = null!;
        public string Note { get; set; } = null!;
        public bool? IsDepartured { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
