using System;
using System.Collections.Generic;
using Test.NotificationScheduling.Domain.CompanyAggregate.ScheduleEntity;
using Test.NotificationScheduling.Domain.CompanyAggregate.ValueObjects;

namespace Test.NotificationScheduling.Domain.CompanyAggregate
{
    public class Company
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public CompanyType Number { get; set; }
        public Market Type { get; set; }
        public List<Notification> Notifications { get; set; } = new();
    }
}