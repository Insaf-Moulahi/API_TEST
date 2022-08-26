using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace API_TEST.Model
{
    public class Sale
    {
        [Key]
        public Guid ID { get; set; }      
        public string Wholesaler_Num { get; set; }
        public string Wholesaler_Name { get; set; }
        public DateTime Date_Sale { get; set; }
        public List<Quote> liste_Ligne { get; set; }


    }
}
