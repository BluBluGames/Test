using System;
using System.Linq;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects
{
    public class Number : ValueOf<string, Number>
    {
        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new ArgumentNullException(typeof(Number).ToString(), "Number cannot be empty");
            if (Value.Length is not 10)
                throw new CompanyException("Invalid length", 1);
            if (!Value.All(c => c is >= '0' and <= '9'))
                throw new CompanyException("Invalid structure", 2);
        }
    }
}