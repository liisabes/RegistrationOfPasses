using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class MonitoringForm
    {
        public MonitoringForm()
        {
            Analyses = new HashSet<Analysis>();
            Monitorings = new HashSet<Monitoring>();
        }

        public int IdMonitoringForm { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual ICollection<Monitoring> Monitorings { get; set; }
    }
}
