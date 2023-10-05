using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class EmpForm
    {
        public EmpForm()
        {
            ListAcademicDebts = new HashSet<ListAcademicDebt>();
            StudentSkips = new HashSet<StudentSkip>();
        }

        public int IdEmpForn { get; set; }
        public string Name { get; set; } = null!;
        public float MinCountHours { get; set; }
        public string FullName { get; set; } = null!;
        public bool CuratorUsed { get; set; }

        public virtual ICollection<ListAcademicDebt> ListAcademicDebts { get; set; }
        public virtual ICollection<StudentSkip> StudentSkips { get; set; }
    }
}
