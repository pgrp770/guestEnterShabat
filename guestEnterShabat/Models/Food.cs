using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestEnterShabat.Models
{
    internal class Food
    {
        public int? ID { get; set; }
        public int GuestID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public string? GuestName {  get; set; }

        public Food(int iD, int guestID, int categoryID, string name)
        {
            ID = iD;
            GuestID = guestID;
            CategoryID = categoryID;
            Name = name;
        }
    }
}
