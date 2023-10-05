using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class PromotionPunish
    {
        public int IdPromotion { get; set; }
        public DateTime? Ppdate { get; set; }
        public string Ppdescription { get; set; } = null!;
        public int CnS { get; set; }
        public int? IdType { get; set; }

        public virtual Student CnSNavigation { get; set; } = null!;
        public virtual PromotionPunishType? IdTypeNavigation { get; set; }
    }
}
