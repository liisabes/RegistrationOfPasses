using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistrationOfPasses.Models
{
    public partial class ROfPContext
        : DbContext
    {
        public ROfPContext()
        {
        }

        public ROfPContext(DbContextOptions<ROfPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsenceReason> AbsenceReasons { get; set; } = null!;
        public virtual DbSet<ActiveSector> ActiveSectors { get; set; } = null!;
        public virtual DbSet<AdminBase> AdminBases { get; set; } = null!;
        public virtual DbSet<AdminBaseView> AdminBaseViews { get; set; } = null!;
        public virtual DbSet<AllViewDebt> AllViewDebts { get; set; } = null!;
        public virtual DbSet<AnOrphan> AnOrphans { get; set; } = null!;
        public virtual DbSet<Analysis> Analyses { get; set; } = null!;
        public virtual DbSet<AnalysisFull> AnalysisFulls { get; set; } = null!;
        public virtual DbSet<AnalysisView> AnalysisViews { get; set; } = null!;
        public virtual DbSet<AssocialBehavior> AssocialBehaviors { get; set; } = null!;
        public virtual DbSet<AverageAnalysisResult> AverageAnalysisResults { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Cause> Causes { get; set; } = null!;
        public virtual DbSet<Ck> Cks { get; set; } = null!;
        public virtual DbSet<CkReport> CkReports { get; set; } = null!;
        public virtual DbSet<Curator> Curators { get; set; } = null!;
        public virtual DbSet<CuratorFromGraduateGroup> CuratorFromGraduateGroups { get; set; } = null!;
        public virtual DbSet<CuratorGroupView> CuratorGroupViews { get; set; } = null!;
        public virtual DbSet<DisabledParent> DisabledParents { get; set; } = null!;
        public virtual DbSet<DisabledStudent> DisabledStudents { get; set; } = null!;
        public virtual DbSet<EmpForm> EmpForms { get; set; } = null!;
        public virtual DbSet<EmpPayment> EmpPayments { get; set; } = null!;
        public virtual DbSet<Employer> Employers { get; set; } = null!;
        public virtual DbSet<FamilyCharacteristic> FamilyCharacteristics { get; set; } = null!;
        public virtual DbSet<FamilyComposition> FamilyCompositions { get; set; } = null!;
        public virtual DbSet<FamilyType> FamilyTypes { get; set; } = null!;
        public virtual DbSet<FamilyVisitInfo> FamilyVisitInfos { get; set; } = null!;
        public virtual DbSet<Flat> Flats { get; set; } = null!;
        public virtual DbSet<GetFioandGroupTeacher> GetFioandGroupTeachers { get; set; } = null!;
        public virtual DbSet<GetGruppaName> GetGruppaNames { get; set; } = null!;
        public virtual DbSet<GetNameTeacher> GetNameTeachers { get; set; } = null!;
        public virtual DbSet<GetStudetGruppa> GetStudetGruppas { get; set; } = null!;
        public virtual DbSet<GetSubjectView> GetSubjectViews { get; set; } = null!;
        public virtual DbSet<GropStudent> GropStudents { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GroupStudent> GroupStudents { get; set; } = null!;
        public virtual DbSet<GroupSubject> GroupSubjects { get; set; } = null!;
        public virtual DbSet<HaveChild> HaveChildren { get; set; } = null!;
        public virtual DbSet<HeadPrint> HeadPrints { get; set; } = null!;
        public virtual DbSet<Hostel> Hostels { get; set; } = null!;
        public virtual DbSet<IndividualProphylacticAccounting> IndividualProphylacticAccountings { get; set; } = null!;
        public virtual DbSet<ListAcademicDebt> ListAcademicDebts { get; set; } = null!;
        public virtual DbSet<ListPaidWorkingOff> ListPaidWorkingOffs { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogView> LogViews { get; set; } = null!;
        public virtual DbSet<LongOut> LongOuts { get; set; } = null!;
        public virtual DbSet<MarkPrint> MarkPrints { get; set; } = null!;
        public virtual DbSet<MedicalGroup> MedicalGroups { get; set; } = null!;
        public virtual DbSet<Monitoring> Monitorings { get; set; } = null!;
        public virtual DbSet<MonitoringForm> MonitoringForms { get; set; } = null!;
        public virtual DbSet<MonitoringGroup> MonitoringGroups { get; set; } = null!;
        public virtual DbSet<NeedForStateProtection> NeedForStateProtections { get; set; } = null!;
        public virtual DbSet<OkrFull> OkrFulls { get; set; } = null!;
        public virtual DbSet<OkrView> OkrViews { get; set; } = null!;
        public virtual DbSet<OtrabotkiEdit> OtrabotkiEdits { get; set; } = null!;
        public virtual DbSet<PracticeWorkingOff> PracticeWorkingOffs { get; set; } = null!;
        public virtual DbSet<PromotionPunish> PromotionPunishes { get; set; } = null!;
        public virtual DbSet<PromotionPunishCategory> PromotionPunishCategories { get; set; } = null!;
        public virtual DbSet<PromotionPunishType> PromotionPunishTypes { get; set; } = null!;
        public virtual DbSet<PromotionPunishView> PromotionPunishViews { get; set; } = null!;
        public virtual DbSet<Relative> Relatives { get; set; } = null!;
        public virtual DbSet<RelativeForm> RelativeForms { get; set; } = null!;
        public virtual DbSet<ReportingPeriodDate> ReportingPeriodDates { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Root> Roots { get; set; } = null!;
        public virtual DbSet<SociallyDangerousPosition> SociallyDangerousPositions { get; set; } = null!;
        public virtual DbSet<Specialty> Specialties { get; set; } = null!;
        public virtual DbSet<SphSend> SphSends { get; set; } = null!;
        public virtual DbSet<St> Sts { get; set; } = null!;
        public virtual DbSet<Stg> Stgs { get; set; } = null!;
        public virtual DbSet<StudGraduate> StudGraduates { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentCharacterization> StudentCharacterizations { get; set; } = null!;
        public virtual DbSet<StudentFiogroup> StudentFiogroups { get; set; } = null!;
        public virtual DbSet<StudentPrint> StudentPrints { get; set; } = null!;
        public virtual DbSet<StudentSkip> StudentSkips { get; set; } = null!;
        public virtual DbSet<StudentSkipV> StudentSkipVs { get; set; } = null!;
        public virtual DbSet<StudentSkipView> StudentSkipViews { get; set; } = null!;
        public virtual DbSet<StudentSkipView2> StudentSkipView2s { get; set; } = null!;
        public virtual DbSet<StudentsView> StudentsViews { get; set; } = null!;
        public virtual DbSet<SuaEmployment> SuaEmployments { get; set; } = null!;
        public virtual DbSet<SubjTeachView> SubjTeachViews { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SubjectGroupView> SubjectGroupViews { get; set; } = null!;
        public virtual DbSet<SubjectTeacher> SubjectTeachers { get; set; } = null!;
        public virtual DbSet<SubjectTeacherFull> SubjectTeacherFulls { get; set; } = null!;
        public virtual DbSet<SubjectTeacherSemester> SubjectTeacherSemesters { get; set; } = null!;
        public virtual DbSet<TargetStudent> TargetStudents { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeachersView> TeachersViews { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        public virtual DbSet<ViewForPrint> ViewForPrints { get; set; } = null!;
        public virtual DbSet<WeekendOut> WeekendOuts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5TS8MQQ\\SQLEXPRESS;Initial Catalog=Единый колледж;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsenceReason>(entity =>
            {
                entity.HasKey(e => e.AbsenceReason1)
                    .HasName("PK_Reason");

                entity.ToTable("Absence_Reason");

                entity.Property(e => e.AbsenceReason1)
                    .HasMaxLength(50)
                    .HasColumnName("Absence_Reason");
            });

            modelBuilder.Entity<ActiveSector>(entity =>
            {
                entity.HasKey(e => e.IdActiveSector)
                    .HasName("XPKActiveSector")
                    .IsClustered(false);

                entity.ToTable("ActiveSector");

                entity.Property(e => e.IdActiveSector).HasColumnName("ID_ActiveSector");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasMany(d => d.Cns)
                    .WithMany(p => p.IdActiveSectors)
                    .UsingEntity<Dictionary<string, object>>(
                        "Assignment",
                        l => l.HasOne<Student>().WithMany().HasForeignKey("CnS").HasConstraintName("R_48"),
                        r => r.HasOne<ActiveSector>().WithMany().HasForeignKey("IdActiveSector").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("R_47"),
                        j =>
                        {
                            j.HasKey("IdActiveSector", "CnS").HasName("XPKAssignments").IsClustered(false);

                            j.ToTable("Assignments");

                            j.IndexerProperty<int>("IdActiveSector").HasColumnName("ID_ActiveSector");

                            j.IndexerProperty<int>("CnS").HasColumnName("cn_S");
                        });
            });

            modelBuilder.Entity<AdminBase>(entity =>
            {
                entity.HasKey(e => e.CnA);

                entity.ToTable("AdminBase");

                entity.Property(e => e.CnA)
                    .HasMaxLength(15)
                    .HasColumnName("cn_A");

                entity.HasOne(d => d.CnANavigation)
                    .WithOne(p => p.AdminBase)
                    .HasForeignKey<AdminBase>(d => d.CnA)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdminBase_Employer");
            });

            modelBuilder.Entity<AdminBaseView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AdminBaseView");

                entity.Property(e => e.Admin).HasMaxLength(107);

                entity.Property(e => e.CnA)
                    .HasMaxLength(15)
                    .HasColumnName("cn_A");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.If)
                    .HasMaxLength(71)
                    .HasColumnName("IF");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.SurName).HasMaxLength(35);
            });

            modelBuilder.Entity<AllViewDebt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllViewDebt");

                entity.Property(e => e.CategoryName).HasMaxLength(25);

                entity.Property(e => e.DataEmp)
                    .HasMaxLength(4000)
                    .HasColumnName("Data_Emp");

                entity.Property(e => e.DateIssue)
                    .HasMaxLength(4000)
                    .HasColumnName("Date_Issue");

                entity.Property(e => e.DatePays).HasMaxLength(4000);

                entity.Property(e => e.DateWorks).HasMaxLength(4000);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marks).HasMaxLength(10);

                entity.Property(e => e.Prepod).HasMaxLength(41);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.StudentFio)
                    .HasMaxLength(40)
                    .HasColumnName("StudentFIO");

                entity.Property(e => e.SubjName)
                    .HasMaxLength(50)
                    .HasColumnName("Subj_Name");
            });

            modelBuilder.Entity<AnOrphan>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("XPKAnOrphan")
                    .IsClustered(false);

                entity.ToTable("AnOrphan");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.FosterFamily).HasColumnName("Foster_family");

                entity.Property(e => e.StateSupport).HasColumnName("State_support");

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.AnOrphan)
                    .HasForeignKey<AnOrphan>(d => d.CnS)
                    .HasConstraintName("R_58");
            });

            modelBuilder.Entity<Analysis>(entity =>
            {
                entity.HasKey(e => e.IdAnalysis)
                    .HasName("PK__Analysis__270E37108C6FD4E3");

                entity.ToTable("Analysis");

                entity.Property(e => e.AbsoluteProgress)
                    .HasColumnType("decimal(10, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](10,2),((((((([Mark7]*(1.0)+[Mark8]*(1.0))+[Mark9]*(1.0))+[Mark10]*(1.0))+[Mark6]*(1.0))+[Mark5]*(1.0))+[Mark4]*(1.0))/(((((((((([Mark0]*(1.0)+[Mark1]*(1.0))+[Mark2]*(1.0))+[Mark3]*(1.0))+[Mark4]*(1.0))+[Mark5]*(1.0))+[Mark6]*(1.0))+[Mark7]*(1.0))+[Mark8]*(1.0))+[Mark9]*(1.0))+[Mark10]*(1.0)))*(100.0)))", false);

                entity.Property(e => e.AnalysisDate).HasColumnType("date");

                entity.Property(e => e.AverageMark)
                    .HasColumnType("decimal(10, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](10,2),((((((((([Mark1]*(1.0)+[Mark2]*(2.0))+[Mark3]*(3.0))+[Mark4]*(4.0))+[Mark5]*(5.0))+[Mark6]*(6.0))+[Mark7]*(7.0))+[Mark8]*(8.0))+[Mark9]*(9.0))+[Mark10]*(10.0))/(((((((((([Mark0]+[Mark1])+[Mark2])+[Mark3])+[Mark4])+[Mark5])+[Mark6])+[Mark7])+[Mark8])+[Mark9])+[Mark10])))", false);

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.NumberOkr).HasColumnName("NumberOKR");

                entity.Property(e => e.QualitativeProgress)
                    .HasColumnType("decimal(10, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](10,2),(((([Mark7]*(1.0)+[Mark8]*(1.0))+[Mark9]*(1.0))+[Mark10]*(1.0))/(((((((((([Mark0]*(1.0)+[Mark1]*(1.0))+[Mark2]*(1.0))+[Mark3]*(1.0))+[Mark4]*(1.0))+[Mark5]*(1.0))+[Mark6]*(1.0))+[Mark7]*(1.0))+[Mark8]*(1.0))+[Mark9]*(1.0))+[Mark10]*(1.0)))*(100.0)))", false);

                entity.HasOne(d => d.IdCkNavigation)
                    .WithMany(p => p.Analyses)
                    .HasForeignKey(d => d.IdCk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analysis_CK");

                entity.HasOne(d => d.IdMonitoringFormNavigation)
                    .WithMany(p => p.Analyses)
                    .HasForeignKey(d => d.IdMonitoringForm)
                    .HasConstraintName("FK_Analysis_MonitoringForm");

                entity.HasOne(d => d.IdSubjectTeacherNavigation)
                    .WithMany(p => p.Analyses)
                    .HasForeignKey(d => d.IdSubjectTeacher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analysis_Subject_Teacher");
            });

            modelBuilder.Entity<AnalysisFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Analysis_Full");

                entity.Property(e => e.AbsoluteProgress).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AnalysisDate).HasColumnType("date");

                entity.Property(e => e.AverageMark).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.MonitoringForm).HasMaxLength(30);

                entity.Property(e => e.NumberOkr).HasColumnName("NumberOKR");

                entity.Property(e => e.QualitativeProgress).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SubjectFullName).HasMaxLength(100);

                entity.Property(e => e.SubjectShortName).HasMaxLength(50);

                entity.Property(e => e.Teacher).HasMaxLength(41);
            });

            modelBuilder.Entity<AnalysisView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Analysis_View");

                entity.Property(e => e.AnalisysDate).HasColumnType("date");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.NumberOkr).HasColumnName("NumberOKR");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.Teacher).HasMaxLength(41);
            });

            modelBuilder.Entity<AssocialBehavior>(entity =>
            {
                entity.HasKey(e => e.IdAssocBeh)
                    .HasName("XPKAssocialBehavior")
                    .IsClustered(false);

                entity.ToTable("AssocialBehavior");

                entity.Property(e => e.IdAssocBeh).HasColumnName("ID_Assoc_beh");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NatureAssocBeh)
                    .HasMaxLength(50)
                    .HasColumnName("Nature_Assoc_Beh");

                entity.Property(e => e.PsychologistsRecommendations).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.TakenMeasures).HasMaxLength(50);

                entity.Property(e => e.WorkingWithParentsStudents)
                    .HasMaxLength(50)
                    .HasColumnName("Working_with_parents_students");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.AssocialBehaviors)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_45");
            });

            modelBuilder.Entity<AverageAnalysisResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AverageAnalysisResults");

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("XPKCategory")
                    .IsClustered(false);

                entity.ToTable("Category");

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Payment).HasColumnType("money");
            });

            modelBuilder.Entity<Cause>(entity =>
            {
                entity.HasKey(e => e.IdCause)
                    .HasName("XPKCause")
                    .IsClustered(false);

                entity.ToTable("Cause");

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.SmallName).HasMaxLength(3);
            });

            modelBuilder.Entity<Ck>(entity =>
            {
                entity.HasKey(e => e.IdCk)
                    .HasName("XPKCK")
                    .IsClustered(false);

                entity.ToTable("CK");

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CkReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CkReport");

                entity.Property(e => e.AbsoluteProgress).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AverageMark).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.QualitativeProgress).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubjectFullName).HasMaxLength(100);
            });

            modelBuilder.Entity<Curator>(entity =>
            {
                entity.HasKey(e => e.IdCurator)
                    .HasName("PK_Curator_1");

                entity.ToTable("Curator");

                entity.Property(e => e.IdCurator).HasColumnName("Id_Curator");

                entity.Property(e => e.CnC)
                    .HasMaxLength(15)
                    .HasColumnName("cn_C");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.HasOne(d => d.CnCNavigation)
                    .WithMany(p => p.Curators)
                    .HasForeignKey(d => d.CnC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Curator_Teacher1");

                entity.HasOne(d => d.CnGNavigation)
                    .WithMany(p => p.Curators)
                    .HasForeignKey(d => d.CnG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Curator_Group");
            });

            modelBuilder.Entity<CuratorFromGraduateGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CuratorFromGraduateGroup");

                entity.Property(e => e.IdCurator).HasColumnName("Id_Curator");
            });

            modelBuilder.Entity<CuratorGroupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CuratorGroupView");

                entity.Property(e => e.CnC)
                    .HasMaxLength(15)
                    .HasColumnName("cn_C");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnSpec)
                    .HasMaxLength(30)
                    .HasColumnName("cn_Spec");

                entity.Property(e => e.Curator).HasMaxLength(107);

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdCurator).HasColumnName("Id_Curator");
            });

            modelBuilder.Entity<DisabledParent>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__Disabled__35BD85C9524C014E");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.DisabledParent)
                    .HasForeignKey<DisabledParent>(d => d.CnS)
                    .HasConstraintName("R_83");
            });

            modelBuilder.Entity<DisabledStudent>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__Disabled__35BD85C98DC6EE45");

                entity.ToTable("DisabledStudent");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.DisabledStudent)
                    .HasForeignKey<DisabledStudent>(d => d.CnS)
                    .HasConstraintName("R_78");
            });

            modelBuilder.Entity<EmpForm>(entity =>
            {
                entity.HasKey(e => e.IdEmpForn)
                    .HasName("XPKEmpForm")
                    .IsClustered(false);

                entity.ToTable("EmpForm");

                entity.Property(e => e.FullName).HasMaxLength(60);

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<EmpPayment>(entity =>
            {
                entity.HasKey(e => e.IdEmpPayment)
                    .HasName("XPKEmpPayment")
                    .IsClustered(false);

                entity.ToTable("EmpPayment");

                entity.Property(e => e.Accout).HasMaxLength(30);

                entity.Property(e => e.Secretar).HasMaxLength(35);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasKey(e => e.CnE)
                    .HasName("XPKEmployer")
                    .IsClustered(false);

                entity.ToTable("Employer");

                entity.Property(e => e.CnE)
                    .HasMaxLength(15)
                    .HasColumnName("cn_E");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.SurName).HasMaxLength(35);
            });

            modelBuilder.Entity<FamilyCharacteristic>(entity =>
            {
                entity.HasKey(e => e.IdFamily)
                    .HasName("PK__FamilyCh__7DFC192413B62F0E");

                entity.Property(e => e.IdFamily).HasColumnName("id_Family");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.FamilyCharacteristics)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_71");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.FamilyCharacteristics)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_75");
            });

            modelBuilder.Entity<FamilyComposition>(entity =>
            {
                entity.HasKey(e => e.IdRelative)
                    .HasName("PK__FamilyCo__35BD85C9C84C618E");

                entity.ToTable("FamilyComposition");

                entity.Property(e => e.IdRelative).HasColumnName("Id_Relative");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .HasColumnName("FIO");

                entity.Property(e => e.IdRf).HasColumnName("ID_RF");

                entity.Property(e => e.PlaceOfResidence)
                    .HasMaxLength(200)
                    .HasColumnName("Place_of_residence");

                entity.Property(e => e.WorkStudyPlace)
                    .HasMaxLength(200)
                    .HasColumnName("Work_Study_Place");

                entity.Property(e => e.YearBirth).HasColumnType("datetime");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.FamilyCompositions)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_72");

                entity.HasOne(d => d.IdRfNavigation)
                    .WithMany(p => p.FamilyCompositions)
                    .HasForeignKey(d => d.IdRf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_FamilyComposition_RelativeForm");
            });

            modelBuilder.Entity<FamilyType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__FamilyTy__C3F091E0D2DCF0DE");

                entity.ToTable("FamilyType");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.FamilyTypeName)
                    .HasMaxLength(25)
                    .HasColumnName("FamilyType_Name");
            });

            modelBuilder.Entity<FamilyVisitInfo>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__FamilyVi__35BD85C9B98B10F6");

                entity.ToTable("FamilyVisitInfo");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.DateOfVisit)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_of_visit");

                entity.Property(e => e.HouseCharacteristics)
                    .HasMaxLength(30)
                    .HasColumnName("House_characteristics");

                entity.Property(e => e.LivingConditions)
                    .HasMaxLength(15)
                    .HasColumnName("Living_conditions");

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.FamilyVisitInfo)
                    .HasForeignKey<FamilyVisitInfo>(d => d.CnS)
                    .HasConstraintName("R_73");
            });

            modelBuilder.Entity<Flat>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__Flat__35BD85C905DFFCBB");

                entity.ToTable("Flat");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.FlatDescription)
                    .HasMaxLength(50)
                    .HasColumnName("Flat_Description");

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.Flat)
                    .HasForeignKey<Flat>(d => d.CnS)
                    .HasConstraintName("R_65");
            });

            modelBuilder.Entity<GetFioandGroupTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetFIOandGroupTeacher");

                entity.Property(e => e.CnC)
                    .HasMaxLength(15)
                    .HasColumnName("cn_C");

                entity.Property(e => e.CnE)
                    .HasMaxLength(15)
                    .HasColumnName("cn_E");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnGGroup)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G_Group");

                entity.Property(e => e.CnSpec)
                    .HasMaxLength(30)
                    .HasColumnName("cn_Spec");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fioteacher)
                    .HasMaxLength(40)
                    .HasColumnName("FIOTeacher");

                entity.Property(e => e.IdCk).HasColumnName("IdCK");

                entity.Property(e => e.IdCurator).HasColumnName("Id_Curator");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.NameGroup)
                    .HasMaxLength(3)
                    .HasColumnName("Name_Group");

                entity.Property(e => e.SurName).HasMaxLength(35);
            });

            modelBuilder.Entity<GetGruppaName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetGruppaName");

                entity.Property(e => e.CnC)
                    .HasMaxLength(15)
                    .HasColumnName("cn_C");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.Name).HasMaxLength(3);
            });

            modelBuilder.Entity<GetNameTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetNameTeacher");

                entity.Property(e => e.CnE)
                    .HasMaxLength(15)
                    .HasColumnName("cn_E");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.CnTTeacher)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T_Teacher");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fioteacher)
                    .HasMaxLength(40)
                    .HasColumnName("FIOTeacher");

                entity.Property(e => e.IdCk).HasColumnName("IdCK");

                entity.Property(e => e.IdSubjectSubjectTeacher).HasColumnName("idSubject_Subject_Teacher");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.NameSubject)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Subject");

                entity.Property(e => e.SurName).HasMaxLength(35);
            });

            modelBuilder.Entity<GetStudetGruppa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetStudetGruppa");

                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.Brsm).HasColumnName("BRSM");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.DateBirth).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.IdMg).HasColumnName("ID_MG");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.NameGroup)
                    .HasMaxLength(3)
                    .HasColumnName("Name_Group");

                entity.Property(e => e.PasportId)
                    .HasMaxLength(20)
                    .HasColumnName("PasportID");

                entity.Property(e => e.PassportSeries).HasMaxLength(5);

                entity.Property(e => e.PreviousPlaceOfStudy).HasMaxLength(50);

                entity.Property(e => e.Rb).HasColumnName("RB");

                entity.Property(e => e.StateDateOfStudy).HasColumnType("datetime");

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.TelephoneHome)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Home");

                entity.Property(e => e.TelephoneMob)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Mob");

                entity.Property(e => e.Uchashchiysya).HasMaxLength(40);
            });

            modelBuilder.Entity<GetSubjectView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetSubjectView");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<GropStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Grop_Student");

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(3);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.CnG)
                    .HasName("XPKGroup")
                    .IsClustered(false);

                entity.ToTable("Group");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnSpec)
                    .HasMaxLength(30)
                    .HasColumnName("cn_Spec");

                entity.Property(e => e.Name).HasMaxLength(3);

                entity.HasOne(d => d.CnSpecNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.CnSpec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Specialty");
            });

            modelBuilder.Entity<GroupStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupStudent");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.Idsubject).HasColumnName("IDSubject");

                entity.Property(e => e.SubjName).HasMaxLength(20);
            });

            modelBuilder.Entity<GroupSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupSubject");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.Idsubject).HasColumnName("IDSubject");

                entity.Property(e => e.SubjName).HasMaxLength(20);
            });

            modelBuilder.Entity<HaveChild>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__HaveChil__35BD85C9C0297DC9");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.HaveChild)
                    .HasForeignKey<HaveChild>(d => d.CnS)
                    .HasConstraintName("R_76");
            });

            modelBuilder.Entity<HeadPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Head_Print");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Teacher).HasMaxLength(40);
            });

            modelBuilder.Entity<Hostel>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("XPKHostel")
                    .IsClustered(false);

                entity.ToTable("Hostel");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.IdRoom).HasColumnName("id_Room");

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.Hostel)
                    .HasForeignKey<Hostel>(d => d.CnS)
                    .HasConstraintName("R_43");

                entity.HasOne(d => d.IdRoomNavigation)
                    .WithMany(p => p.Hostels)
                    .HasForeignKey(d => d.IdRoom)
                    .HasConstraintName("R_87");
            });

            modelBuilder.Entity<IndividualProphylacticAccounting>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__Individu__35BD85C9BBE8859D");

                entity.ToTable("IndividualProphylacticAccounting");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.IndividualProphylacticAccounting)
                    .HasForeignKey<IndividualProphylacticAccounting>(d => d.CnS)
                    .HasConstraintName("R_79");
            });

            modelBuilder.Entity<ListAcademicDebt>(entity =>
            {
                entity.HasKey(e => e.IdListAcademicDebt);

                entity.ToTable("ListAcademicDebt");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.DateIssue).HasColumnType("datetime");

                entity.Property(e => e.DatePay).HasColumnType("datetime");

                entity.Property(e => e.DateWork).HasColumnType("datetime");

                entity.Property(e => e.Mark).HasMaxLength(10);

                entity.Property(e => e.Summa).HasColumnType("money");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.ListAcademicDebts)
                    .HasForeignKey(d => d.CnS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListAcademicDebt_Student");

                entity.HasOne(d => d.CnTNavigation)
                    .WithMany(p => p.ListAcademicDebts)
                    .HasForeignKey(d => d.CnT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListAcademicDebt_Teacher");

                entity.HasOne(d => d.IdEmpFormNavigation)
                    .WithMany(p => p.ListAcademicDebts)
                    .HasForeignKey(d => d.IdEmpForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListAcademicDebt_EmpForm");

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.ListAcademicDebts)
                    .HasForeignKey(d => d.IdSubject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListAcademicDebt_Subject");
            });

            modelBuilder.Entity<ListPaidWorkingOff>(entity =>
            {
                entity.HasKey(e => e.IdStudentSkip)
                    .HasName("XPKListPaydWork")
                    .IsClustered(false);

                entity.ToTable("ListPaidWorkingOff");

                entity.Property(e => e.IdStudentSkip).ValueGeneratedNever();

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.DateIssue).HasColumnType("datetime");

                entity.Property(e => e.DatePass).HasColumnType("datetime");

                entity.Property(e => e.DatePay).HasColumnType("datetime");

                entity.Property(e => e.DateWork).HasColumnType("datetime");

                entity.Property(e => e.Mark).HasMaxLength(10);

                entity.Property(e => e.Summa).HasColumnType("money");

                entity.HasOne(d => d.IdStudentSkipNavigation)
                    .WithOne(p => p.ListPaidWorkingOff)
                    .HasForeignKey<ListPaidWorkingOff>(d => d.IdStudentSkip)
                    .HasConstraintName("R_31");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("XPKLogs")
                    .IsClustered(false);

                entity.ToTable("Log");

                entity.Property(e => e.CnA)
                    .HasMaxLength(15)
                    .HasColumnName("cn_A");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.HasOne(d => d.CnANavigation)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.CnA)
                    .HasConstraintName("FK_Log_AdminBase");
            });

            modelBuilder.Entity<LogView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LogView");

                entity.Property(e => e.Date).HasMaxLength(4000);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasMaxLength(41)
                    .HasColumnName("FIO");
            });

            modelBuilder.Entity<LongOut>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK_LongOut_1");

                entity.ToTable("LongOut");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.AbsenceReason)
                    .HasMaxLength(50)
                    .HasColumnName("Absence_Reason");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("date")
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalTime).HasColumnName("Arrival_Time");

                entity.Property(e => e.DepartureDate)
                    .HasColumnType("date")
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureTime).HasColumnName("Departure_Time");

                entity.HasOne(d => d.AbsenceReasonNavigation)
                    .WithMany(p => p.LongOuts)
                    .HasForeignKey(d => d.AbsenceReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOut_Reason");

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.LongOut)
                    .HasForeignKey<LongOut>(d => d.CnS)
                    .HasConstraintName("FK_LongOut_Student");
            });

            modelBuilder.Entity<MarkPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mark_Print");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Mark).HasMaxLength(5);

                entity.Property(e => e.Name).HasMaxLength(35);
            });

            modelBuilder.Entity<MedicalGroup>(entity =>
            {
                entity.HasKey(e => e.IdMg)
                    .HasName("XPKMedicalGroup")
                    .IsClustered(false);

                entity.ToTable("MedicalGroup");

                entity.Property(e => e.IdMg).HasColumnName("ID_MG");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Monitoring>(entity =>
            {
                entity.HasKey(e => e.IdMonitoring)
                    .HasName("XPKMo")
                    .IsClustered(false);

                entity.ToTable("Monitoring");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Mark).HasMaxLength(5);

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.Monitorings)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_1");

                entity.HasOne(d => d.IdMonitoringFormNavigation)
                    .WithMany(p => p.Monitorings)
                    .HasForeignKey(d => d.IdMonitoringForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_20");

                entity.HasOne(d => d.IdSubjectTeacherNavigation)
                    .WithMany(p => p.Monitorings)
                    .HasForeignKey(d => d.IdSubjectTeacher)
                    .HasConstraintName("R_25");
            });

            modelBuilder.Entity<MonitoringForm>(entity =>
            {
                entity.HasKey(e => e.IdMonitoringForm)
                    .HasName("XPKMonitoringForm")
                    .IsClustered(false);

                entity.ToTable("MonitoringForm");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<MonitoringGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Monitoring_Group");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Mark).HasMaxLength(5);

                entity.Property(e => e.Student).HasMaxLength(40);
            });

            modelBuilder.Entity<NeedForStateProtection>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__NeedForS__35BD85C9B88C9532");

                entity.ToTable("NeedForStateProtection");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.NeedForStateProtection)
                    .HasForeignKey<NeedForStateProtection>(d => d.CnS)
                    .HasConstraintName("R_80");
            });

            modelBuilder.Entity<OkrFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OKR_Full");

                entity.Property(e => e.AbsoluteProgress).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AnalysisDate).HasColumnType("datetime");

                entity.Property(e => e.AverageMark).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdCk).HasColumnName("ID_CK");

                entity.Property(e => e.NumberOkr).HasColumnName("NumberOKR");

                entity.Property(e => e.QualitativeProgress).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SubjectFullName).HasMaxLength(100);

                entity.Property(e => e.SubjectShortName).HasMaxLength(50);

                entity.Property(e => e.Teacher).HasMaxLength(41);
            });

            modelBuilder.Entity<OkrView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OKR_View");

                entity.Property(e => e.AnalisysDate).HasColumnType("date");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.NumberOkr).HasColumnName("NumberOKR");

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<OtrabotkiEdit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Otrabotki_edit");

                entity.Property(e => e.CategoryName).HasMaxLength(25);

                entity.Property(e => e.DataEmp)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Emp");

                entity.Property(e => e.DateIssue)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Issue");

                entity.Property(e => e.DatePays).HasColumnType("datetime");

                entity.Property(e => e.DateWorks).HasColumnType("datetime");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marks).HasMaxLength(10);

                entity.Property(e => e.NameEmpl).HasMaxLength(35);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.StudentFio)
                    .HasMaxLength(39)
                    .HasColumnName("StudentFIO");

                entity.Property(e => e.SubjName)
                    .HasMaxLength(20)
                    .HasColumnName("Subj_Name");

                entity.Property(e => e.SurNameEmpl)
                    .HasMaxLength(35)
                    .HasColumnName("Sur_NameEmpl");
            });

            modelBuilder.Entity<PracticeWorkingOff>(entity =>
            {
                entity.HasKey(e => e.IdPracticeWorkingOff);

                entity.ToTable("PracticeWorkingOff");

                entity.Property(e => e.IdPracticeWorkingOff).HasColumnName("ID_Practice_Working_Off");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.CountWorkingOffHours).HasColumnName("Count_Working_Off_Hours");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.PracticeWorkingOffs)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("FK_PracticeWorkingOff_Student");
            });

            modelBuilder.Entity<PromotionPunish>(entity =>
            {
                entity.HasKey(e => e.IdPromotion)
                    .HasName("PK__Promotio__EB90B0FA4D29A71E");

                entity.ToTable("Promotion_punish");

                entity.Property(e => e.IdPromotion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Promotion");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.IdType).HasColumnName("id_Type");

                entity.Property(e => e.Ppdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PPDate");

                entity.Property(e => e.Ppdescription)
                    .HasMaxLength(50)
                    .HasColumnName("PPDescription");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.PromotionPunishes)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_Promotion_punish_Student");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.PromotionPunishes)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("R_90");
            });

            modelBuilder.Entity<PromotionPunishCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Promotio__5C2BE2595A564E92");

                entity.ToTable("Promotion_punish_category");

                entity.Property(e => e.IdCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Name");
            });

            modelBuilder.Entity<PromotionPunishType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__Promotio__5070D915343A892F");

                entity.ToTable("Promotion_Punish_Type");

                entity.Property(e => e.IdType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Type");

                entity.Property(e => e.IdCategory).HasColumnName("id_Category");

                entity.Property(e => e.MaxScore).HasColumnName("Max_Score");

                entity.Property(e => e.Ppname)
                    .HasMaxLength(50)
                    .HasColumnName("PPName");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.PromotionPunishTypes)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("R_89");
            });

            modelBuilder.Entity<PromotionPunishView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PromotionPunishView");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.IdCategory).HasColumnName("id_Category");

                entity.Property(e => e.IdPromotion).HasColumnName("id_Promotion");

                entity.Property(e => e.IdType).HasColumnName("id_Type");

                entity.Property(e => e.Ppdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PPDate");

                entity.Property(e => e.Ppdescription)
                    .HasMaxLength(50)
                    .HasColumnName("PPDescription");

                entity.Property(e => e.Ppname)
                    .HasMaxLength(50)
                    .HasColumnName("PPName");
            });

            modelBuilder.Entity<Relative>(entity =>
            {
                entity.HasKey(e => e.IdRelative)
                    .HasName("XPKRelative")
                    .IsClustered(false);

                entity.ToTable("Relative");

                entity.Property(e => e.IdRelative).HasColumnName("Id_Relative");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.Fio)
                    .HasMaxLength(80)
                    .HasColumnName("FIO");

                entity.Property(e => e.IdRf).HasColumnName("ID_RF");

                entity.Property(e => e.WorkStudyPlace)
                    .HasMaxLength(50)
                    .HasColumnName("Work_Study_Place");

                entity.Property(e => e.YearBirth).HasColumnType("datetime");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.Relatives)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_42");

                entity.HasOne(d => d.IdRfNavigation)
                    .WithMany(p => p.Relatives)
                    .HasForeignKey(d => d.IdRf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_57");
            });

            modelBuilder.Entity<RelativeForm>(entity =>
            {
                entity.HasKey(e => e.IdRf)
                    .HasName("XPKRelativeForm")
                    .IsClustered(false);

                entity.ToTable("RelativeForm");

                entity.Property(e => e.IdRf).HasColumnName("ID_RF");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<ReportingPeriodDate>(entity =>
            {
                entity.HasKey(e => e.IdPeriod);

                entity.ToTable("ReportingPeriodDate");

                entity.Property(e => e.IdPeriod)
                    .ValueGeneratedNever()
                    .HasColumnName("id_period");

                entity.Property(e => e.DateSph)
                    .HasColumnType("datetime")
                    .HasColumnName("DateSPH");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.IdRoom)
                    .HasName("PK__Room__5E5ED7FBD95EFE56");

                entity.ToTable("Room");

                entity.Property(e => e.IdRoom)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Room");

                entity.Property(e => e.PeopleAmount).HasColumnName("People_amount");

                entity.Property(e => e.RoomNumber).HasColumnName("Room_number");
            });

            modelBuilder.Entity<Root>(entity =>
            {
                entity.HasKey(e => e.IdRoot)
                    .HasName("XPKRoot")
                    .IsClustered(false);

                entity.ToTable("Root");

                entity.Property(e => e.Login).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(10);
            });

            modelBuilder.Entity<SociallyDangerousPosition>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__Socially__35BD85C948638021");

                entity.ToTable("SociallyDangerousPosition");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.SociallyDangerousPosition)
                    .HasForeignKey<SociallyDangerousPosition>(d => d.CnS)
                    .HasConstraintName("R_77");
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.CnSpec)
                    .HasName("XPKSpecialty")
                    .IsClustered(false);

                entity.ToTable("Specialty");

                entity.Property(e => e.CnSpec)
                    .HasMaxLength(30)
                    .HasColumnName("cn_Spec");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Department).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.HasOne(d => d.CnTNavigation)
                    .WithMany(p => p.Specialties)
                    .HasForeignKey(d => d.CnT)
                    .HasConstraintName("FK_Specialty_Teacher");
            });

            modelBuilder.Entity<SphSend>(entity =>
            {
                entity.HasKey(e => new { e.CnG, e.IdPeriod })
                    .HasName("PK__SphSend__35BD85C52D0742A9");

                entity.ToTable("SphSend");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.IdPeriod).HasColumnName("id_period");

                entity.Property(e => e.BrsmMembers).HasColumnName("BRSM_members");

                entity.Property(e => e.DisabledPeople).HasColumnName("Disabled_people");

                entity.Property(e => e.FamilyStudents).HasColumnName("Family_students");

                entity.Property(e => e.ForeignStudent).HasColumnName("Foreign_student");

                entity.Property(e => e.FosterFamily).HasColumnName("Foster_family");

                entity.Property(e => e.HaveChildren).HasColumnName("Have_children");

                entity.Property(e => e.HaveDisabledParents).HasColumnName("Have_disabled_parents");

                entity.Property(e => e.IndividualProphylacticAccounting).HasColumnName("Individual_prophylactic_accounting");

                entity.Property(e => e.LowIncomeFamily).HasColumnName("Low_income_family");

                entity.Property(e => e.ManyChildrenFamily).HasColumnName("Many_children_family");

                entity.Property(e => e.NeedForStateProtection).HasColumnName("Need_for_state_protection");

                entity.Property(e => e.SociallyDangerousPosition).HasColumnName("Socially_dangerous_position");

                entity.Property(e => e.StateSupportInCollege).HasColumnName("State_support_in_college");

                entity.Property(e => e.TradeUnionMembers).HasColumnName("TradeUnion_members");

                entity.HasOne(d => d.CnGNavigation)
                    .WithMany(p => p.SphSends)
                    .HasForeignKey(d => d.CnG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_SphSend_Group");

                entity.HasOne(d => d.IdPeriodNavigation)
                    .WithMany(p => p.SphSends)
                    .HasForeignKey(d => d.IdPeriod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SphSend_ReportingPeriodDate");
            });

            modelBuilder.Entity<St>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STS");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Stg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STG");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Name).HasMaxLength(3);
            });

            modelBuilder.Entity<StudGraduate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudGraduate");

                entity.Property(e => e.CnS).HasColumnName("cn_S");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("XPKStudent")
                    .IsClustered(false);

                entity.ToTable("Student");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.Brsm).HasColumnName("BRSM");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.DateBirth).HasColumnType("date");

                entity.Property(e => e.DateEndStudingLastCollege).HasColumnType("date");

                entity.Property(e => e.DateIssuePasport).HasColumnType("date");

                entity.Property(e => e.DateStartStudingLastCollege).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.IdMg).HasColumnName("ID_MG");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.PasportData).HasMaxLength(50);

                entity.Property(e => e.PasportId)
                    .HasMaxLength(20)
                    .HasColumnName("PasportID");

                entity.Property(e => e.PassportSeries).HasMaxLength(5);

                entity.Property(e => e.PreviousPlaceOfStudy).HasMaxLength(50);

                entity.Property(e => e.Rb).HasColumnName("RB");

                entity.Property(e => e.StateDateOfStudy).HasColumnType("datetime");

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.TelephoneHome)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Home");

                entity.Property(e => e.TelephoneMob)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Mob");

                entity.HasOne(d => d.CnGNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CnG)
                    .HasConstraintName("FK_Student_Group");

                entity.HasOne(d => d.IdMgNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdMg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("R_55");
            });

            modelBuilder.Entity<StudentCharacterization>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__StudentC__35BD85C9146308CA");

                entity.ToTable("StudentCharacterization");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.AcademicPerformance)
                    .HasMaxLength(15)
                    .HasColumnName("Academic_performance");

                entity.Property(e => e.AttitudeToPhysicalCulture)
                    .HasMaxLength(15)
                    .HasColumnName("Attitude_to_physical_culture");

                entity.Property(e => e.CommunicationWithPeers)
                    .HasMaxLength(20)
                    .HasColumnName("Communication_with_peers");

                entity.Property(e => e.CommunicationWithTeachers)
                    .HasMaxLength(20)
                    .HasColumnName("Communication_with_teachers");

                entity.Property(e => e.GeneralDevelopmentAndOutlook)
                    .HasMaxLength(20)
                    .HasColumnName("General_development_and_outlook");

                entity.Property(e => e.Hobbies).HasMaxLength(20);

                entity.Property(e => e.InclinationToWithdrawal).HasColumnName("Inclination_to_withdrawal");

                entity.Property(e => e.LevelOfNeuropsychologicalStability)
                    .HasMaxLength(15)
                    .HasColumnName("Level_of_neuropsychological_stability");

                entity.Property(e => e.LongAbsences)
                    .HasMaxLength(1)
                    .HasColumnName("Long_absences");

                entity.Property(e => e.MostDislikedSubjects)
                    .HasMaxLength(20)
                    .HasColumnName("Most_disliked_subjects");

                entity.Property(e => e.MostFavoriteSubjects)
                    .HasMaxLength(20)
                    .HasColumnName("Most_favorite_subjects");

                entity.Property(e => e.PsychologicalFeatures)
                    .HasMaxLength(30)
                    .HasColumnName("Psychological_features");

                entity.Property(e => e.SelfAssessment)
                    .HasMaxLength(10)
                    .HasColumnName("Self_assessment");

                entity.Property(e => e.SignsOfSocialNeglect)
                    .HasMaxLength(15)
                    .HasColumnName("Signs_of_social_neglect");

                entity.Property(e => e.Temperament).HasMaxLength(10);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.StudentCharacterization)
                    .HasForeignKey<StudentCharacterization>(d => d.CnS)
                    .HasConstraintName("R_60");
            });

            modelBuilder.Entity<StudentFiogroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentFIOGroup");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.StudentFio)
                    .HasMaxLength(40)
                    .HasColumnName("StudentFIO");
            });

            modelBuilder.Entity<StudentPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Student_Print");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.Student).HasMaxLength(107);
            });

            modelBuilder.Entity<StudentSkip>(entity =>
            {
                entity.HasKey(e => e.IdStudentSkip)
                    .HasName("XPKStudentSkip")
                    .IsClustered(false);

                entity.ToTable("StudentSkip");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.StudentSkips)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("R_14");

                entity.HasOne(d => d.IdCauseNavigation)
                    .WithMany(p => p.StudentSkips)
                    .HasForeignKey(d => d.IdCause)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_15");

                entity.HasOne(d => d.IdEmpFornNavigation)
                    .WithMany(p => p.StudentSkips)
                    .HasForeignKey(d => d.IdEmpForn)
                    .HasConstraintName("R_28");

                entity.HasOne(d => d.IdSubjectTeacherNavigation)
                    .WithMany(p => p.StudentSkips)
                    .HasForeignKey(d => d.IdSubjectTeacher)
                    .HasConstraintName("R_30");
            });

            modelBuilder.Entity<StudentSkipV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentSkipV");

                entity.Property(e => e.CnC)
                    .HasMaxLength(15)
                    .HasColumnName("cn_C");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnGCurator)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G_Curator");

                entity.Property(e => e.CnGGroup)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G_Group");

                entity.Property(e => e.CnGStudent)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G_Student");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.CnSStudent).HasColumnName("cn_S_Student");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.CnTTeacher)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T_Teacher");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.FatherNameEmployer)
                    .HasMaxLength(35)
                    .HasColumnName("Father_Name_Employer");

                entity.Property(e => e.Fioteacher)
                    .HasMaxLength(41)
                    .HasColumnName("FIOTeacher");

                entity.Property(e => e.IdCauseCause).HasColumnName("IdCause_Cause");

                entity.Property(e => e.IdCk).HasColumnName("IdCK");

                entity.Property(e => e.IdCurator).HasColumnName("Id_Curator");

                entity.Property(e => e.IdSubjectSubject).HasColumnName("IdSubject_Subject");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.IdSubjectTeacherSubjectTeacher).HasColumnName("IdSubject_Teacher_Subject_Teacher");

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.NameEmpForm)
                    .HasMaxLength(30)
                    .HasColumnName("Name_EmpForm");

                entity.Property(e => e.NameEmployer)
                    .HasMaxLength(35)
                    .HasColumnName("Name_Employer");

                entity.Property(e => e.NameGroup)
                    .HasMaxLength(3)
                    .HasColumnName("Name_Group");

                entity.Property(e => e.NameStudent)
                    .HasMaxLength(35)
                    .HasColumnName("Name_Student");

                entity.Property(e => e.NameSubject)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Subject");

                entity.Property(e => e.SmallName).HasMaxLength(3);

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.SurNameEmployer)
                    .HasMaxLength(35)
                    .HasColumnName("SurName_Employer");

                entity.Property(e => e.Uchashchiysya).HasMaxLength(40);
            });

            modelBuilder.Entity<StudentSkipView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentSkipView");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NameEmpForm)
                    .HasMaxLength(30)
                    .HasColumnName("Name_EmpForm");

                entity.Property(e => e.NameSubject)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Subject");

                entity.Property(e => e.Student).HasMaxLength(40);
            });

            modelBuilder.Entity<StudentSkipView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentSkipView2");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.Date)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName).HasMaxLength(30);

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.Mark).HasMaxLength(10);

                entity.Property(e => e.Student).HasMaxLength(40);

                entity.Property(e => e.SubName).HasMaxLength(50);
            });

            modelBuilder.Entity<StudentsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentsView");

                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.DateBirth).HasColumnType("date");

                entity.Property(e => e.DateIssuePasport).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.PasportData).HasMaxLength(50);

                entity.Property(e => e.PasportId)
                    .HasMaxLength(20)
                    .HasColumnName("PasportID");

                entity.Property(e => e.PassportSeries).HasMaxLength(5);

                entity.Property(e => e.Student).HasMaxLength(107);

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.TelephoneHome)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Home");

                entity.Property(e => e.TelephoneMob)
                    .HasMaxLength(20)
                    .HasColumnName("Telephone_Mob");
            });

            modelBuilder.Entity<SuaEmployment>(entity =>
            {
                entity.HasKey(e => e.IdSuaEmp)
                    .HasName("XPKSUA_Employment")
                    .IsClustered(false);

                entity.ToTable("SUA_Employment");

                entity.Property(e => e.IdSuaEmp).HasColumnName("ID_SUA_Emp");

                entity.Property(e => e.Achievements).HasMaxLength(50);

                entity.Property(e => e.ActivitiesForm).HasMaxLength(50);

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.SuaEmployments)
                    .HasForeignKey(d => d.CnS)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("R_44");
            });

            modelBuilder.Entity<SubjTeachView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubjTeachView");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.SubjectFull).HasMaxLength(100);

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.Teacher).HasMaxLength(107);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.IdSubject)
                    .HasName("XPKSubject")
                    .IsClustered(false);

                entity.ToTable("Subject");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SubjectGroupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Subject_Group_View");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");
            });

            modelBuilder.Entity<SubjectTeacher>(entity =>
            {
                entity.HasKey(e => e.IdSubjectTeacher)
                    .HasName("XPKSubject_Teacher")
                    .IsClustered(false);

                entity.ToTable("Subject_Teacher");

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.HasOne(d => d.CnGNavigation)
                    .WithMany(p => p.SubjectTeachers)
                    .HasForeignKey(d => d.CnG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_8");

                entity.HasOne(d => d.CnTNavigation)
                    .WithMany(p => p.SubjectTeachers)
                    .HasForeignKey(d => d.CnT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_21");

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.SubjectTeachers)
                    .HasForeignKey(d => d.IdSubject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_9");
            });

            modelBuilder.Entity<SubjectTeacherFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Subject_Teacher_Full");

                entity.Property(e => e.CnG)
                    .HasMaxLength(3)
                    .HasColumnName("cn_G");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.Group).HasMaxLength(3);

                entity.Property(e => e.IdSubjectTeacher).HasColumnName("IdSubject_Teacher");

                entity.Property(e => e.Subject).HasMaxLength(20);

                entity.Property(e => e.SubjectFull).HasMaxLength(100);
            });

            modelBuilder.Entity<SubjectTeacherSemester>(entity =>
            {
                entity.HasKey(e => e.IdSubjectTeacherSemester);

                entity.ToTable("SubjectTeacherSemester");

                entity.Property(e => e.IdSubjectTeacherSemester).ValueGeneratedNever();
            });

            modelBuilder.Entity<TargetStudent>(entity =>
            {
                entity.HasKey(e => e.CnS)
                    .HasName("PK__TargetSt__35BD85C99A9743AA");

                entity.ToTable("TargetStudent");

                entity.Property(e => e.CnS)
                    .ValueGeneratedNever()
                    .HasColumnName("cn_S");

                entity.Property(e => e.Remarks).HasMaxLength(40);

                entity.HasOne(d => d.CnSNavigation)
                    .WithOne(p => p.TargetStudent)
                    .HasForeignKey<TargetStudent>(d => d.CnS)
                    .HasConstraintName("R_88");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.CnT)
                    .HasName("XPKTeacher")
                    .IsClustered(false);

                entity.ToTable("Teacher");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.IdCk).HasColumnName("IdCK");

                entity.HasOne(d => d.CnTNavigation)
                    .WithOne(p => p.Teacher)
                    .HasForeignKey<Teacher>(d => d.CnT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_34");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("R_22");

                entity.HasOne(d => d.IdCkNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.IdCk)
                    .HasConstraintName("FK_Teacher_CK");
            });

            modelBuilder.Entity<TeachersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TeachersView");

                entity.Property(e => e.Category).HasMaxLength(25);

                entity.Property(e => e.Ck)
                    .HasMaxLength(50)
                    .HasColumnName("CK");

                entity.Property(e => e.CnT)
                    .HasMaxLength(15)
                    .HasColumnName("cn_T");

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.IdCk).HasColumnName("IdCK");

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.SurName).HasMaxLength(35);

                entity.Property(e => e.Teacher).HasMaxLength(107);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.CountHour).HasColumnName("Count_hour");

                entity.Property(e => e.Date)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1).HasMaxLength(20);

                entity.Property(e => e.Expr2).HasMaxLength(30);

                entity.Property(e => e.FatherName).HasMaxLength(35);

                entity.Property(e => e.Mark).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(35);

                entity.Property(e => e.SurName).HasMaxLength(35);
            });

            modelBuilder.Entity<ViewForPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewForPrint");

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("FIO");

                entity.Property(e => e.GroupName).HasMaxLength(3);

                entity.Property(e => e.NameSpec).HasMaxLength(20);
            });

            modelBuilder.Entity<WeekendOut>(entity =>
            {
                entity.HasKey(e => e.IdWeekendOut);

                entity.ToTable("WeekendOut");

                entity.Property(e => e.IdWeekendOut).HasColumnName("ID_Weekend_Out");

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("date")
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalTime).HasColumnName("Arrival_Time");

                entity.Property(e => e.CnS).HasColumnName("cn_S");

                entity.Property(e => e.DepartureDate)
                    .HasColumnType("date")
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureTime).HasColumnName("Departure_Time");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.HasOne(d => d.CnSNavigation)
                    .WithMany(p => p.WeekendOuts)
                    .HasForeignKey(d => d.CnS)
                    .HasConstraintName("FK_WeekendOut_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
