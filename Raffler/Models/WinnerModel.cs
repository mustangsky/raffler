using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffler.Models
{
    public class WinnerModel
    {
        public WinnerModel(string name, string basket, int entries)
        {
            Name = name;
            Basket = basket;
            Entries = entries;
        }
        public string Name { get; set; }
        public string Basket { get; set; }
        public int Entries { get; set; }
    }
}
