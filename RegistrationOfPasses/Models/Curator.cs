using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Curator
    {
        public int IdCurator { get; set; }
        public string CnC { get; set; } = null!;
        public string CnG { get; set; } = null!;
        public bool Primary { get; set; }

        public virtual Teacher CnCNavigation { get; set; } = null!;
        public virtual Group CnGNavigation { get; set; } = null!;
    }
}
