using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kodinet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kodinet.Logic
{
    public class Objects
    {
        
    }
    public class PersonMap
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string POBox { get; set; }
        public string Prov { get; set; }
        public string TownDist { get; set; }
        public string Commune { get; set; }
        public string QuarterSect { get; set; }
        public string AvenueLoc { get; set; }
        public string Number { get; set; }
        public string ChipNumber { get; set; }
        public string Discriminator { get; set; }
        public string FingerPrintId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string BirthPlace { get; set; }
        public string BirthDate { get; set; }
        public string Nationality { get; set; }
        public string IdNumber { get; set; }
        public string   Photo { get; set; }
        public string signature { get; set; }
    }

    public class RegesteredPersonResult
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Person> person { get; set; }
        public Person OnePerson { get; set; }
    }


}