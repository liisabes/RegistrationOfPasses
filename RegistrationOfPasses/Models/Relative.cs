using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Relative
    {
        public int IdRelative { get; set; }
        public string Fio { get; set; } = null!;
        public string? WorkStudyPlace { get; set; }
        public DateTime? YearBirth { get; set; }
        public int CnS { get; set; }
        public int IdRf { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual RelativeForm IdRfNavigation { get; set; } = null!;
    }
}
