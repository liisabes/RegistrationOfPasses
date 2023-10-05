using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class StudentSkipView2
    {
        public string? Date { get; set; }
        public string? Student { get; set; }
        public string SubName { get; set; } = null!;
        public float? CountHour { get; set; }
        public string EmpName { get; set; } = null!;
        public int IdListAcademicDebt { get; set; }
        public string? Mark { get; set; }
        public bool? Status { get; set; }
        public string CnT { get; set; } = null!;
        public string GroupName { get; set; } = null!;
    }
}
