using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Curators = new HashSet<Curator>();
            ListAcademicDebts = new HashSet<ListAcademicDebt>();
            Specialties = new HashSet<Specialty>();
            SubjectTeachers = new HashSet<SubjectTeacher>();
        }

        public string CnT { get; set; } = null!;
        public int? IdCategory { get; set; }
        public int? IdCk { get; set; }
        public bool Status { get; set; }

        public virtual Employer CnTNavigation { get; set; } = null!;
        public virtual Category? IdCategoryNavigation { get; set; }
        public virtual Ck? IdCkNavigation { get; set; }
        public virtual ICollection<Curator> Curators { get; set; }
        public virtual ICollection<ListAcademicDebt> ListAcademicDebts { get; set; }
        public virtual ICollection<Specialty> Specialties { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
