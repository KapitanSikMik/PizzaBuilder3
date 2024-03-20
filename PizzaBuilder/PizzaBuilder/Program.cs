using PizzaBuilder;

internal class Program
{
        static void Main(string[] args)
        {
            IBuilder builder = new BuilderPizza();
            Client klient = new Client();           
            klient.ZamówPizzę(builder);
        }
}
