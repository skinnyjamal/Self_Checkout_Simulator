using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    public partial class UserInterface : Form
    {
        // Attributes
        SelfCheckout selfCheckout;
        BarcodeScanner barcodeScanner;
        BaggingAreaScale baggingAreaScale;
        ScannedProducts scannedProducts;

        // Constructor
        public UserInterface()
        {
            InitializeComponent();

            // NOTE: This is where we set up all the objects,
            // and create the various relationships between them.

            baggingAreaScale = new BaggingAreaScale();
            scannedProducts = new ScannedProducts();
            barcodeScanner = new BarcodeScanner();
            selfCheckout = new SelfCheckout(baggingAreaScale, scannedProducts);
            barcodeScanner.LinkToSelfCheckout(selfCheckout);
            baggingAreaScale.LinkToSelfCheckout(selfCheckout);
            btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
            btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
            btnUserChooseToPay.Enabled = false;
            btnAdminOverridesWeight.Enabled = false;
            UpdateDisplay();
        }

        // Operations
        private void UserScansProduct(object sender, EventArgs e)
        {

            //ToDo
             btnUserScansBarcodeProduct.Enabled = false;
             btnUserChooseToPay.Enabled = false;
             //barcodeScanner.BarcodeDetected();
             //scannedProducts.Add(selfCheckout.GetCurrentProduct());
             //lbBasket.Items.Add(Convert.ToString(selfCheckout.GetCurrentProduct().CalculatePrice()) + " " + selfCheckout.GetCurrentProduct().GetName());
            
            barcodeScanner.BarcodeDetected();
            UpdateDisplay();
            btnUserPutsProductInBaggingAreaCorrect.Enabled = true;
            btnUserPutsProductInBaggingAreaIncorrect.Enabled = true;
        }

        private void UserPutsProductInBaggingAreaCorrect(object sender, EventArgs e)
        {
            // NOTE: we use the correct item weight here

            // TO DO
            btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
            btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
            baggingAreaScale.WeightChangeDetected(selfCheckout.GetCurrentProduct().GetWeight());
           UpdateDisplay();
            btnUserChooseToPay.Enabled = true;
            btnUserScansBarcodeProduct.Enabled = true;
        }

        private void UserPutsProductInBaggingAreaIncorrect(object sender, EventArgs e)
        {
            // NOTE: We are pretending to put down an item with the wrong weight.
            // To simulate this we'll use a random number, here's one for you to use.

            int weight = new Random().Next(20, 100);

            // TODO

            btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
            btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
            baggingAreaScale.WeightChangeDetected(weight);
            UpdateDisplay();
            btnUserChooseToPay.Enabled = false;
            btnUserScansBarcodeProduct.Enabled = false;
            btnAdminOverridesWeight.Enabled = true;
        }

        private void AdminOverridesWeight(object sender, EventArgs e)
        {

            // TO DO
            selfCheckout.adminOverrideWeight();
            UpdateDisplay();
            btnAdminOverridesWeight.Enabled = false;
            btnUserScansBarcodeProduct.Enabled = true;
            btnUserChooseToPay.Enabled = true;
        }

        private void UserChoosesToPay(object sender, EventArgs e)
        {
            // TO DO
            selfCheckout.UserPaid();
            lbBasket.Items.Clear();
            UpdateDisplay();
            btnUserChooseToPay.Enabled = false;
            btnUserScansBarcodeProduct.Enabled = true;
        }

        void UpdateDisplay()
        {
            // TODO: use all the information we have to update the UI:
            //     - set whether buttons are enabled
            //     - set label texts
            //     - refresh the scanned products list box
           lblBaggingAreaExpectedWeight.Text= Convert.ToString (baggingAreaScale.GetExpectedWeight().ToString("n2"));
            lblBaggingAreaCurrentWeight.Text = Convert.ToString(baggingAreaScale.GetCurrentWeight().ToString("n2"));
            lblTotalPrice.Text = (scannedProducts.CalculatePrice()*0.01f).ToString("c2");
            lbBasket.Items.Clear();
            lblScreen.Text = selfCheckout.GetPromptForUser();
            foreach (var product in scannedProducts.GetProducts())

            {

                var price = (product.CalculatePrice() * 0.01f).ToString("c2");

                lbBasket.Items.Add(price + " " + product.GetName());

            }
        }
        


}
}