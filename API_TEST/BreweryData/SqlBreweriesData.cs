using API_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_TEST.BreweryData
{
    public class SqlBreweriesData : Ibrewery
    {
        private BreweryContexDbContextt _breweryContext;
        public SqlBreweriesData(BreweryContexDbContextt breweryContext)
        {
            _breweryContext = breweryContext;
        }
        public Brewery AddBrewery(Brewery brewery)
        {
            brewery.Id=Guid.NewGuid();
            _breweryContext.Breweries.Add(brewery);
            _breweryContext.SaveChanges();
            return brewery;

        }

        public void DeleteBrewery(Brewery brewery)
        {
            _breweryContext.Breweries.Remove(brewery);
            _breweryContext.SaveChanges();

        }

        public Brewery EditBrewery(Brewery brewery)
        {
           var existing_brewery= _breweryContext.Breweries.Find(brewery.Id);
            if(existing_brewery!=null)
            {
                existing_brewery.Name = brewery.Name;
                _breweryContext.Breweries.Update(brewery);
                _breweryContext.SaveChanges();
            }
            return brewery;
        }

        public List<Brewery> GetBreweries()
        {
          return _breweryContext.Breweries.ToList();
        }

        public Brewery GetBrewery(Guid id)
        {
            return _breweryContext.Breweries.SingleOrDefault(x=> x.Id == id);
        }
      
    }
}
