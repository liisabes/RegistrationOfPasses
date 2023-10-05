using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class ViewForPrint
    {
        public string NameSpec { get; set; } = null!;
        public string? Fio { get; set; }
        public string GroupName { get; set; } = null!;
    }
}
