using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AssocialBehavior
    {
        public int IdAssocBeh { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; } = null!;
        public string NatureAssocBeh { get; set; } = null!;
        public string WorkingWithParentsStudents { get; set; } = null!;
        public string TakenMeasures { get; set; } = null!;
        public string Result { get; set; } = null!;
        public string PsychologistsRecommendations { get; set; } = null!;
        public int CnS { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
