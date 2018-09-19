using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}  Name: {Nachname} {Vorname} \n" + Address;
        }
    }
}
