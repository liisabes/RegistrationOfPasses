using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class GetSubjectView
    {
        public int IdSubjectTeacher { get; set; }
        public int IdSubject { get; set; }
        public string CnG { get; set; } = null!;
        public string CnT { get; set; } = null!;
        public int Expr1 { get; set; }
        public string Name { get; set; } = null!;
        public string? FullName { get; set; }
    }
}
