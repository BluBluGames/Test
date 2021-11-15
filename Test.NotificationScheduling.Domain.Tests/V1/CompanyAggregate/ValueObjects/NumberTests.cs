using FluentAssertions;
using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate.ValueObjects
{
    public class NumberTests
    {
        [Fact]
        public void Number_ShouldBeCorrect()
        {
            Number expected = Number.From("1234567891");
            expected.Value.Should().Be("1234567891");
        }

        [Fact]
        public void Number_ShouldThrowCompanyException_WhenArgumentIsNull()
        {
            Action act = () => Number.From("");
            act.Should().Throw<ArgumentNullException>().WithMessage("Number cannot be empty (Parameter 'Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects.Number')");
        }

        [Fact]
        public void Number_ShouldThrowCompanyException_WhenLengthIsInvalid()
        {
            Action act = () => Number.From("123456789123");
            act.Should().Throw<CompanyException>().WithMessage("1 - Invalid length");
        }

        [Fact]
        public void Number_ShouldThrowCompanyException_WhenIsNotDigitsOnly()
        {
            Action act = () => Number.From("123456789a");
            act.Should().Throw<CompanyException>().WithMessage("2 - Invalid structure");
        }

    }
}