﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }
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
}
