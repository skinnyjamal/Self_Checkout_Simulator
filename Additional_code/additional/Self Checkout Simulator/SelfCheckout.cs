using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class SelfCheckout
    {
        // Attributes
        
        private Product currentProduct;
        private BaggingAreaScale Bagging;
        private ScannedProducts scanned;
        private MembershipCard memberCard;
        private Membership currentMembership;      
            // Constructor
        public SelfCheckout(BaggingAreaScale baggingArea, ScannedProducts scannedProducts, MembershipCard membershipCard)
        {
           
            scanned = scannedProducts;
            Bagging = baggingArea;
            memberCard = membershipCard;
        }

        // Operations

        public void BarcodeWasScanned(int barcode)
        {
            // TO DO
            Product P= ProductsDAO.SearchUsingBarcode(barcode);
            currentProduct = P;
            scanned.Add(currentProduct);
            //scanned.CalculateWeight();
            Bagging.SetExpectedWeight(scanned.CalculateWeight());
            
        }

        public void BaggingAreaWeightChanged(int weight)
        {
         

        }

        public void UserPaid()
        {
            Bagging.Reset();
            scanned.Reset();
        }

        public string GetPromptForUser()
        {
            if (Bagging.GetExpectedWeight() == 0)
            {
                return "Scan An Item";
            }
            else if (Bagging.GetExpectedWeight() != 0 && Bagging.GetCurrentWeight() == 0)
            {
                return "Place The Item In The Bagging Area";
            }
            else if (Bagging.GetExpectedWeight() == Bagging.GetCurrentWeight())
            {
                return "Scan An Item, Or Membership And Pay";
            }
            else if (Bagging.GetExpectedWeight() != Bagging.GetCurrentWeight())
            {
                return "Please Wait, Assistance Is On The Way";
            }

            return "ERROR: UNKNOWN STATE";
        }

        public Product GetCurrentProduct()
        {
            return currentProduct;
        }
        public void adminOverrideWeight()
        {
           Bagging.OverrideWeight (currentProduct.GetWeight());
        }
        public string MembershipCardWasScanned()
        {
            currentMembership=memberCard.GetRandomMemberID();
           
            if (currentMembership.IsIDValid()== true)
            {
                return "Valid";
            }
            else
            {
                return "INVALID ";
            }
            
        }
        public Membership MembershipLink()
        {
            return currentMembership;
        }
    }
}