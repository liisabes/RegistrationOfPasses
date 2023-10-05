using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AnalysisFull
    {
        public int IdAnalysis { get; set; }
        public int IdCk { get; set; }
        public int IdSubjectTeacher { get; set; }
        public int? NumberOkr { get; set; }
        public DateTime? AnalysisDate { get; set; }
        public int? Mark10 { get; set; }
        public int? Mark9 { get; set; }
        public int? Mark8 { get; set; }
        public int? Mark7 { get; set; }
        public int? Mark6 { get; set; }
        public int? Mark5 { get; set; }
        public int? Mark4 { get; set; }
        public int? Mark3 { get; set; }
        public int? Mark2 { get; set; }
        public int? Mark1 { get; set; }
        public int? Mark0 { get; set; }
        public decimal? AverageMark { get; set; }
        public decimal? QualitativeProgress { get; set; }
        public decimal? AbsoluteProgress { get; set; }
        public string? Description { get; set; }
        public string Group { get; set; } = null!;
        public string? SubjectFullName { get; set; }
        public string CnT { get; set; } = null!;
        public string? Teacher { get; set; }
        public int? CountOfComplition { get; set; }
        public string SubjectShortName { get; set; } = null!;
        public int? IdMonitoringForm { get; set; }
        public string MonitoringForm { get; set; } = null!;
    }
}
