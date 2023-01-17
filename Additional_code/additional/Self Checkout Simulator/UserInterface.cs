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
        MembershipCard membershipCard;
        Membership membership;

        // Constructor
        public UserInterface()
        {
            InitializeComponent();

            // NOTE: This is where we set up all the objects,
            // and create the various relationships between them.

            baggingAreaScale = new BaggingAreaScale();
            scannedProducts = new ScannedProducts();
            barcodeScanner = new BarcodeScanner();
            membershipCard = new MembershipCard();
            selfCheckout = new SelfCheckout(baggingAreaScale, scannedProducts,membershipCard);
            barcodeScanner.LinkToSelfCheckout(selfCheckout);
            baggingAreaScale.LinkToSelfCheckout(selfCheckout);
            btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
            btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
            btnUserChooseToPay.Enabled = false;
            btnAdminOverridesWeight.Enabled = false;
            BtnScanMembership.Enabled = false;
            btnOverrideCardValidity.Enabled = false;
            btnRejectMembershipCard.Enabled = false;
            UpdateDisplay();
        }

        // Operations
        private void UserScansProduct(object sender, EventArgs e)
        {

            //ToDo
             btnUserScansBarcodeProduct.Enabled = false;
             btnUserChooseToPay.Enabled = false;
            BtnScanMembership.Enabled = false;
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
            BtnScanMembership.Enabled = true;
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
            BtnScanMembership.Enabled = true;
        }

        private void UserChoosesToPay(object sender, EventArgs e)
        {
            // TO DO
            selfCheckout.UserPaid();
            lbBasket.Items.Clear();
            lbMembershipInfo.Items.Clear();
            UpdateDisplay();
            btnUserChooseToPay.Enabled = false;
            btnUserScansBarcodeProduct.Enabled = true;
            BtnScanMembership.Enabled = false;
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

        private void BtnScanMembership_Click(object sender, EventArgs e)
        {
            BtnScanMembership.Enabled = false;
            btnUserScansBarcodeProduct.Enabled = false;
          string isvalid=  selfCheckout.MembershipCardWasScanned();
            if (isvalid == "Valid")
            {
                membership = selfCheckout.MembershipLink();
                lbMembershipInfo.Items.Add("Name : " + membership.GetMemberName());
                lbMembershipInfo.Items.Add("Member ID : "+ membership.GetMemberID());
                lbMembershipInfo.Items.Add("Member Phone : " + membership.GetMemberPhone());
                lbMembershipInfo.Items.Add("Member Address : " + membership.GetMemberAddress());
                lbMembershipInfo.Items.Add("Current Member Points : " + membership.GetPoints());
                membership.AddPoints(10);
                lbMembershipInfo.Items.Add("Points After Purchase : " + membership.GetPoints());
                lblScreen.Text = "Points Added , Please Proceed To Payment";
            }
           
            else
            {
                btnRejectMembershipCard.Enabled = true;
                btnOverrideCardValidity.Enabled = true;
                lblScreen.Text = "Invalid Card, Please Wait For Assistance.";

            }

        }

        private void btnOverrideCardValidity_Click(object sender, EventArgs e)
        {
            btnUserChooseToPay.Enabled = true;
            btnUserScansBarcodeProduct.Enabled = false;
            BtnScanMembership.Enabled = false;
            btnOverrideCardValidity.Enabled = false;
            btnRejectMembershipCard.Enabled = false;
            membership.AddPoints(10);
            lblScreen.Text = "Points Added , Please Proceed To Payment";
        }

        private void btnRejectMembershipCard_Click(object sender, EventArgs e)
        {
            btnUserChooseToPay.Enabled = true;
            btnUserScansBarcodeProduct.Enabled = false;
            BtnScanMembership.Enabled = false;
            btnOverrideCardValidity.Enabled = false;
            btnRejectMembershipCard.Enabled = false;
            lblScreen.Text = "Membership Card Rejected, Please Proceed To Payment";
        }
    }
}