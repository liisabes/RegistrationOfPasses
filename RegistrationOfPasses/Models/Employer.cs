using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Employer
    {
        public string CnE { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;

        public virtual AdminBase? AdminBase { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
