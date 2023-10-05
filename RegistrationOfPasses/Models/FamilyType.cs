using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class FamilyType
    {
        public FamilyType()
        {
            FamilyCharacteristics = new HashSet<FamilyCharacteristic>();
        }

        public int IdType { get; set; }
        public string FamilyTypeName { get; set; } = null!;

        public virtual ICollection<FamilyCharacteristic> FamilyCharacteristics { get; set; }
    }
}
