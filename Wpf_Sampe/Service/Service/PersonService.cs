using System.Collections.Generic;
using Service.Model;

namespace Service.Service
{
    public class PersonService
    {
        public IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person
                {
                    Nachname = "Muster",
                    Vorname = "Max"
                },
                new Person
                {
                    Nachname = "Meier",
                    Vorname = "Felix"
                }
            };
        }
    }
}
