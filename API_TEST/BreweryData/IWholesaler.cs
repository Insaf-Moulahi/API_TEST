using API_TEST.Model;
using System;
using System.Collections.Generic;

namespace API_TEST.BreweryData
{
    public interface IWholesaler
    {
        List<Wholesaler> GetWholesalers();
        Wholesaler GetWholesaler(Guid id);
        Wholesaler AddWholesaler(Wholesaler brewery);

        Wholesaler EditWholesaler(Wholesaler brewery);

        void DeleteWholesaler(Wholesaler brewery);
    }
}
