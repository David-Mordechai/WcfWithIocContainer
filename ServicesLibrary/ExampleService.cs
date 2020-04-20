using DataLibrary.Core.Services;
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
            return $"User Name: {_exampleDataService.GetNameById(value)}";
        }
    }
}
