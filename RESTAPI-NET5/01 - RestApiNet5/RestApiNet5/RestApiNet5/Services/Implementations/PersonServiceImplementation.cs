using System;
using RestApiNet5.Model;
using RestApiNet5.Model.Context;

namespace RestApiNet5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private readonly MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.People.ToList();
        }

        public Person? FindById(long id)
        {
            return _context.People.SingleOrDefault(p => p.Id.Equals(id));
            //este trecho esta dando System.InvalidOperationException quando nao encontra um dado, como posso tratar como badrequest?
        }

        public Person Create(Person person)
        {
            try
            {
                _context.AddAsync(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();
            var result = _context.People.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _context.AddAsync(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }


        public void Delete(long id)
        {
            var result = _context.People.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.People.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool Exists(long id)
        {
            return _context.People.Any(p => p.Id.Equals(id));
        }
    }
}

