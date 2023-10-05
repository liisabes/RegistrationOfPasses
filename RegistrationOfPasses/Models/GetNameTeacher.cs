using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class GetNameTeacher
    {
        public string? Fioteacher { get; set; }
        public int IdSubjectTeacher { get; set; }
        public int IdSubjectSubjectTeacher { get; set; }
        public string CnG { get; set; } = null!;
        public string CnT { get; set; } = null!;
        public int? IdCategory { get; set; }
        public string CnTTeacher { get; set; } = null!;
        public int? IdCk { get; set; }
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string CnE { get; set; } = null!;
        public string NameSubject { get; set; } = null!;
        public int IdSubject { get; set; }
    }
}
