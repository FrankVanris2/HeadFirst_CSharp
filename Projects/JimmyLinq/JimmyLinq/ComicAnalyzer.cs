using System;
using System.Collections.Generic;
using System.Text;

namespace JimmyLinq
{
    static class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comics)
        {
            if (Comic.Prices[comics.Issue] < 100)
            {
                return PriceRange.Cheap;
            }

            return PriceRange.Expensive;
        }

        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            var groups = from comic in comics
                         group comic by CalculatePriceRange(comic) into priceGroup
                         orderby priceGroup.Key
                         select priceGroup;
            return groups;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
        {
            var joined =
                from comic in comics
                orderby comic.Issue
                join review in reviews on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";
            return joined;
        }
    }
}
