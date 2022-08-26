using API_TEST.Model;
using System;
using System.Collections.Generic;

namespace API_TEST.BreweryData
{
    public interface IBeer
    {
        List<Beer> GetBeers();
        Beer GetBeer(Guid id);
        Beer AddBeer(Beer beer);

        Beer EditBeer(Beer beer);

        void DeleteBeer(Beer beer);
        List<Beer> GetBeers(int Id_Brewery);
    }
}
