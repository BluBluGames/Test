using System;
using Test.NotificationScheduling.Domain.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.CompanyAggregate.ScheduleEntity.ValueObjects
{
    public class SendingDate : ValueOf<DateTime, SendingDate>
    {
        protected override void Validate()
        {
            if (Value.Date < DateTime.Now.Date)
            {
                throw new CompanyException("Date cannot be in the past", 1);
            }
        }
    }
}