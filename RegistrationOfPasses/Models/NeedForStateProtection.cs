﻿using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class NeedForStateProtection
    {
        public int CnS { get; set; }
        public string Remarks { get; set; } = null!;

        public virtual Student CnSNavigation { get; set; } = null!;
    }
}