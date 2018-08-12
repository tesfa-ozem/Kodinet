using Kodinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Kodinet.Logic
{
    public class WorkerDTO
    {
        
        public int EntityId { get; set; }
        public string JobDescription { get; set; }
        public string GradeId { get; set; }
        public Guid personId { get; set; }
        
        
        
    }


    public class WokerResult
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Workers> workers { get; set; }
    }

}
