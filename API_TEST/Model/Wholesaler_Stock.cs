using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Model
{
    public class Wholesaler_Stock
    {
        [Key]
        public Guid ID { get; set; }
        public int Quantity_Beer { get; set; }
        public string Name_Beer { get; set; }
        public string Wholesaler_Num { get; set; }
    }
}
