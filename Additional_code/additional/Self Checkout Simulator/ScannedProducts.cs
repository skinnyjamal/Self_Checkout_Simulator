using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class ScannedProducts
    {
        // Attributes
        private List<Product> products = new List<Product>();
        


        // Operations
        public List<Product> GetProducts()
        {
            return products;
        }

        public int CalculateWeight()
        {
            int total = 0;

           foreach ( Product item in products)
            { 
                total += item.GetWeight();
            }
            return total;
        }

        public int CalculatePrice()
        {
            int total = 0;

            foreach (Product item in products)
            {
                total += item.CalculatePrice();
            }
            return total;
        }


        public void Reset()
        {
            products.Clear();
        }

        public void Add(Product p)
        {
            products.Add(p);
        }

        public bool HasItems()
        {
            // TO DO
            if (products.Count != 0) return true;
            else return false;
        }
    }
}
