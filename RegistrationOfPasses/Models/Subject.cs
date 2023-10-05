using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Subject
    {
        public Subject()
        {
            ListAcademicDebts = new HashSet<ListAcademicDebt>();
            SubjectTeachers = new HashSet<SubjectTeacher>();
        }

        public int IdSubject { get; set; }
        public string Name { get; set; } = null!;
        public string? FullName { get; set; }
        public bool? Optional { get; set; }
        public int? TotalHourCount { get; set; }
        public int? PracticHourCount { get; set; }

        public virtual ICollection<ListAcademicDebt> ListAcademicDebts { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
