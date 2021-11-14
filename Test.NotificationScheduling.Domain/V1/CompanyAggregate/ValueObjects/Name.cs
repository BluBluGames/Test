using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using ValueOf;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects
{
    public class Name : ValueOf<string, Name>
    {
        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new CompanyException("Name cannot be empty", 1);
        }
    }
}