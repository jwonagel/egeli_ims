using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Service;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte einen Name eingeben");
                var name = Console.ReadLine();
                if(name == "exit")
                    break;
                var personService = new PersonService();
                var persons = personService.GetPersonsByName(name);

                if(!persons.Any())
                {
                    Console.WriteLine("Keine Eintrage gefunden");
                }
                else
                {
                    Console.WriteLine($"{persons.Count()} Personen gefunden");
                    foreach (var person in persons)
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
