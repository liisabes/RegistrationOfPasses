using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class GetStudetGruppa
    {
        public int CnS { get; set; }
        public string? Uchashchiysya { get; set; }
        public string? Name { get; set; }
        public string? TelephoneHome { get; set; }
        public string? TelephoneMob { get; set; }
        public string? Adress { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? PassportSeries { get; set; }
        public int? PassportNumber { get; set; }
        public string? PasportId { get; set; }
        public bool? Gender { get; set; }
        public string? FatherName { get; set; }
        public string? SurName { get; set; }
        public string? CnG { get; set; }
        public int? IdMg { get; set; }
        public bool? Brsm { get; set; }
        public bool? TradeUnion { get; set; }
        public string? PreviousPlaceOfStudy { get; set; }
        public bool? Rb { get; set; }
        public DateTime? StateDateOfStudy { get; set; }
        public bool? FamilyState { get; set; }
        public string NameGroup { get; set; } = null!;
    }
}
