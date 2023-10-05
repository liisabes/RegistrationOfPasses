using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class CkReport
    {
        public int IdCk { get; set; }
        public string? SubjectFullName { get; set; }
        public decimal? AverageMark { get; set; }
        public decimal? QualitativeProgress { get; set; }
        public decimal? AbsoluteProgress { get; set; }
    }
}
