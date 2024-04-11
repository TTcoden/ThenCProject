using Microsoft.AspNetCore.Authentication;
using ThenC.Data;
using ThenC.Models;
namespace ThenC.Repository.Person
{
	public class TablesRepository : ITablesRepository
	{

		private BaseContext _basecontext;
		public TablesRepository(BaseContext basecontext)
		{
			_basecontext = basecontext;
		}
	
        public List<TablesModel> GetList()
        {
            return _basecontext.Tables.ToList();
        }
    }
}
