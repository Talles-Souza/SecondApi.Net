using PersonApi.Net.Models;

namespace PersonApi.Net.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        

        public Person Create(Person person)
        {
            return person;    
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> people = null;
            return people;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Talles",
                LastName = "Souza",
                Address = "Petrópolis",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
