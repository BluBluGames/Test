using System;

namespace Test.NotificationScheduling.Domain.V1.CompanyAggregate.Exceptions
{
    public class CompanyException : Exception
    {
        public CompanyException(string message, int errorCode) : base($"{errorCode.ToString()} - {message}")
        {
            
        }
    }
}