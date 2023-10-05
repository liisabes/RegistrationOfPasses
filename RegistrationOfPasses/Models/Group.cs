using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Group
    {
        public Group()
        {
            Curators = new HashSet<Curator>();
            SphSends = new HashSet<SphSend>();
            Students = new HashSet<Student>();
            SubjectTeachers = new HashSet<SubjectTeacher>();
        }

        public string CnG { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Cours { get; set; }
        public bool? Budget { get; set; }
        public string CnSpec { get; set; } = null!;

        public virtual Specialty CnSpecNavigation { get; set; } = null!;
        public virtual ICollection<Curator> Curators { get; set; }
        public virtual ICollection<SphSend> SphSends { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
