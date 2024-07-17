using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestEnterShabat.Models
{
    internal class Categories
    {

        public int? ID { get; set; }
        public string Name { get; set; }
        public Categories(int iD, string name)
        {
            ID = iD;
            Name = name;
        }


    }
}
