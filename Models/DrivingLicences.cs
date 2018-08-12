using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodinet.Models
{
    public partial class DrivingLicences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string DlNumber { get; set; }
        public string PlaceOfIssue { get; set; }
        public string DateOfIssue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CertificateNumber { get; set; }
        public bool CategoryA { get; set; }
        public bool CategoryB { get; set; }
        public bool CategoryC { get; set; }
        public bool CategoryD { get; set; }
        public bool CategoryE { get; set; }
        public Guid PeronId { get; set; }
        public Person IdNavigation { get; set; }
    }
}
