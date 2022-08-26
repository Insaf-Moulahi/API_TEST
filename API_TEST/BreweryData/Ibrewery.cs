using API_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.BreweryData
{
    public interface Ibrewery
    {
        List<Brewery> GetBreweries();
        Brewery GetBrewery(Guid id);
        Brewery AddBrewery(Brewery brewery);

        Brewery EditBrewery(Brewery brewery);

        void DeleteBrewery(Brewery brewery);
    }
}
