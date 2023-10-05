using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class OkrView
    {
        public string Subject { get; set; } = null!;
        public string Group { get; set; } = null!;
        public int? NumberOkr { get; set; }
        public DateTime? AnalisysDate { get; set; }
        public float? QualitativeProgress { get; set; }
        public float? AbsoluteProgress { get; set; }
        public string CnT { get; set; } = null!;
        public int IdSubjectTeacher { get; set; }
        public int IdAnalysis { get; set; }
    }
}
