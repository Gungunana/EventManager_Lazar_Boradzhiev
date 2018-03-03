using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Event : BaseEntity
    {
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [Required]
        [MaxLength(75)]
        public string Location { get; set; }

        [Required]
        public DateTime StartsAt { get; set; }
        
        [Required]
        public DateTime EndsAt { get; set; }
    }
}
