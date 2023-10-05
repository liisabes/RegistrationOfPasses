using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class StudentFiogroup
    {
        public string? StudentFio { get; set; }
        public string GroupName { get; set; } = null!;
        public int CnS { get; set; }
    }
}
