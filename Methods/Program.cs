using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //class instance
            Product product1 =  new Product();
            product1.Id = 1;
            product1.Name = "laptop";
            product1.Price = 13000;
            product1.Description = "Monster Abra";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "TV";
            product2.Price = 15000;
            product2.Description = "Samsung 12";

            //Product Array
            Product[] products = new Product[] { product1, product2 };

            //type safe - tip güvenli 
            foreach (Product product in products)
            {
                Console.WriteLine("product: " +  product.Name);   
            }


            Console.WriteLine("-----------------metotlar-------");

            //Instance - bir class örneği oluşturulur.
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            //tekrar tekrar kullanmayı sağlar.

            basketManager.Add2("Phone", "Apple", 15000,10);
            basketManager.Add2("watch", "Apple", 15000,50);
            basketManager.Add2("mouse", "Apple", 15000,15);





        }




    }
}
