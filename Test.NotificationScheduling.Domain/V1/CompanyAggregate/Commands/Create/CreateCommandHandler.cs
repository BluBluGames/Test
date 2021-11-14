using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Commands.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand, Guid>
    {
        private readonly ICompanyRepository _companyRepository;
        
        public CreateCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<Guid> Handle(CreateCommand command, CancellationToken cancellationToken)
        {
            return await _companyRepository.Create(new Company(command));
        }
    }
}