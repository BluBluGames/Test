using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class CompanyRoutes
        {
            public const string Get = Base + "/companies/{companyId}";
            public const string Create = Base + "/companies";
        }
    }

}
