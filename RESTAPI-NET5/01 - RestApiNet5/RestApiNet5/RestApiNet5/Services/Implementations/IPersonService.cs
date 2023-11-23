using RestApiNet5.Model;

namespace RestApiNet5.Services.Implementations
{
	public interface IPersonService
	{
		Person Create(Person? person);

		Person FindById(long id);

		Person Update(Person person);

		void Delete(long id);

		List<Person> FindAll();
	}
}

