using System;
using MediatR;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Commands.Create
{
    public class CreateCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public CompanyTypeValue CompanyType { get; set; }
        public MarketValue Market { get; set; }
        public DateTime CreationDate { get; set; }
    }
}