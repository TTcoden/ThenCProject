using Microsoft.AspNetCore.Authentication;
using ThenC.Data;
using ThenC.Models;
namespace ThenC.Repository.Person
{
	public class PersonRepository : IPersonRepository
    {

		private BaseContext _basecontext;
		public PersonRepository(BaseContext basecontext)
		{
			_basecontext = basecontext;
		}
		public List<PersonModel> GetList()
		{
			return _basecontext.Person.ToList();
		}
	}
}
