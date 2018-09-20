using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new Model1())
            {
                var query = from person in model.PERSON
                    join address in model.ADDRESS on person.ADDRESS.ID equals address.ID
                    where address.STREET.Contains("Teufen")
                    select person;

                foreach (var person in query)
                {
                    Console.WriteLine(person.NACHNAME + "  " + person.NACHNAME);
                }

                Console.ReadKey();
            }
        }
    }
}
