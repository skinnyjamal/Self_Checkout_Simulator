namespace Self_Checkout_Simulator
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserScansBarcodeProduct = new System.Windows.Forms.Button();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMembershipInfo = new System.Windows.Forms.ListBox();
            this.btnUserPutsProductInBaggingAreaCorrect = new System.Windows.Forms.Button();
            this.btnUserChooseToPay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnScanMembership = new System.Windows.Forms.Button();
            this.lblScreen = new System.Windows.Forms.Label();
            this.btnUserPutsProductInBaggingAreaIncorrect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaggingAreaExpectedWeight = new System.Windows.Forms.Label();
            this.lblBaggingAreaCurrentWeight = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRejectMembershipCard = new System.Windows.Forms.Button();
            this.btnOverrideCardValidity = new System.Windows.Forms.Button();
            this.btnAdminOverridesWeight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserScansBarcodeProduct
            // 
            this.btnUserScansBarcodeProduct.Location = new System.Drawing.Point(16, 217);
            this.btnUserScansBarcodeProduct.Margin = new System.Windows.Forms.Padding(8);
            this.btnUserScansBarcodeProduct.Name = "btnUserScansBarcodeProduct";
            this.btnUserScansBarcodeProduct.Size = new System.Drawing.Size(420, 209);
            this.btnUserScansBarcodeProduct.TabIndex = 0;
            this.btnUserScansBarcodeProduct.Text = "Scan a barcoded product";
            this.btnUserScansBarcodeProduct.UseVisualStyleBackColor = true;
            this.btnUserScansBarcodeProduct.Click += new System.EventHandler(this.UserScansProduct);
            // 
            // lbBasket
            // 
            this.lbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBasket.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.ItemHeight = 32;
            this.lbBasket.Location = new System.Drawing.Point(16, 45);
            this.lbBasket.Margin = new System.Windows.Forms.Padding(8);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.Size = new System.Drawing.Size(454, 324);
            this.lbBasket.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMembershipInfo);
            this.groupBox1.Controls.Add(this.lbBasket);
            this.groupBox1.Location = new System.Drawing.Point(1420, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(603, 733);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scanned Products";
            // 
            // lbMembershipInfo
            // 
            this.lbMembershipInfo.FormattingEnabled = true;
            this.lbMembershipInfo.ItemHeight = 31;
            this.lbMembershipInfo.Location = new System.Drawing.Point(16, 419);
            this.lbMembershipInfo.Name = "lbMembershipInfo";
            this.lbMembershipInfo.Size = new System.Drawing.Size(453, 283);
            this.lbMembershipInfo.TabIndex = 2;
            // 
            // btnUserPutsProductInBaggingAreaCorrect
            // 
            this.btnUserPutsProductInBaggingAreaCorrect.Location = new System.Drawing.Point(16, 442);
            this.btnUserPutsProductInBaggingAreaCorrect.Margin = new System.Windows.Forms.Padding(8);
            this.btnUserPutsProductInBaggingAreaCorrect.Name = "btnUserPutsProductInBaggingAreaCorrect";
            this.btnUserPutsProductInBaggingAreaCorrect.Size = new System.Drawing.Size(420, 99);
            this.btnUserPutsProductInBaggingAreaCorrect.TabIndex = 0;
            this.btnUserPutsProductInBaggingAreaCorrect.Text = "Put product in bagging area (correct weight)";
            this.btnUserPutsProductInBaggingAreaCorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaCorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaCorrect);
            // 
            // btnUserChooseToPay
            // 
            this.btnUserChooseToPay.Location = new System.Drawing.Point(16, 552);
            this.btnUserChooseToPay.Margin = new System.Windows.Forms.Padding(8);
            this.btnUserChooseToPay.Name = "btnUserChooseToPay";
            this.btnUserChooseToPay.Size = new System.Drawing.Size(856, 138);
            this.btnUserChooseToPay.TabIndex = 0;
            this.btnUserChooseToPay.Text = "Pay for products";
            this.btnUserChooseToPay.UseVisualStyleBackColor = true;
            this.btnUserChooseToPay.Click += new System.EventHandler(this.UserChoosesToPay);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnScanMembership);
            this.groupBox2.Controls.Add(this.lblScreen);
            this.groupBox2.Controls.Add(this.btnUserPutsProductInBaggingAreaIncorrect);
            this.groupBox2.Controls.Add(this.btnUserScansBarcodeProduct);
            this.groupBox2.Controls.Add(this.btnUserPutsProductInBaggingAreaCorrect);
            this.groupBox2.Controls.Add(this.btnUserChooseToPay);
            this.groupBox2.Location = new System.Drawing.Point(32, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(888, 705);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulate a Customer";
            // 
            // BtnScanMembership
            // 
            this.BtnScanMembership.Location = new System.Drawing.Point(452, 217);
            this.BtnScanMembership.Margin = new System.Windows.Forms.Padding(6);
            this.BtnScanMembership.Name = "BtnScanMembership";
            this.BtnScanMembership.Size = new System.Drawing.Size(420, 209);
            this.BtnScanMembership.TabIndex = 2;
            this.BtnScanMembership.Text = "Scan Membership Card";
            this.BtnScanMembership.UseVisualStyleBackColor = true;
            this.BtnScanMembership.Click += new System.EventHandler(this.BtnScanMembership_Click);
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreen.Location = new System.Drawing.Point(16, 45);
            this.lblScreen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(856, 145);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "[SCREEN SIMULATION]";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUserPutsProductInBaggingAreaIncorrect
            // 
            this.btnUserPutsProductInBaggingAreaIncorrect.Location = new System.Drawing.Point(452, 442);
            this.btnUserPutsProductInBaggingAreaIncorrect.Margin = new System.Windows.Forms.Padding(8);
            this.btnUserPutsProductInBaggingAreaIncorrect.Name = "btnUserPutsProductInBaggingAreaIncorrect";
            this.btnUserPutsProductInBaggingAreaIncorrect.Size = new System.Drawing.Size(420, 99);
            this.btnUserPutsProductInBaggingAreaIncorrect.TabIndex = 1;
            this.btnUserPutsProductInBaggingAreaIncorrect.Text = "Put product in bagging area (incorrect weight)";
            this.btnUserPutsProductInBaggingAreaIncorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaIncorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaIncorrect);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(936, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox3.Size = new System.Drawing.Size(452, 366);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Location = new System.Drawing.Point(16, 269);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox6.Size = new System.Drawing.Size(420, 83);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 39);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(214, 32);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "[TOTAL PRICE]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblBaggingAreaExpectedWeight);
            this.groupBox4.Controls.Add(this.lblBaggingAreaCurrentWeight);
            this.groupBox4.Location = new System.Drawing.Point(16, 45);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox4.Size = new System.Drawing.Size(420, 209);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bagging Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected Weight";
            // 
            // lblBaggingAreaExpectedWeight
            // 
            this.lblBaggingAreaExpectedWeight.AutoSize = true;
            this.lblBaggingAreaExpectedWeight.Location = new System.Drawing.Point(16, 70);
            this.lblBaggingAreaExpectedWeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBaggingAreaExpectedWeight.Name = "lblBaggingAreaExpectedWeight";
            this.lblBaggingAreaExpectedWeight.Size = new System.Drawing.Size(301, 32);
            this.lblBaggingAreaExpectedWeight.TabIndex = 0;
            this.lblBaggingAreaExpectedWeight.Text = "[EXPECTED WEIGHT]";
            // 
            // lblBaggingAreaCurrentWeight
            // 
            this.lblBaggingAreaCurrentWeight.AutoSize = true;
            this.lblBaggingAreaCurrentWeight.Location = new System.Drawing.Point(16, 145);
            this.lblBaggingAreaCurrentWeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBaggingAreaCurrentWeight.Name = "lblBaggingAreaCurrentWeight";
            this.lblBaggingAreaCurrentWeight.Size = new System.Drawing.Size(285, 32);
            this.lblBaggingAreaCurrentWeight.TabIndex = 0;
            this.lblBaggingAreaCurrentWeight.Text = "[CURRENT WEIGHT]";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRejectMembershipCard);
            this.groupBox5.Controls.Add(this.btnOverrideCardValidity);
            this.groupBox5.Controls.Add(this.btnAdminOverridesWeight);
            this.groupBox5.Location = new System.Drawing.Point(936, 411);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox5.Size = new System.Drawing.Size(452, 324);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Admin Controls";
            // 
            // btnRejectMembershipCard
            // 
            this.btnRejectMembershipCard.Location = new System.Drawing.Point(231, 205);
            this.btnRejectMembershipCard.Name = "btnRejectMembershipCard";
            this.btnRejectMembershipCard.Size = new System.Drawing.Size(200, 116);
            this.btnRejectMembershipCard.TabIndex = 4;
            this.btnRejectMembershipCard.Text = "Reject Membership Card";
            this.btnRejectMembershipCard.UseVisualStyleBackColor = true;
            this.btnRejectMembershipCard.Click += new System.EventHandler(this.btnRejectMembershipCard_Click);
            // 
            // btnOverrideCardValidity
            // 
            this.btnOverrideCardValidity.Location = new System.Drawing.Point(16, 204);
            this.btnOverrideCardValidity.Name = "btnOverrideCardValidity";
            this.btnOverrideCardValidity.Size = new System.Drawing.Size(200, 116);
            this.btnOverrideCardValidity.TabIndex = 3;
            this.btnOverrideCardValidity.Text = "Override Card Validity";
            this.btnOverrideCardValidity.UseVisualStyleBackColor = true;
            this.btnOverrideCardValidity.Click += new System.EventHandler(this.btnOverrideCardValidity_Click);
            // 
            // btnAdminOverridesWeight
            // 
            this.btnAdminOverridesWeight.Location = new System.Drawing.Point(16, 45);
            this.btnAdminOverridesWeight.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdminOverridesWeight.Name = "btnAdminOverridesWeight";
            this.btnAdminOverridesWeight.Size = new System.Drawing.Size(420, 141);
            this.btnAdminOverridesWeight.TabIndex = 2;
            this.btnAdminOverridesWeight.Text = "Override weight";
            this.btnAdminOverridesWeight.UseVisualStyleBackColor = true;
            this.btnAdminOverridesWeight.Click += new System.EventHandler(this.AdminOverridesWeight);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 761);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self Checkout Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserScansBarcodeProduct;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaCorrect;
        private System.Windows.Forms.Button btnUserChooseToPay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBaggingAreaExpectedWeight;
        private System.Windows.Forms.Label lblBaggingAreaCurrentWeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaIncorrect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAdminOverridesWeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button BtnScanMembership;
        private System.Windows.Forms.ListBox lbMembershipInfo;
        private System.Windows.Forms.Button btnOverrideCardValidity;
        private System.Windows.Forms.Button btnRejectMembershipCard;
    }
}

