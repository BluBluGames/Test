using System;
using Test.NotificationScheduling.Domain.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.CompanyAggregate.ValueObjects
{
    public class Market : ValueOf<MarketValue, Market>
    {
        protected override void Validate()
        {
            if (Enum.IsDefined(typeof(MarketValue), Value) == false)
            {
                throw new CompanyException("Market not supported", 1);
            }
        }
    }
}