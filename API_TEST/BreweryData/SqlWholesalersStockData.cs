using API_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_TEST.BreweryData
{
    public class SqlWholesalersStockData : IWholesaler_Stock
    {
        private Wholesaler_StockContext _WholesalerStockContext;
        public SqlWholesalersStockData(Wholesaler_StockContext wholesalerStockContext)
        {
            _WholesalerStockContext = wholesalerStockContext;
        }
        public Wholesaler_Stock AddWholesaler_Stock(Wholesaler_Stock wholesalerStock)
        {
            wholesalerStock.ID = Guid.NewGuid();
            _WholesalerStockContext.Wholesalers_Stock.Add(wholesalerStock);
            _WholesalerStockContext.SaveChanges();
            return wholesalerStock;
        }

        public void DeleteWholesaler_Stock(Wholesaler_Stock wholesalerStock)
        {
            _WholesalerStockContext.Wholesalers_Stock.Remove(wholesalerStock);
            _WholesalerStockContext.SaveChanges();
        }

        public Wholesaler_Stock EditWholesaler_Stock(Wholesaler_Stock wholesalerStock)
        {
            var existing_wholesalerStock = _WholesalerStockContext.Wholesalers_Stock.Find(wholesalerStock.ID);
            if (existing_wholesalerStock != null)
            {
                existing_wholesalerStock.Wholesaler_Num = wholesalerStock.Wholesaler_Num;
                existing_wholesalerStock.Name_Beer = wholesalerStock.Name_Beer;
                existing_wholesalerStock.Quantity_Beer = wholesalerStock.Quantity_Beer;
                _WholesalerStockContext.Wholesalers_Stock.Update(wholesalerStock);
                _WholesalerStockContext.SaveChanges();
            }
            return wholesalerStock;
        }

        public List<Wholesaler_Stock> GetWholesalers_Stock()
        {
            return _WholesalerStockContext.Wholesalers_Stock.ToList();
        }

        public Wholesaler_Stock GetWholesaler_Stock(Guid id)
        {
            return _WholesalerStockContext.Wholesalers_Stock.SingleOrDefault(x => x.ID == id);
        }
    }
}
