using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace API_TEST.Model
{
    public class Quote
    {
        [Key]
        public Guid ID { get; set; }
        public int Quantity_Beer { get; set; }
        public Guid ID_Sale { get; set; }
        public int ID_Beer { get; set; }
        public string Beer_Name { get; set; }
        public string Wholesaler_Num { get; set; }
        public decimal Price { get; set; }
        public decimal Total_Price { get; set; }
    }
}
