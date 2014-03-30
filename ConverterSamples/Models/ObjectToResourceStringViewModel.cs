using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterSamples.Models
{
    public class ObjectToResourceStringViewModel
    {
        public IEnumerable<Item> Items { get; private set; }

        public ObjectToResourceStringViewModel()
        {
            Items = new List<Item>
            {
                new Item { Kind = "kind1"},
                new Item { Kind = "kind2"},
                new Item { Kind = "kind3"}
            };
        }
    }
}
