using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SubjectTeacher
    {
        public SubjectTeacher()
        {
            Analyses = new HashSet<Analysis>();
            Monitorings = new HashSet<Monitoring>();
            StudentSkips = new HashSet<StudentSkip>();
        }

        public int IdSubjectTeacher { get; set; }
        public int IdSubject { get; set; }
        public string CnG { get; set; } = null!;
        public string CnT { get; set; } = null!;
        public int? ConsultHourCount { get; set; }
        public float? AddControlHourCount { get; set; }

        public virtual Group CnGNavigation { get; set; } = null!;
        public virtual Teacher CnTNavigation { get; set; } = null!;
        public virtual Subject IdSubjectNavigation { get; set; } = null!;
        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual ICollection<Monitoring> Monitorings { get; set; }
        public virtual ICollection<StudentSkip> StudentSkips { get; set; }
    }
}
