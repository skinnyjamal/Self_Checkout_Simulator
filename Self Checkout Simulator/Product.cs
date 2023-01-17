using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
 abstract class Product 
    {
        // Attributes
       protected string name;
        protected int barcode;
        protected int weightInGrams;
        public Product(int barcodeOfProduct,string nameOfProduct,int weightInGramsOfProduct)
        {
            name = nameOfProduct;
            barcode = barcodeOfProduct;
            weightInGrams=weightInGramsOfProduct;
        }

       
        // Operations
       

        public string GetName()
        {
            // TODO
            return name;
        }

        public int GetBarcode()
        {
            // TODO

            return barcode;
        }

        // TODO: Use the class diagram for details of other operations
        public int GetWeight()
        {
            return weightInGrams;
        }
        public void SetWeight(int weight)
        {
            weightInGrams = weight;
        }
        public abstract int CalculatePrice();
 
    }

    class PackagedProduct : Product
    {
        // Attributes
        private int price;

         

        // Constructor
        public PackagedProduct(int barcodeOfProduct, string nameOfProduct, int priceInPenceofProduct, int weightInGramsOfProduct): base (barcodeOfProduct,nameOfProduct,weightInGramsOfProduct)
        {
            price = priceInPenceofProduct;    
        }

        // Operations
        public override int CalculatePrice()
        {
            return price;
            //ToDO
        }
        // TO DO: Use the class diagram for details of other operations
    }
}