using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries
{
    public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        
        public GetCompanyByIdQueryHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<CompanyResponse> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetByIdAsync(request.Id);
        }
    }
}