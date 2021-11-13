using System;
using Test.NotificationScheduling.Domain.CompanyAggregate.ScheduleEntity.ValueObjects;

namespace Test.NotificationScheduling.Domain.CompanyAggregate.ScheduleEntity
{
    public class Notification
    {
        public Guid Id { get; set; }
        public SendingDate SendingDate { get; set; }
        public Company Company { get; set; }
    }
}