using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDaycare
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CitiesContract GetCities();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CitiesContract
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public List<City> Cities { get; set; }
    }

    [DataContract]
    public class City
    {
        [DataMember]
        public int CityCode { get; set; }

        [DataMember]
        public string CityName { get; set; }
    }
}
