using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Client
    {

        public void ZamówPizzę(IBuilder builder)
        {
            Director director = new Director();
            director.Builder = builder;
            director.BuildCustomProduct();
            Product pizza = builder.GetProduct();

            Console.WriteLine("Twoja pizza została złożona:");
            Console.WriteLine(pizza.ListParts());
        }
    }
}
