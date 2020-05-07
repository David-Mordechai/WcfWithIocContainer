using AutoMapper;
using ServicesLibrary.Core.Models;

namespace WcfService.Mapping
{
    public class CityMapper : Profile
    {
        public CityMapper()
        {
            CreateMap<Town, City>()
                .ForMember(d => d.CityCode, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.CityName, opt => opt.MapFrom(s => s.Name));
        }
    }
}