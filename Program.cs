using System;
using System.Collections.Generic;

namespace Prototyp
{

    public abstract class ProductPrototype//...
    {

        //...
        
        
        public decimal Price { get; set; }

        public ProductPrototype(decimal price)
        {
            //...
            Price=price;
            
        }



        public ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }

    }


    public class Bread : ProductPrototype
    {

        public Bread(decimal price) : base(price) { }

    }

    //...
    public class Butter : ProductPrototype
    {

        public Butter(decimal price) : base(price) { }

    }


    public class Supermarket
    {

        private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

        public void AddProduct(string key, ProductPrototype productPrototype)
        {
            _productList.Add(key, productPrototype);
        }

        public ProductPrototype GetClonedProduct(string key)
        {
            //... zwraca klon

            return _productList[key].Clone();
        }

    }


    class MainClass
    {
        public static void Main(string[] args)
        {

            //... supermarket
            Supermarket supermarket= new Supermarket();
            //... product; 


            //...



            //...
            supermarket.AddProduct("Butter", new Butter(5.30m));
            supermarket.AddProduct("Bread", new Bread(9.50m));



            ProductPrototype product = supermarket.GetClonedProduct("Butter");
            Console.WriteLine(String.Format("Butter - {0} zł", product.Price));
            


            ProductPrototype product2 = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Bread - {0} zł", product2.Price));
            product2.Price = 2m;
            Console.WriteLine(String.Format("Bread - {0} zł", product2.Price));


            ProductPrototype product3 = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Bread - {0} zł", product3.Price));
            //...
            

        }
    }

}