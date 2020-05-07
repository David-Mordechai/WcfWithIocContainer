using DataLibrary.Core.Services;
using ServicesLibrary.Core;
using ServicesLibrary.Core.Models;
using System;
using System.Collections.Generic;

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

        public GetCitiesResult GetCities()
        {
            return new GetCitiesResult
            {
                Success = true,
                Error = "No Error",
                Towns = GetFakeData()
            };
        }

        private List<Town> GetFakeData()
        {
            return new List<Town>()
            {
                new Town{ Id = 1, Name = "Ashdod"},
                new Town{ Id = 2, Name = "Jerusalim"},
                new Town{ Id = 3, Name = "Tel Aviv"}
            };
        }
    }
}
