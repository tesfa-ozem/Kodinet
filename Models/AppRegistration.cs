using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Models
{
    public class AppRegistration
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string pin { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string FingerPrint { get; set; }


    }
}
