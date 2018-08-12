using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodinet.Models
{
    public partial class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Pobox { get; set; }
        public string Prov { get; set; }
        public string TownDist { get; set; }
        public string Commune { get; set; }
        public string QuarterSect { get; set; }
        public string AvenueLoc { get; set; }
        public string Number { get; set; }
        public string ChipNumber { get; set; }
        public string Discriminator { get; set; }
        public string FingerPrintId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string BirthPlace { get; set; }
        public string BirthDate { get; set; }
        public string Nationality { get; set; }
        public string IdNumber { get; set; }
        public string Photo { get; set; }
        public string  Signature { get; set; }
        
    }
}
