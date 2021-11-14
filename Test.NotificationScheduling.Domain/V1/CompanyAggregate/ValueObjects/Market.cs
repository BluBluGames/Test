using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects
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