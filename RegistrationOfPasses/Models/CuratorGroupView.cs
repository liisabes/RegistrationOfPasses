using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class CuratorGroupView
    {
        public int? IdCurator { get; set; }
        public string CnG { get; set; } = null!;
        public string Group { get; set; } = null!;
        public string? CnC { get; set; }
        public string? Curator { get; set; }
        public string? Fio { get; set; }
        public bool? Budget { get; set; }
        public bool? Primary { get; set; }
        public string CnSpec { get; set; } = null!;
    }
}
