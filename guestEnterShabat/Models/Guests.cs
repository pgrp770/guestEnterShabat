using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestEnterShabat.Models
{
    internal class Guests
    {

        public int? ID { get; set; }
        public string Name { get; set; }
        public Guests(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public Guests(string name)
        {
            ID = null;
            Name = name;
        }

    }
}
