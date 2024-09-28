using ACMESalesAdvisorsListBackend.Core.DTOs;
using ACMESalesAdvisorsListBackend.Core.Entities;
using AutoMapper;

namespace ACMESalesAdvisorsListBackend.Infraestructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CommercialAdvisor, CommercialAdvisorDto>();
            CreateMap<CommercialAdvisorDto, CommercialAdvisor>();
        }
    }
}
