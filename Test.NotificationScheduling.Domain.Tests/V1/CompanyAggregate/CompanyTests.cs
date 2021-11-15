using FluentAssertions;
using System;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Commands.Create;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity;
using Xunit;

namespace Test.NotificationScheduling.Domain.Tests.V1.CompanyAggregate
{
    public class CompanyTests
    {
        [Fact]
        public void ShouldCreateCompany()
        {
            var command = new CreateCommand
            {
                Name = "TestCorop",
                Number = "1234567891",
                CompanyType = CompanyTypeValue.Large,
                Market = MarketValue.Denmark,
                CreationDate = DateTime.Now.Date,
            };

            var company = new Company(command);

            company.Should().NotBeNull();
            company.Name.Value.Should().Be("TestCorop");
            company.Number.Value.Should().Be("1234567891");
            company.CompanyType.Value.Should().Be(CompanyTypeValue.Large);
            company.Market.Value.Should().Be(MarketValue.Denmark);
            company.Notifications.Should().NotBeEmpty().And.HaveCount(5).And.ContainItemsAssignableTo<Notification>();
        }

        [Fact]
        public void ShouldNotCreateCompany()
        {
            var command = new CreateCommand
            {
                Name = "TestCorop",
                Number = "1234567891a",
                CompanyType = CompanyTypeValue.Large,
                Market = MarketValue.Denmark,
                CreationDate = DateTime.Now.Date,
            };

            Action act = () => new Company(command);

            act.Should().Throw<CompanyException>().WithMessage("1 - Invalid length");
        }
    }
}