using DataLibrary.Core;

namespace DataLibrary
{
    public class ExampleDataService : IExampleDataService
    {
        public string GetNameById(int id)
        {
            // pretend that i query database
            return id.ToString();
        }
    }
}
