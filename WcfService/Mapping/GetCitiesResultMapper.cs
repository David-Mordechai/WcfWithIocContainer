using AutoMapper;
using ServicesLibrary.Core.Models;

namespace WcfService.Mapping
{
    public class GetCitiesResultMapper : Profile
    {
        public GetCitiesResultMapper()
        {
            CreateMap<GetCitiesResult, CitiesContract>()
                .ForMember(d => d.ErrorMessage, opt => opt.MapFrom(s => s.Error))
                .ForMember(d => d.Cities, opt => opt.MapFrom(s => s.Towns));
        }
    }
}