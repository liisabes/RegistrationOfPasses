using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class ListPaidWorkingOff
    {
        public int IdStudentSkip { get; set; }
        public float? CountHour { get; set; }
        public decimal? Summa { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DatePay { get; set; }
        public DateTime? DateWork { get; set; }
        public string? Mark { get; set; }
        public bool? Status { get; set; }
        public DateTime? DatePass { get; set; }

        public virtual StudentSkip IdStudentSkipNavigation { get; set; } = null!;
    }
}
