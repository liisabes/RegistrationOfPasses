using System;
using System.Collections.Generic;

namespace RegistrationOfPasses.Models
{
    public partial class Room
    {
        public Room()
        {
            Hostels = new HashSet<Hostel>();
        }

        public int IdRoom { get; set; }
        public int RoomNumber { get; set; }
        public int PeopleAmount { get; set; }

        public virtual ICollection<Hostel> Hostels { get; set; }
    }
}
