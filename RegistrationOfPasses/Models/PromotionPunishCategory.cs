using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class PromotionPunishCategory
    {
        public PromotionPunishCategory()
        {
            PromotionPunishTypes = new HashSet<PromotionPunishType>();
        }

        public int IdCategory { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<PromotionPunishType> PromotionPunishTypes { get; set; }
    }
}
