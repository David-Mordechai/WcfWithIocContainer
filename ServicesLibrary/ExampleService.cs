using DataLibrary.Core;
using ServicesLibrary.Core;

namespace ServicesLibrary
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleDataService _exampleDataService;

        public ExampleService(IExampleDataService exampleDataService)
        {
            _exampleDataService = exampleDataService;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", _exampleDataService.GetNameById(value));
        }
    }
}
