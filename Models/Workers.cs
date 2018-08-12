using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodinet.Models
{
    public partial class Workers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerId { get; set; }
        public int EntityId { get; set; }
        public string JobDescription { get; set; }
        public string GradeId { get; set; }
        // Foreign Key
        public Guid PersonId { get; set; }
        // Navigation property
        public Person Person { get; set; }
    }
}
