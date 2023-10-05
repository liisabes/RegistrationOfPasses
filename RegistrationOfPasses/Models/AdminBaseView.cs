using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class AdminBaseView
    {
        public string CnA { get; set; } = null!;
        public string Admin { get; set; } = null!;
        public string? Fio { get; set; }
        public string If { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
    }
}
