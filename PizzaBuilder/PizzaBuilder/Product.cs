using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string partsList = "Składniki pizzy:";
            foreach (var part in this._parts)
            {
                partsList += " " + part + ",";
            }
            return partsList;
        }

    }
    
}
