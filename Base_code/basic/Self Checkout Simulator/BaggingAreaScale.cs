using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class BaggingAreaScale
    {
        // Attributes
        private int weight;
        private int expectedWeight;
        private int allowedDifference;
        private SelfCheckout selfCheck;

        // Operations
        public int GetCurrentWeight()
        {
          
            return weight;
        }

        public bool IsWeightOk()
        {
            // int lowestAcceptableWeight = weight - allowedDifference;
            // int highestAcceptableWeight = weight + allowedDifference;
            //if (weight <lowestAcceptableWeight && weight >highestAcceptableWeight)
            //{
            //    return true;
            //}
            // else return false;
            return expectedWeight + allowedDifference == weight;
        }

        public int GetExpectedWeight()
        {
           
            return expectedWeight;
        }

        public void SetExpectedWeight(int expected)
        {
            expectedWeight = expected;
            //Product product = selfCheck.GetCurrentProduct();
           // product.GetWeight();
        }

        public void OverrideWeight(int difference)
        {
            expectedWeight = weight;
        }

        public void Reset()
        {
            weight = 0; 
           expectedWeight = 0;
            allowedDifference = 0;
        }

        public void LinkToSelfCheckout(SelfCheckout sc)
        {
            selfCheck= sc;
        }

        // NOTE: in reality the difference wouldn't be passed in here
        // the scale would detect the change and notify the self checkout
        public void WeightChangeDetected(int difference)
        {
            weight += difference;
            selfCheck.BaggingAreaWeightChanged(weight);
        }
    }
}