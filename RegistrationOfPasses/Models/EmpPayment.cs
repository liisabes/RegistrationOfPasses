using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class EmpPayment
    {
        public int IdEmpPayment { get; set; }
        public string Secretar { get; set; } = null!;
        public string Accout { get; set; } = null!;
        public string? BankAdress { get; set; }
    }
}
