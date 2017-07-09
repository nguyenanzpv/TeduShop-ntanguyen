using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatics")]
    public class VisitorStatitic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitedDate { set; get; }
        [Required]
        public string IPAddress { set; get; }
    }
}
