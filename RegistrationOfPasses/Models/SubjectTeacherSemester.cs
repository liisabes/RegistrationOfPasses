using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SubjectTeacherSemester
    {
        public int IdSubjectTeacherSemester { get; set; }
        public bool? Semester1 { get; set; }
        public bool? Semester2 { get; set; }
    }
}
