using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Hostel
    {
        public int? IdRoom { get; set; }
        public int CnS { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual Room? IdRoomNavigation { get; set; }
    }
}
