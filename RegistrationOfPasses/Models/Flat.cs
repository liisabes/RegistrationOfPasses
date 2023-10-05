using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Flat
    {
        public int CnS { get; set; }
        public string FlatDescription { get; set; } = null!;

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
