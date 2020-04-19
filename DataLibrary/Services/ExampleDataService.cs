using DataLibrary.Core;
using System.Linq;

namespace DataLibrary.Services
{
    public class ExampleDataService : IExampleDataService
    {
        private readonly DataLibraryDbContext _dbContext;

        public ExampleDataService(DataLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string GetNameById(int id)
        {
            var a = _dbContext.Users.FirstOrDefault();
            // pretend that i query database
            return id.ToString();
        }
    }
}
