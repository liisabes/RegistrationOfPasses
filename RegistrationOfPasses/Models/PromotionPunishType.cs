using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class PromotionPunishType
    {
        public PromotionPunishType()
        {
            PromotionPunishes = new HashSet<PromotionPunish>();
        }

        public int IdType { get; set; }
        public string Ppname { get; set; } = null!;
        public double MaxScore { get; set; }
        public int? IdCategory { get; set; }

        public virtual PromotionPunishCategory? IdCategoryNavigation { get; set; }
        public virtual ICollection<PromotionPunish> PromotionPunishes { get; set; }
    }
}
