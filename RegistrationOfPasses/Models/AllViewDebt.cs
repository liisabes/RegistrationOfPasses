using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AllViewDebt
    {
        public string? StudentFio { get; set; }
        public string GroupName { get; set; } = null!;
        public string? DataEmp { get; set; }
        public string? DateIssue { get; set; }
        public string SubjName { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string? DatePays { get; set; }
        public string? DateWorks { get; set; }
        public string? Marks { get; set; }
        public float? Hours { get; set; }
        public bool? Stat { get; set; }
        public string? Prepod { get; set; }
        public decimal? Price { get; set; }
        public int Id { get; set; }
        public int? CauseGive { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
