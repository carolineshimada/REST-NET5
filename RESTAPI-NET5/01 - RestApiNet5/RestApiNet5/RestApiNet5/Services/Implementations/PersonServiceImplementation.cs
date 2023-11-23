using System;
using RestApiNet5.Model;
using RestApiNet5.Model.Context;

namespace RestApiNet5.Services.Implementations
{
	public class PersonServiceImplementation : IPersonService
	{
        List<Person> people = new List<Person>();
        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {

                return _context.People.ToList();
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = 1,
                FirstName = "CRISTINA",
                LastName = "OLIVEIRA",
                Address = "MG",
                Genger = "Female"
            };
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Carol",
                LastName = "Salewski",
                Address = "SP - Brazil",
                Genger = "Female"
            };
        }


        public Person Update(Person person)
        {
            return person;
        }
    }
}

