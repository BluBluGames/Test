using System;

namespace Test.NotificationScheduling.Domain.CompanyAggregate.Exceptions
{
    public class CompanyException : Exception
    {
        public CompanyException(string message, int errorCode) : base($"{errorCode.ToString()} - {message}")
        {
            
        }
    }
}