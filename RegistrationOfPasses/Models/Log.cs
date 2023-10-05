using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Log
    {
        public int IdLog { get; set; }
        public DateTime? Datetime { get; set; }
        public string TypeOperation { get; set; } = null!;
        public string? CnA { get; set; }

        public virtual AdminBase? CnANavigation { get; set; }
    }
}
