using System;
using System.Threading.Tasks;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate
{
    public interface ICompanyRepository
    {
        ValueTask<Guid> Create(Company company);
        ValueTask<CompanyResponse> GetByIdAsync(Guid requestId);
    }
}