using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Model
{
    public class Beer
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Alcohol_Content { get; set; }
        public int ID_Brewery { get; set; }
        public decimal Price { get; set; }
    }
}
