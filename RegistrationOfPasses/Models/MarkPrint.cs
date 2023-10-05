using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class MarkPrint
    {
        public string Name { get; set; } = null!;
        public string Mark { get; set; } = null!;
        public int IdMonitoringForm { get; set; }
        public int IdSubjectTeacher { get; set; }
        public string CnG { get; set; } = null!;
    }
}
