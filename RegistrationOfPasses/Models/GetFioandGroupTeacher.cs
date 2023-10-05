using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class GetFioandGroupTeacher
    {
        public string? Fioteacher { get; set; }
        public int IdCurator { get; set; }
        public string CnG { get; set; } = null!;
        public string CnC { get; set; } = null!;
        public int? IdCategory { get; set; }
        public string CnT { get; set; } = null!;
        public int? IdCk { get; set; }
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string CnE { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string NameGroup { get; set; } = null!;
        public string CnGGroup { get; set; } = null!;
        public int Cours { get; set; }
        public string CnSpec { get; set; } = null!;
    }
}
