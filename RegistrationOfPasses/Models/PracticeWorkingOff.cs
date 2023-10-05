using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class PracticeWorkingOff
    {
        public int IdPracticeWorkingOff { get; set; }
        public DateTime Date { get; set; }
        public int CountWorkingOffHours { get; set; }
        public string? Note { get; set; }
        public int CnS { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
