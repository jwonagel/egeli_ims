using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class Address
    {
        public int Id { get; set; }
        
        public string Street { get; set; }

        public string HouseNr { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"Address: Id {Id} {Street} {HouseNr} \n {Zip} {City}";
        }
    }
}
