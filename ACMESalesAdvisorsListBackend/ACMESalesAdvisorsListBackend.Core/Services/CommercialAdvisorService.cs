using ACMESalesAdvisorsListBackend.Core.Entities;
using ACMESalesAdvisorsListBackend.Core.Interfaces;

namespace ACMESalesAdvisorsListBackend.Core.Services
{
    public class CommercialAdvisorService : ICommercialAdvisorService
    {
        public IEnumerable<CommercialAdvisor> GetAllCommercialAdvisors()
        {
            List<CommercialAdvisor> commercialAdvisorList = new List<CommercialAdvisor>();
            for (int i = 1; i <= 5; i++)
            {
                commercialAdvisorList.Add(new CommercialAdvisor
                {
                    DocumentNumber = $"1 - {i}",
                    DocumentType = $"CC {i}",
                    FirstName = $"Test {i}",
                    Id = i,
                    LastName = $"Testing {i}"
                });
            }
            return commercialAdvisorList;
        }

        public Task<CommercialAdvisor> CreateCommercialAdvisor(CommercialAdvisor commercialAdvisor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCommercialAdvisorById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CommercialAdvisor> GetCommercialAdvisorById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCommercialAdvisor(CommercialAdvisor commercialAdvisor)
        {
            throw new NotImplementedException();
        }
    }
}
