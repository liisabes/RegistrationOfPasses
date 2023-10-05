using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AverageAnalysisResult
    {
        public int IdCk { get; set; }
        public double? QualitativeProgress { get; set; }
        public double? AverageMark { get; set; }
        public double? AbsoluteProgress { get; set; }
    }
}
