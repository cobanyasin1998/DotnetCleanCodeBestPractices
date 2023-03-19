using System;

namespace NamingConventions
{
    class Program
    {
        /*
         Detaylı Bilgi ->
         https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        ProductManager productManager = new ProductManager();
    }

    /*Class'lar default olarak internal erişim belirteci alır*/
    class ProductManager//PascalCase
    {
        /*class'in içindeki propertyler default olarak private erişim belirteci alır*/
        int enBuyukSayi;//camelCase
        /*
         Propertyleri public yaparsak encapsulation yönünden hatalıdır
         Public yaparsak property isimleri PascalCase olur
         */
        public int Sayi { get; set; }//PascalCase
        public ProductManager()//PascalCase
        {

        }

        public void GetAllByCategoryId(int id /*camelCase*/)//PascalCase
        {
            int enKucukSayi;//camelCase
        }
    }
}
