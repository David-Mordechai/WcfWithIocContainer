using ServicesLibrary.Core;
using System;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Daycare : IDaycare
    {
        private readonly IExampleService _exampleService;

        public Daycare(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        public string GetData(int value)
        {
            return _exampleService.GetData(value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
