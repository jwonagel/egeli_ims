using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Service.Model;

namespace Service.Service
{
    public class PersonService
    {
        public IEnumerable<Person> GetPersons()
        {
            var query = "SELECT ID, VORNAME, NACHNAME FROM PERSON;";

            using (var connection = ConnectionFactory.GetConnection())
            {
                var command = new SqlCommand(query, connection);
                var persons = new List<Person>();

                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = (int) reader[0];
                    var vorname = (string) reader[1];
                    var nachname = (string) reader[2];
                    var person = new Person
                    {
                        Vorname = vorname,
                        Nachname = nachname,
                        Id = id
                    };
                    persons.Add(person);
                }

                return persons;
            }

        }
    }
}
