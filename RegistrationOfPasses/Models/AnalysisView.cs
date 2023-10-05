using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AnalysisView
    {
        public int IdAnalysis { get; set; }
        public string Group { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string? Teacher { get; set; }
        public float? QualitativeProgress { get; set; }
        public float? AbsoluteProgress { get; set; }
        public DateTime? AnalisysDate { get; set; }
        public int? NumberOkr { get; set; }
        public string CnT { get; set; } = null!;
        public int IdCk { get; set; }
    }
}
