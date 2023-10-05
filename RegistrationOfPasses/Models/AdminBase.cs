using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AdminBase
    {
        public AdminBase()
        {
            Logs = new HashSet<Log>();
        }

        public string CnA { get; set; } = null!;

        public virtual Employer CnANavigation { get; set; } = null!;
        public virtual ICollection<Log> Logs { get; set; }
    }
}
