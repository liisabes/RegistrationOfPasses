using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class PromotionPunishView
    {
        public int CnS { get; set; }
        public DateTime? Ppdate { get; set; }
        public string Ppdescription { get; set; } = null!;
        public int IdPromotion { get; set; }
        public string? Ppname { get; set; }
        public string? CategoryName { get; set; }
        public int? IdCategory { get; set; }
        public int? IdType { get; set; }
    }
}
