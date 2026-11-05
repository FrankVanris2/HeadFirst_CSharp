using System;
using System.Collections.Generic;
using System.Text;

namespace JimmyLinq
{
    public static class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comics, IReadOnlyDictionary<int, decimal> prices) => 
            (prices[comics.Issue] < 100) ? PriceRange.Cheap : PriceRange.Expensive;


        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices) => 
            comics.OrderBy(comic => prices[comic.Issue]).GroupBy(comic => CalculatePriceRange(comic, prices));


        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews) => 
            comics.OrderBy(comic => comic.Issue).
            Join(reviews, comic => comic.Issue, review => review.Issue, (comic, review) => $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}");

    }
}
