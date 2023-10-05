using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Monitoring
    {
        public int IdMonitoring { get; set; }
        public int IdSubjectTeacher { get; set; }
        public int IdMonitoringForm { get; set; }
        public int CnS { get; set; }
        public string? Mark { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual MonitoringForm IdMonitoringFormNavigation { get; set; } = null!;
        public virtual SubjectTeacher IdSubjectTeacherNavigation { get; set; } = null!;
    }
}
