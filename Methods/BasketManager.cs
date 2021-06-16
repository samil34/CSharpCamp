using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //Sepete ürün ekleme işlemi 
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
          
        }

        //Class yapısını anlamak için yapılan Add2 methodu
        public void Add2(string productName, string description, int price, int amount)
        {
            Console.WriteLine("Sepete eklendi : " + productName);
        }
    }
}
