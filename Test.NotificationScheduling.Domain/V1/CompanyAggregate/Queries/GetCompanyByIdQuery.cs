using System;
using MediatR;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries
{
    public class GetCompanyByIdQuery : IRequest<CompanyResponse>
    {
        public Guid Id { get; set; }
    }
    
}