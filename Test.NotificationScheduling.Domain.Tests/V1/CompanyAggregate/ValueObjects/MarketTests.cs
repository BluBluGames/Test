using FluentAssertions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate.ValueObjects
{
    public class MarketTests
    {
        [Theory]
        [InlineData(MarketValue.Sweden)]
        [InlineData(MarketValue.Denmark)]
        [InlineData(MarketValue.Norway)]
        [InlineData(MarketValue.Finland)]
        public void Market_ShouldBeCorrect(MarketValue type)
        {
            Market expected = Market.From(type);
            expected.Value.Should().Be(type);
        }
    }
}