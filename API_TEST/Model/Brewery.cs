using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Model
{
    public class Brewery
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(1000)]   
        public string Name { get; set; }
    }
}
