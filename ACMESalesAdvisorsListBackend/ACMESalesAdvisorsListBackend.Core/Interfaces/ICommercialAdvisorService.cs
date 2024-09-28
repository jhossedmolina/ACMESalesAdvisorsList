using ACMESalesAdvisorsListBackend.Core.Entities;

namespace ACMESalesAdvisorsListBackend.Core.Interfaces
{
    public interface ICommercialAdvisorService
    {
        public IEnumerable<CommercialAdvisor> GetAllCommercialAdvisors();

        public Task<CommercialAdvisor> GetCommercialAdvisorById(long id);

        public Task<CommercialAdvisor> CreateCommercialAdvisor(CommercialAdvisor commercialAdvisor);

        public Task<bool> UpdateCommercialAdvisor(CommercialAdvisor commercialAdvisor);

        public Task<bool> DeleteCommercialAdvisorById(long id);
    }
}
