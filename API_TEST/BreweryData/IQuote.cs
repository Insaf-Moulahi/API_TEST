using API_TEST.Model;
using System;
using System.Collections.Generic;

namespace API_TEST.BreweryData
{
    public interface IQuote
    {
        List<Quote> GetQuotes();
        Quote GetQuote(Guid id);
        Quote AddQuote(Quote quote);

        Quote EditQuote(Quote quote);

        void DeleteQuote(Quote quote);
    }
}
