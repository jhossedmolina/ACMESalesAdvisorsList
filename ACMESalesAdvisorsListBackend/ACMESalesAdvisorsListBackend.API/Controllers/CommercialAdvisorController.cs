using ACMESalesAdvisorsListBackend.Core.DTOs;
using ACMESalesAdvisorsListBackend.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACMESalesAdvisorsListBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialAdvisorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommercialAdvisorService _commercialAdvisorService;

        public CommercialAdvisorController(IMapper mapper, ICommercialAdvisorService commercialAdvisorService)        
        {
            _mapper = mapper;
            _commercialAdvisorService = commercialAdvisorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCommercialAdvisors()
        {
            var commercialAdvisors = _commercialAdvisorService.GetAllCommercialAdvisors();
            var commercialAdvisorsDto = _mapper.Map<IEnumerable<CommercialAdvisorDto>>(commercialAdvisors);
            return Ok(commercialAdvisorsDto);
        }
    }
}
