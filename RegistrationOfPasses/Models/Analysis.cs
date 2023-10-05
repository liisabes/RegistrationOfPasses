using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Analysis
    {
        public int IdAnalysis { get; set; }
        public int IdCk { get; set; }
        public int? IdMonitoringForm { get; set; }
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

        public virtual Ck IdCkNavigation { get; set; } = null!;
        public virtual MonitoringForm? IdMonitoringFormNavigation { get; set; }
        public virtual SubjectTeacher IdSubjectTeacherNavigation { get; set; } = null!;
    }
}
