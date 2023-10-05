using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class View1
    {
        public string? Date { get; set; }
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Expr1 { get; set; } = null!;
        public int? CountHour { get; set; }
        public string Expr2 { get; set; } = null!;
        public int IdListAcademicDebt { get; set; }
        public string? Mark { get; set; }
        public bool? Status { get; set; }
    }
}
