using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class OtrabotkiEdit
    {
        public string? StudentFio { get; set; }
        public string GroupName { get; set; } = null!;
        public DateTime? DataEmp { get; set; }
        public DateTime? DateIssue { get; set; }
        public string SubjName { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string SurNameEmpl { get; set; } = null!;
        public string NameEmpl { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public DateTime? DatePays { get; set; }
        public DateTime? DateWorks { get; set; }
        public string Marks { get; set; } = null!;
        public int Hours { get; set; }
        public decimal Price { get; set; }
        public bool Stat { get; set; }
        public int Id { get; set; }
    }
}
