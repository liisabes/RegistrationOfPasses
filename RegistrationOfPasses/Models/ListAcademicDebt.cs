using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class ListAcademicDebt
    {
        public int CnS { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DateWork { get; set; }
        public DateTime? DatePay { get; set; }
        public decimal? Summa { get; set; }
        public bool? Status { get; set; }
        public float? CountHour { get; set; }
        public string? Mark { get; set; }
        public int IdEmpForm { get; set; }
        public string CnT { get; set; } = null!;
        public int IdSubject { get; set; }
        public int IdListAcademicDebt { get; set; }
        public int? CauseGive { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual Teacher CnTNavigation { get; set; } = null!;
        public virtual EmpForm IdEmpFormNavigation { get; set; } = null!;
        public virtual Subject IdSubjectNavigation { get; set; } = null!;
    }
}
