using Kodinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Logic
{
    public class CompayDTO
    {
        public string CompanyName { get; set; }
        public string Initials { get; set; }
        public string numid_nat { get; set; }
        public string tax_num_dgi { get; set; }
        public string description { get; set; }
        public string Email { get; set; }
        public string Pobox { get; set; }
        public string Prov { get; set; }
        public string TownDist { get; set; }
        public string Commune { get; set; }
        public string QuarterSect { get; set; }
        public string AvenueLoc { get; set; }
    }

    public class CompanyResults
    {
        public string message { get; set; }
        public int StatusCode { get; set; }
        public List<Company> Companies { get; set; }
        public Company company { get; set; }
    }
}
