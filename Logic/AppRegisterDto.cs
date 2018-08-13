using Kodinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Logic
{
    public class AppRegisterDto
    {
        public string UserName { get; set; }
        public string pin { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string FingerPrint { get; set; }
    }

    public class AppRegisterResult
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public AppRegisterDto appRegistration { get; set; }
        public List<AppRegistration> registrations { get; set; }
    }

    public class Login
    {
        public string UserName { get; set; }
        public string pin { get; set; }
    }

    public class LoginResult
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public AppRegistration GetAppRegistrations { get; set; }
    }
}
