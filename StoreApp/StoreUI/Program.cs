using System;
using StoreBL;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int input=0;
            Console.WriteLine("***********WELCOME  TO STORE APP**********");
            Console.WriteLine( "What do you want to do \n Press <1> to get all products \n Press <2> to order"  );
            input=Int32.Parse(Console.ReadLine());
            switch (input)
            {
               case 1:
                GetProducts();
                break;
              default:
                GetProducts();
                break;
            }
        }
        public static void GetProducts(){
            ProductValidation productValidation = new ProductValidation();
            var products=productValidation.CheckProducts();
            foreach (var product in products)
            {
                  Console.WriteLine(product.Name);
            }          
        }
    }
}
