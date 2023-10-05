using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class MonitoringGroup
    {
        public string? Student { get; set; }
        public int IdMonitoringForm { get; set; }
        public int IdSubjectTeacher { get; set; }
        public string? CnG { get; set; }
        public int IdMonitoring { get; set; }
        public string? Mark { get; set; }
    }
}
