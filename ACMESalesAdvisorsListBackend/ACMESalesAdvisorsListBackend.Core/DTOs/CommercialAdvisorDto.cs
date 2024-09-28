namespace ACMESalesAdvisorsListBackend.Core.DTOs
{
    public class CommercialAdvisorDto
    {
        public long Id { get; set; }

        public string DocumentType { get; set; } = null!;

        public string DocumentNumber { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
    }
}
