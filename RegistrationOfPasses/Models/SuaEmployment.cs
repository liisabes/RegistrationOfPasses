using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SuaEmployment
    {
        public int IdSuaEmp { get; set; }
        public string ActivitiesForm { get; set; } = null!;
        public string Achievements { get; set; } = null!;
        public string? Note { get; set; }
        public int? CnS { get; set; }

        public virtual Student? CnSNavigation { get; set; }
    }
}
