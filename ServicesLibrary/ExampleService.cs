using ServicesLibrary.Core;

namespace ServicesLibrary
{
    public class ExampleService : IExampleService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
