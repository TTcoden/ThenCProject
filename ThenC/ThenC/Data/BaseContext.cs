using Microsoft.EntityFrameworkCore;
using ThenC.Controllers;
using ThenC.Models;

namespace ThenC.Data
{
    //get Context of framework DbContext
    public class BaseContext : DbContext
    {
        //injection context in constructor and inject(Base) options in Context of framework to use 
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<PersonModel> Person { get; set; }
    }
}