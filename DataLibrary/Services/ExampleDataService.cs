using DataLibrary.Core.Services;
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
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            if (user == null) return string.Empty;

            return $"{user.FirstName} {user.LastName}";
        }
    }
}
