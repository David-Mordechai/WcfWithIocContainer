using AutoMapper;
using ServicesLibrary.Core;
using System;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Daycare : IDaycare
    {
        private readonly IExampleService _exampleService;
        private readonly IMapper _mapper;

        public Daycare(IExampleService exampleService, IMapper mapper)
        {
            _exampleService = exampleService;
            _mapper = mapper;
        }

        public string GetData(int value)
        {
            return _exampleService.GetData(value);
        }

        public CitiesContract GetCities()
        {
            var citiesResult = _exampleService.GetCities();

            var result = _mapper.Map<CitiesContract>(citiesResult);

            return result;
        }

    }
}
