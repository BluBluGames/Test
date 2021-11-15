using FluentAssertions;
using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate.ValueObjects
{
    public class NameTests
    {
        [Fact]
        public void Name_ShouldBeCorrect()
        {
            Name expected = Name.From("Name");
            expected.Value.Should().Be("Name");
        }

        [Fact]
        public void Name_ShouldThrowCompanyException()
        {
            Action act = () => Name.From("");
            act.Should().Throw<CompanyException>().WithMessage("1 - Name cannot be empty");
        }
    }
}