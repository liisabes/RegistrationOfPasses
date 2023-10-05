using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SubjTeachView
    {
        public int IdSubjectTeacher { get; set; }
        public int IdSubject { get; set; }
        public string Subject { get; set; } = null!;
        public string? SubjectFull { get; set; }
        public string CnG { get; set; } = null!;
        public string Group { get; set; } = null!;
        public string CnT { get; set; } = null!;
        public string Teacher { get; set; } = null!;
        public string? Fio { get; set; }
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
    }
}
