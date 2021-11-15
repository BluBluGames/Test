using FluentAssertions;
using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity.ValueObjects;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate.ScheduleEntity.ValueObjects
{
    public class SendingDateTests
    {
        [Fact]
        public void SendingDate_ShouldBeCorrect()
        {
            SendingDate expected = SendingDate.From(DateTime.Now.AddDays(1).Date);
            expected.Value.Should().Be(DateTime.Now.AddDays(1).Date);
        }

        [Fact]
        public void SendingDate_ShouldThrowCompanyException()
        {
            Action act = () => SendingDate.From(DateTime.Now.AddDays(-1));
            act.Should().Throw<CompanyException>().WithMessage("1 - Date cannot be in the past");
        }
    }
}