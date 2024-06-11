using newcursach;
    namespace newcursach
{
    partial class DBCAR
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.txtCarSpecifications = new System.Windows.Forms.TextBox();
            this.txtCarFeatures = new System.Windows.Forms.TextBox();
            this.txtCarCondition = new System.Windows.Forms.TextBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.txtBuyerContactDetails = new System.Windows.Forms.TextBox();
            this.txtBuyerPreferredBrand = new System.Windows.Forms.TextBox();
            this.txtBuyerPreferredSpecifications = new System.Windows.Forms.TextBox();
            this.txtBuyerPreferredCondition = new System.Windows.Forms.TextBox();
            this.txtBuyerBudget = new System.Windows.Forms.TextBox();
            this.btnAddBuyer = new System.Windows.Forms.Button();
            this.cmbBuyers = new System.Windows.Forms.ComboBox();
            this.btnFindCars = new System.Windows.Forms.Button();
            this.lstMatchingCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(12, 12);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 20);
            this.txtCarBrand.TabIndex = 0;
            this.txtCarBrand.Text = "Brand";
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(12, 38);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(100, 20);
            this.txtCarYear.TabIndex = 1;
            this.txtCarYear.Text = "Year";
            // 
            // txtCarSpecifications
            // 
            this.txtCarSpecifications.Location = new System.Drawing.Point(12, 64);
            this.txtCarSpecifications.Name = "txtCarSpecifications";
            this.txtCarSpecifications.Size = new System.Drawing.Size(100, 20);
            this.txtCarSpecifications.TabIndex = 2;
            this.txtCarSpecifications.Text = "Specifications";
            // 
            // txtCarFeatures
            // 
            this.txtCarFeatures.Location = new System.Drawing.Point(12, 90);
            this.txtCarFeatures.Name = "txtCarFeatures";
            this.txtCarFeatures.Size = new System.Drawing.Size(100, 20);
            this.txtCarFeatures.TabIndex = 3;
            this.txtCarFeatures.Text = "Features";
            // 
            // txtCarCondition
            // 
            this.txtCarCondition.Location = new System.Drawing.Point(12, 116);
            this.txtCarCondition.Name = "txtCarCondition";
            this.txtCarCondition.Size = new System.Drawing.Size(100, 20);
            this.txtCarCondition.TabIndex = 4;
            this.txtCarCondition.Text = "Condition";
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(12, 142);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCarPrice.TabIndex = 5;
            this.txtCarPrice.Text = "Price";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(12, 168);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(100, 23);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(150, 12);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerName.TabIndex = 7;
            this.txtBuyerName.Text = "Name";
            // 
            // txtBuyerContactDetails
            // 
            this.txtBuyerContactDetails.Location = new System.Drawing.Point(150, 38);
            this.txtBuyerContactDetails.Name = "txtBuyerContactDetails";
            this.txtBuyerContactDetails.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerContactDetails.TabIndex = 8;
            this.txtBuyerContactDetails.Text = "Contact Details";
            // 
            // txtBuyerPreferredBrand
            // 
            this.txtBuyerPreferredBrand.Location = new System.Drawing.Point(150, 64);
            this.txtBuyerPreferredBrand.Name = "txtBuyerPreferredBrand";
            this.txtBuyerPreferredBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerPreferredBrand.TabIndex = 9;
            this.txtBuyerPreferredBrand.Text = "Preferred Brand";
            // 
            // txtBuyerPreferredSpecifications
            // 
            this.txtBuyerPreferredSpecifications.Location = new System.Drawing.Point(150, 90);
            this.txtBuyerPreferredSpecifications.Name = "txtBuyerPreferredSpecifications";
            this.txtBuyerPreferredSpecifications.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerPreferredSpecifications.TabIndex = 10;
            this.txtBuyerPreferredSpecifications.Text = "Preferred Specifications";
            // 
            // txtBuyerPreferredCondition
            // 
            this.txtBuyerPreferredCondition.Location = new System.Drawing.Point(150, 116);
            this.txtBuyerPreferredCondition.Name = "txtBuyerPreferredCondition";
            this.txtBuyerPreferredCondition.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerPreferredCondition.TabIndex = 11;
            this.txtBuyerPreferredCondition.Text = "Preferred Condition";
            // 
            // txtBuyerBudget
            // 
            this.txtBuyerBudget.Location = new System.Drawing.Point(150, 142);
            this.txtBuyerBudget.Name = "txtBuyerBudget";
            this.txtBuyerBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerBudget.TabIndex = 12;
            this.txtBuyerBudget.Text = "Budget";
            // 
            // btnAddBuyer
            // 
            this.btnAddBuyer.Location = new System.Drawing.Point(150, 168);
            this.btnAddBuyer.Name = "btnAddBuyer";
            this.btnAddBuyer.Size = new System.Drawing.Size(100, 23);
            this.btnAddBuyer.TabIndex = 13;
            this.btnAddBuyer.Text = "Add Buyer";
            this.btnAddBuyer.UseVisualStyleBackColor = true;
            this.btnAddBuyer.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // cmbBuyers
            // 
            this.cmbBuyers.FormattingEnabled = true;
            this.cmbBuyers.Location = new System.Drawing.Point(12, 197);
            this.cmbBuyers.Name = "cmbBuyers";
            this.cmbBuyers.Size = new System.Drawing.Size(238, 21);
            this.cmbBuyers.TabIndex = 14;
            // 
            // btnFindCars
            // 
            this.btnFindCars.Location = new System.Drawing.Point(12, 224);
            this.btnFindCars.Name = "btnFindCars";
            this.btnFindCars.Size = new System.Drawing.Size(238, 23);
            this.btnFindCars.TabIndex = 15;
            this.btnFindCars.Text = "Find Cars";
            this.btnFindCars.UseVisualStyleBackColor = true;
            this.btnFindCars.Click += new System.EventHandler(this.btnFindCars_Click);
            // 
            // lstMatchingCars
            // 
            this.lstMatchingCars.FormattingEnabled = true;
            this.lstMatchingCars.Location = new System.Drawing.Point(12, 253);
            this.lstMatchingCars.Name = "lstMatchingCars";
            this.lstMatchingCars.Size = new System.Drawing.Size(238, 186);
            this.lstMatchingCars.TabIndex = 16;
         
            // 
            // DBCAR
            // 
            this.ClientSize = new System.Drawing.Size(255, 451);
            this.Controls.Add(this.lstMatchingCars);
            this.Controls.Add(this.btnFindCars);
            this.Controls.Add(this.cmbBuyers);
            this.Controls.Add(this.btnAddBuyer);
            this.Controls.Add(this.txtBuyerBudget);
            this.Controls.Add(this.txtBuyerPreferredCondition);
            this.Controls.Add(this.txtBuyerPreferredSpecifications);
            this.Controls.Add(this.txtBuyerPreferredBrand);
            this.Controls.Add(this.txtBuyerContactDetails);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtCarCondition);
            this.Controls.Add(this.txtCarFeatures);
            this.Controls.Add(this.txtCarSpecifications);
            this.Controls.Add(this.txtCarYear);
            this.Controls.Add(this.txtCarBrand);
            this.Name = "DBCAR";
            this.Text = "Car Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.TextBox txtCarSpecifications;
        private System.Windows.Forms.TextBox txtCarFeatures;
        private System.Windows.Forms.TextBox txtCarCondition;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.TextBox txtBuyerContactDetails;
        private System.Windows.Forms.TextBox txtBuyerPreferredBrand;
        private System.Windows.Forms.TextBox txtBuyerPreferredSpecifications;
        private System.Windows.Forms.TextBox txtBuyerPreferredCondition;
        private System.Windows.Forms.TextBox txtBuyerBudget;
        private System.Windows.Forms.Button btnAddBuyer;
        private System.Windows.Forms.ComboBox cmbBuyers;
        private System.Windows.Forms.Button btnFindCars;
        private System.Windows.Forms.ListBox lstMatchingCars;
    }
}
