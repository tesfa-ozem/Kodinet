using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Logic
{
    public class DlDTO
    {

        public string DlNumber { get; set; }
        public string PlaceOfIssue { get; set; } 
        public bool CategoryA { get; set; }
        public bool CategoryB { get; set; }
        public bool CategoryC { get; set; }
        public bool CategoryD { get; set; }
        public bool CategoryE { get; set; }
        public string FingerPrintId { get; set; }
    }

    public class DlRegestrationResult
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
