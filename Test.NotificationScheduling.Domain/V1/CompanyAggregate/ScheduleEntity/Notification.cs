using System;
using System.ComponentModel.DataAnnotations;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity.ValueObjects;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }
        public SendingDate SendingDate { get; set; }
        public Company Company { get; set; }
    }
}