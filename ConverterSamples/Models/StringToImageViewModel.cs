using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConverterSamples.Models
{
    public class StringToImageViewModel
    {
        public IEnumerable<Item> SocialItems { get; private set; }

        public StringToImageViewModel()
        {
            SocialItems = new string[]
            {
                "facebook",
                "googleplus",
                "linkedin",
                "twitter",
                "microsoft",
                "foursquare"
            }.Select(s => new Item { Kind = s }).ToList();
        }
    }
}
