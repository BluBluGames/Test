using System;
using System.Collections.Generic;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity.ValueObjects;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries
{
    public class CompanyResponse
    {
        public Guid CompanyId { get; set; }
        public IEnumerable<string> Notifications { get; set; }
    }
}