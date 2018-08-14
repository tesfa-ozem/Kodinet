using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Logic
{
    public class UserRegistrationRequest
    {
        public string Identifier { get; internal set; }
        public string Fingerprint { get; set; }
    }

    public class FingerprintValidationResult
    {
        public bool IsSuccessful { get; internal set; }
        public int MatchResult { get; internal set; }
        public string Identifier { get; internal set; }
        public int StatusCode { get; internal set; }
        public string StatusMessage { get; internal set; }
        public string Error { get; internal set; }
    }

    public class FingerprintValidationRequest
    {
        public string Fingerprint { get; internal set; }
        public string Identifier { get; internal set; }
    }
}
