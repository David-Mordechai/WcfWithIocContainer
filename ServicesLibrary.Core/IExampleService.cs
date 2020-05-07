using ServicesLibrary.Core.Models;

namespace ServicesLibrary.Core
{
    public interface IExampleService
    {
        string GetData(int value);
        GetCitiesResult GetCities();
    }
}
