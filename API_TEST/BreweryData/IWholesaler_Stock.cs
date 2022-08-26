using API_TEST.Model;
using System;
using System.Collections.Generic;

namespace API_TEST.BreweryData
{
    public interface IWholesaler_Stock
    {
        List<Wholesaler_Stock> GetWholesalers_Stock();
        Wholesaler_Stock GetWholesaler_Stock(Guid id);
        Wholesaler_Stock AddWholesaler_Stock(Wholesaler_Stock wholesalerStock);

        Wholesaler_Stock EditWholesaler_Stock(Wholesaler_Stock wholesalerStock);

        void DeleteWholesaler_Stock(Wholesaler_Stock wholesalerStock);
    }
}
