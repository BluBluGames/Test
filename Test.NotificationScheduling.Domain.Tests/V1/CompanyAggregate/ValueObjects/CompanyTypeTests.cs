using FluentAssertions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate.ValueObjects
{
    public class CompanyTypeTests
    {
        [Theory]
        [InlineData(CompanyTypeValue.Large)]
        [InlineData(CompanyTypeValue.Medium)]
        [InlineData(CompanyTypeValue.Small)]
        public void CompanyType_ShouldBeCorrect(CompanyTypeValue type)
        {
            CompanyType expected = CompanyType.From(type);
            expected.Value.Should().Be(type);
        }
    }
}