using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class StudentCharacterization
    {
        public int CnS { get; set; }
        public string GeneralDevelopmentAndOutlook { get; set; } = null!;
        public string Hobbies { get; set; } = null!;
        public string AcademicPerformance { get; set; } = null!;
        public string SelfAssessment { get; set; } = null!;
        public string? MostFavoriteSubjects { get; set; }
        public string? MostDislikedSubjects { get; set; }
        public byte[]? LongAbsences { get; set; }
        public string AttitudeToPhysicalCulture { get; set; } = null!;
        public string Temperament { get; set; } = null!;
        public string PsychologicalFeatures { get; set; } = null!;
        public string CommunicationWithPeers { get; set; } = null!;
        public string CommunicationWithTeachers { get; set; } = null!;
        public string SignsOfSocialNeglect { get; set; } = null!;
        public string LevelOfNeuropsychologicalStability { get; set; } = null!;
        public bool? InclinationToWithdrawal { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}
