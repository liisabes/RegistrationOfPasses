using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SubjectGroupView
    {
        public string CnG { get; set; } = null!;
        public int IdSubjectTeacher { get; set; }
        public string? FullName { get; set; }
    }
}
