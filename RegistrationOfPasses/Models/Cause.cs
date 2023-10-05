using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Cause
    {
        public Cause()
        {
            StudentSkips = new HashSet<StudentSkip>();
        }

        public int IdCause { get; set; }
        public string Name { get; set; } = null!;
        public string SmallName { get; set; } = null!;

        public virtual ICollection<StudentSkip> StudentSkips { get; set; }
    }
}
