using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Student
    {
        public Student()
        {
            AssocialBehaviors = new HashSet<AssocialBehavior>();
            FamilyCharacteristics = new HashSet<FamilyCharacteristic>();
            FamilyCompositions = new HashSet<FamilyComposition>();
            ListAcademicDebts = new HashSet<ListAcademicDebt>();
            Monitorings = new HashSet<Monitoring>();
            PracticeWorkingOffs = new HashSet<PracticeWorkingOff>();
            PromotionPunishes = new HashSet<PromotionPunish>();
            Relatives = new HashSet<Relative>();
            StudentSkips = new HashSet<StudentSkip>();
            SuaEmployments = new HashSet<SuaEmployment>();
            WeekendOuts = new HashSet<WeekendOut>();
            IdActiveSectors = new HashSet<ActiveSector>();
        }

        public int CnS { get; set; }
        public string? SurName { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public string? CnG { get; set; }
        public bool? Budget { get; set; }
        public bool? Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? TelephoneHome { get; set; }
        public string? TelephoneMob { get; set; }
        public string? Adress { get; set; }
        public string? PassportSeries { get; set; }
        public int? PassportNumber { get; set; }
        public string? PasportId { get; set; }
        public DateTime? DateIssuePasport { get; set; }
        public string? PasportData { get; set; }
        public bool? Rb { get; set; }
        public int? IdMg { get; set; }
        public bool? Brsm { get; set; }
        public bool? TradeUnion { get; set; }
        public string? PreviousPlaceOfStudy { get; set; }
        public DateTime? StateDateOfStudy { get; set; }
        public bool? FamilyState { get; set; }
        public DateTime? DateStartStudingLastCollege { get; set; }
        public DateTime? DateEndStudingLastCollege { get; set; }

        public virtual Group? CnGNavigation { get; set; }
        public virtual MedicalGroup? IdMgNavigation { get; set; }
        public virtual AnOrphan? AnOrphan { get; set; }
        public virtual DisabledParent? DisabledParent { get; set; }
        public virtual DisabledStudent? DisabledStudent { get; set; }
        public virtual FamilyVisitInfo? FamilyVisitInfo { get; set; }
        public virtual Flat? Flat { get; set; }
        public virtual HaveChild? HaveChild { get; set; }
        public virtual Hostel? Hostel { get; set; }
        public virtual IndividualProphylacticAccounting? IndividualProphylacticAccounting { get; set; }
        public virtual LongOut? LongOut { get; set; }
        public virtual NeedForStateProtection? NeedForStateProtection { get; set; }
        public virtual SociallyDangerousPosition? SociallyDangerousPosition { get; set; }
        public virtual StudentCharacterization? StudentCharacterization { get; set; }
        public virtual TargetStudent? TargetStudent { get; set; }
        public virtual ICollection<AssocialBehavior> AssocialBehaviors { get; set; }
        public virtual ICollection<FamilyCharacteristic> FamilyCharacteristics { get; set; }
        public virtual ICollection<FamilyComposition> FamilyCompositions { get; set; }
        public virtual ICollection<ListAcademicDebt> ListAcademicDebts { get; set; }
        public virtual ICollection<Monitoring> Monitorings { get; set; }
        public virtual ICollection<PracticeWorkingOff> PracticeWorkingOffs { get; set; }
        public virtual ICollection<PromotionPunish> PromotionPunishes { get; set; }
        public virtual ICollection<Relative> Relatives { get; set; }
        public virtual ICollection<StudentSkip> StudentSkips { get; set; }
        public virtual ICollection<SuaEmployment> SuaEmployments { get; set; }
        public virtual ICollection<WeekendOut> WeekendOuts { get; set; }

        public virtual ICollection<ActiveSector> IdActiveSectors { get; set; }
    }
}
