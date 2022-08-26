using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Model
{
    public class Wholesaler
    {
        [Key]
        public Guid ID { get; set; }
      
        public string Wholesaler_Num { get; set; }
        public string Wholesaler_Name { get; set; }
       
    }
}
