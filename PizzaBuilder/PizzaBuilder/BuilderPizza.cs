using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class BuilderPizza : IBuilder
    {
        private Product _product = new Product();

        public BuilderPizza()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }


        public void DodajSpodPizzy()
        {
            this._product.Add("Ciasto");
        }

        public void DodajSer()
        {
            this._product.Add("Mozarella");
        }

        public void DodajWedliny()
        {
            this._product.Add("Szynka");
            this._product.Add("Kebab");
        }

        public void DodajWarzywa()
        {
            this._product.Add("Kukurydza");
            this._product.Add("Pieczarki");
        }

        public void DodajPrzyprawy()
        {
            this._product.Add("Oregano");
            this._product.Add("Bazylia");
        }

      
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
