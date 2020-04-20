using DataLibrary.Core;

namespace DataLibrary
{
    public class DataBaseConfiguration : IDataBaseConfiguration
    {
        public string ConnectionString { get; private set; }

        public DataBaseConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
