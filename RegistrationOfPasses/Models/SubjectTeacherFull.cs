using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SubjectTeacherFull
    {
        public string CnG { get; set; } = null!;
        public int IdSubjectTeacher { get; set; }
        public string Subject { get; set; } = null!;
        public string? SubjectFull { get; set; }
        public string Group { get; set; } = null!;
        public string CnT { get; set; } = null!;
        public int? TotalHourCount { get; set; }
        public int? PracticHourCount { get; set; }
        public int? ConsultHourCount { get; set; }
        public float? AddControlHourCount { get; set; }
    }
}
