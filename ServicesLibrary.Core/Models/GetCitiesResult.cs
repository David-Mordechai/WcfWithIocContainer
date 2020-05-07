using System.Collections.Generic;

namespace ServicesLibrary.Core.Models
{
    public class GetCitiesResult : ResultBase
    {
        public List<Town> Towns { get; set; }
    }
}
