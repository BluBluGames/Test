using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects
{
    public class CompanyType : ValueOf<CompanyTypeValue, CompanyType>
    {
        protected override void Validate()
        {
            if (Enum.IsDefined(typeof(CompanyTypeValue), Value) == false)
            {
                throw new CompanyException("Company type not supported", 1);
            }
        }
    }
}