using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class LogView
    {
        public DateTime? Datetime { get; set; }
        public string? Date { get; set; }
        public string? Fio { get; set; }
        public string TypeOperation { get; set; } = null!;
    }
}
