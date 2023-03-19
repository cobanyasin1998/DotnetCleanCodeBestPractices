using System;

namespace NamingConventions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        ProductManager productManager = new ProductManager();
    }

    class ProductManager//PascalCase
    {
        public ProductManager()//PascalCase
        {

        }
    }


    
}
