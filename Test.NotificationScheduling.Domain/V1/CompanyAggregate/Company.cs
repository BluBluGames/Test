using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Commands.Create;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Enums;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity.ValueObjects;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ValueObjects;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Number Number { get; set; }
        public CompanyType CompanyType { get; set; }
        public Market Market { get; set; }
        public List<Notification> Notifications { get; set; } = new();

        public Company()
        {
            
        }

        public Company(CreateCommand command)
        {
            Name = Name.From(command.Name);
            Number = Number.From(command.Number);
            CompanyType = CompanyType.From(command.CompanyType);
            Market = Market.From(command.Market);
            SetNotifications(command.CreationDate);
        }

        private void SetNotifications(DateTime sendingDate)
        {
            switch (Market.Value)
            {
                case MarketValue.Denmark:
                    Notifications.AddRange(AddNotifications(new [] { 1,5,10,15,20 }, sendingDate));
                    break;
                case MarketValue.Finland:
                    if (CompanyType.Value is CompanyTypeValue.Large)
                        Notifications.AddRange(AddNotifications(new [] { 1,5,10,15,20 }, sendingDate));
                    break;
                case MarketValue.Norway:
                    Notifications.AddRange(AddNotifications(new [] { 1,5,10,20 }, sendingDate));
                    break;
                case MarketValue.Sweden:
                    if (CompanyType.Value is CompanyTypeValue.Small or CompanyTypeValue.Medium) 
                        Notifications.AddRange(AddNotifications(new [] { 1,7,14,28 }, sendingDate));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        private IEnumerable<Notification> AddNotifications(IEnumerable<int> days, DateTime creationDate)
        {
            return days
                .Select(day => new Notification { SendingDate = SendingDate.From(creationDate.AddDays(day)) })
                .ToList();
        }
    }
}