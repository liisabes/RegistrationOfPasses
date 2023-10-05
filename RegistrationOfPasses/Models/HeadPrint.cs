using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class HeadPrint
    {
        public string? FullName { get; set; }
        public string CnG { get; set; } = null!;
        public string? Teacher { get; set; }
        public int IdSubjectTeacher { get; set; }
    }
}
