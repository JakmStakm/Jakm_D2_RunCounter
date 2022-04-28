using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakmRunCounter
{
    public class d2ItemModel
    {
        public string name { get; set; }

        public string type { get; set; }

        public string catagory { get; set; }
         
        public string rarity { get; set; }

        public string image { get; set; }

        public int found { get; set; }

        public string date { get; set; }

        public string runes { get; set; }

        public string itemName
        {
            get
            {
                return name;
            }
        }

    }
}
