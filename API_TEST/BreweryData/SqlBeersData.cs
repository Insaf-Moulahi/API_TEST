using API_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_TEST.BreweryData
{
    public class SqlBeersData : IBeer
    {
        private BeerContext _BeerContext;
        public SqlBeersData(BeerContext beerContext)
        {
            _BeerContext = beerContext;
        }
        public Beer AddBeer(Beer beer)
        {
            beer.ID = Guid.NewGuid();
            _BeerContext.Beers.Add(beer);
            _BeerContext.SaveChanges();
            return beer;
        }

        public void DeleteBeer(Beer beer)
        {
            _BeerContext.Beers.Remove(beer);
            _BeerContext.SaveChanges();
        }

        public Beer EditBeer(Beer beer)
        {
            var existing_beer = _BeerContext.Beers.Find(beer.ID);
            if (existing_beer != null)
            {
                existing_beer.Name = beer.Name;
                existing_beer.ID_Brewery = beer.ID_Brewery;
                existing_beer.Alcohol_Content = beer.Alcohol_Content;
                existing_beer.Price = beer.Price;
                
                _BeerContext.Beers.Update(beer);
                _BeerContext.SaveChanges();
            }
            return beer;
        }

        public Beer GetBeer(Guid id)
        {
            return _BeerContext.Beers.SingleOrDefault(x => x.ID == id);
        }

        public List<Beer> GetBeers()
        {
            return _BeerContext.Beers.ToList();
        }
        public List<Beer> GetBeers(int Id_Brewery)
        {
            return _BeerContext.Beers.Where(x=>x.ID_Brewery== Id_Brewery).ToList();
        }
    }
}
