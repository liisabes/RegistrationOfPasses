using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class StudentSkipView
    {
        public int IdStudentSkip { get; set; }
        public DateTime? Date { get; set; }
        public string NameSubject { get; set; } = null!;
        public string NameEmpForm { get; set; } = null!;
        public int CountHour { get; set; }
        public string? Student { get; set; }
        public string CnT { get; set; } = null!;
    }
}
