using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.DodajSpodPizzy();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.DodajSpodPizzy();
            this._builder.DodajSer();
            this._builder.DodajWedliny();
            this._builder.DodajWarzywa();
            this._builder.DodajPrzyprawy();
        }

        public void BuildCustomProduct()
        {
            this._builder.DodajSpodPizzy();
            this._builder.DodajSer();
            this._builder.DodajWarzywa();
        }
    }
}
