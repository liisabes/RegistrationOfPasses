using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class StudentsView
    {
        public int CnS { get; set; }
        public string? Student { get; set; }
        public string? Fio { get; set; }
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
        public string? PasportData { get; set; }
        public DateTime? DateIssuePasport { get; set; }
    }
}
