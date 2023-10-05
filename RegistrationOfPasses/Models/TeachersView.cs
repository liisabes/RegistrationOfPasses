using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class TeachersView
    {
        public string CnT { get; set; } = null!;
        public string? Teacher { get; set; }
        public string? Fio { get; set; }
        public string? Category { get; set; }
        public int? IdCategory { get; set; }
        public string? Ck { get; set; }
        public int? IdCk { get; set; }
        public string? SurName { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public bool Status { get; set; }
    }
}
