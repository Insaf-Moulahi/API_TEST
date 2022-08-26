using API_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_TEST.BreweryData
{
    public class SqlWholesalersData : IWholesaler
    {
        private WholesalerContext _WholesalerContext;
        public SqlWholesalersData(WholesalerContext wholesalerContext)
        {
            _WholesalerContext = wholesalerContext;
        }
        public Wholesaler AddWholesaler(Wholesaler wholesaler)
        {
            wholesaler.ID = Guid.NewGuid();
            _WholesalerContext.Wholesalers.Add(wholesaler);
            _WholesalerContext.SaveChanges();
            return wholesaler;
        }

        public void DeleteWholesaler(Wholesaler wholesaler)
        {
            _WholesalerContext.Wholesalers.Remove(wholesaler);
            _WholesalerContext.SaveChanges();

        }

        public Wholesaler EditWholesaler(Wholesaler wholesaler)
        {
            var existing_wholesaler = _WholesalerContext.Wholesalers.Find(wholesaler.ID);
            if (existing_wholesaler != null)
            {
                existing_wholesaler.Wholesaler_Num = wholesaler.Wholesaler_Num;
                existing_wholesaler.Wholesaler_Name = wholesaler.Wholesaler_Name;
            
                _WholesalerContext.Wholesalers.Update(wholesaler);
                _WholesalerContext.SaveChanges();
            }
            return wholesaler;
        }

        public Wholesaler GetWholesaler(Guid id)
        {
            return _WholesalerContext.Wholesalers.SingleOrDefault(x => x.ID == id);
        }

        public List<Wholesaler> GetWholesalers()
        {
            return _WholesalerContext.Wholesalers.ToList();
        }
    }
}
