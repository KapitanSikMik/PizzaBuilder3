using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public interface IBuilder
    {
        void DodajSpodPizzy();

        void DodajSer();

        void DodajWedliny();

        void DodajWarzywa();

        void DodajPrzyprawy();

        Product GetProduct();
    }
}
