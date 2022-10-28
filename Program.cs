using System;
using System.Collections.Generic;

namespace Prototyp
{

    public abstract class ProductPrototype : Supermarket//...
    {

        //...
        public string Name;
        
        public decimal Price { get; set; }

        public ProductPrototype(decimal price)
        {
            //...
            
            
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
            return _productList[key];
        }

    }


    class MainClass
    {
        public static void Main(string[] args)
        {

            //... supermarket
            Supermarket supermarket= new Supermarket();
            //... product; 
            ProductPrototype product;

            //...
            supermarket.AddProduct("Bread", new Bread(9.30m));
            supermarket.AddProduct("Butter", new Butter(5.30m));


            
            //...
            product = supermarket.GetClonedProduct("Butter");
            product = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Butter - {0} zł", product.Price));
            Console.WriteLine(String.Format("Bread - {0} zł", product.Price));
            //...

        }
    }

}