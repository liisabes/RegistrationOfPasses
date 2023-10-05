using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class SphSend
    {
        public string CnG { get; set; } = null!;
        public int IdPeriod { get; set; }
        public int Students { get; set; }
        public int Budget { get; set; }
        public int NonBudget { get; set; }
        public int Boys { get; set; }
        public int Girls { get; set; }
        public int Underage { get; set; }
        public int Adult { get; set; }
        public int Nonresident { get; set; }
        public int Hostel { get; set; }
        public int Flat { get; set; }
        public int ForeignStudent { get; set; }
        public int Incomplete { get; set; }
        public int ManyChildrenFamily { get; set; }
        public int Trusteeship { get; set; }
        public int FosterFamily { get; set; }
        public int Refurgee { get; set; }
        public int HaveDisabledParents { get; set; }
        public int LowIncomeFamily { get; set; }
        public int FamilyStudents { get; set; }
        public int HaveChildren { get; set; }
        public int StateSupportInCollege { get; set; }
        public int SociallyDangerousPosition { get; set; }
        public int NeedForStateProtection { get; set; }
        public int IndividualProphylacticAccounting { get; set; }
        public int DisabledPeople { get; set; }
        public int BrsmMembers { get; set; }
        public int TradeUnionMembers { get; set; }

        public virtual Group CnGNavigation { get; set; } = null!;
        public virtual ReportingPeriodDate IdPeriodNavigation { get; set; } = null!;
    }
}
