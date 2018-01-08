namespace RentalCA
{
    partial class CustomerRentalDetailForm
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
            this.gboCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRetrieveCustomer = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.gboVehicleDetails = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.gboRentalDetails = new System.Windows.Forms.GroupBox();
            this.lblRentalDays = new System.Windows.Forms.Label();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.lblRetalRate = new System.Windows.Forms.Label();
            this.lblVehicleRentalForm = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.gboCustomerDetails.SuspendLayout();
            this.gboVehicleDetails.SuspendLayout();
            this.gboRentalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCustomerDetails
            // 
            this.gboCustomerDetails.Controls.Add(this.lblCustomerID);
            this.gboCustomerDetails.Controls.Add(this.txtEmail);
            this.gboCustomerDetails.Controls.Add(this.lblEmail);
            this.gboCustomerDetails.Controls.Add(this.txtTelephone);
            this.gboCustomerDetails.Controls.Add(this.txtName);
            this.gboCustomerDetails.Controls.Add(this.lblTelephone);
            this.gboCustomerDetails.Controls.Add(this.lblName);
            this.gboCustomerDetails.Controls.Add(this.btnRetrieveCustomer);
            this.gboCustomerDetails.Controls.Add(this.txtCustomerID);
            this.gboCustomerDetails.Location = new System.Drawing.Point(111, 231);
            this.gboCustomerDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboCustomerDetails.Name = "gboCustomerDetails";
            this.gboCustomerDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboCustomerDetails.Size = new System.Drawing.Size(674, 211);
            this.gboCustomerDetails.TabIndex = 6;
            this.gboCustomerDetails.TabStop = false;
            this.gboCustomerDetails.Text = "Customer Details";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(202, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(268, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(202, 120);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(268, 26);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(268, 26);
            this.txtName.TabIndex = 4;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(67, 123);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(92, 20);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Telephone: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // btnRetrieveCustomer
            // 
            this.btnRetrieveCustomer.Location = new System.Drawing.Point(381, 33);
            this.btnRetrieveCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetrieveCustomer.Name = "btnRetrieveCustomer";
            this.btnRetrieveCustomer.Size = new System.Drawing.Size(89, 26);
            this.btnRetrieveCustomer.TabIndex = 1;
            this.btnRetrieveCustomer.Text = "Retrieve";
            this.btnRetrieveCustomer.UseVisualStyleBackColor = true;
            this.btnRetrieveCustomer.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(202, 33);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(173, 26);
            this.txtCustomerID.TabIndex = 0;
            // 
            // gboVehicleDetails
            // 
            this.gboVehicleDetails.Controls.Add(this.lbl3);
            this.gboVehicleDetails.Controls.Add(this.lbl2);
            this.gboVehicleDetails.Controls.Add(this.lblColour);
            this.gboVehicleDetails.Controls.Add(this.lblModel);
            this.gboVehicleDetails.Location = new System.Drawing.Point(111, 102);
            this.gboVehicleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboVehicleDetails.Name = "gboVehicleDetails";
            this.gboVehicleDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboVehicleDetails.Size = new System.Drawing.Size(674, 116);
            this.gboVehicleDetails.TabIndex = 5;
            this.gboVehicleDetails.TabStop = false;
            this.gboVehicleDetails.Text = "Vehicle Details";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(309, 74);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(33, 20);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "lbl3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(36, 74);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(33, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "lbl2";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(305, 38);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(59, 20);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "Colour:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(32, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(60, 20);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 595);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(111, 595);
            this.btnRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(101, 41);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // gboRentalDetails
            // 
            this.gboRentalDetails.Controls.Add(this.lblRentalDays);
            this.gboRentalDetails.Controls.Add(this.txtRentalDays);
            this.gboRentalDetails.Controls.Add(this.lblRetalRate);
            this.gboRentalDetails.Location = new System.Drawing.Point(111, 446);
            this.gboRentalDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboRentalDetails.Name = "gboRentalDetails";
            this.gboRentalDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboRentalDetails.Size = new System.Drawing.Size(674, 144);
            this.gboRentalDetails.TabIndex = 7;
            this.gboRentalDetails.TabStop = false;
            this.gboRentalDetails.Text = "Rental Details";
            // 
            // lblRentalDays
            // 
            this.lblRentalDays.AutoSize = true;
            this.lblRentalDays.Location = new System.Drawing.Point(35, 99);
            this.lblRentalDays.Name = "lblRentalDays";
            this.lblRentalDays.Size = new System.Drawing.Size(100, 20);
            this.lblRentalDays.TabIndex = 4;
            this.lblRentalDays.Text = "Rental Days:";
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(136, 94);
            this.txtRentalDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(100, 26);
            this.txtRentalDays.TabIndex = 3;
            // 
            // lblRetalRate
            // 
            this.lblRetalRate.AutoSize = true;
            this.lblRetalRate.Location = new System.Drawing.Point(35, 46);
            this.lblRetalRate.Name = "lblRetalRate";
            this.lblRetalRate.Size = new System.Drawing.Size(99, 20);
            this.lblRetalRate.TabIndex = 2;
            this.lblRetalRate.Text = "Rental Rate:";
            // 
            // lblVehicleRentalForm
            // 
            this.lblVehicleRentalForm.AutoSize = true;
            this.lblVehicleRentalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRentalForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleRentalForm.Location = new System.Drawing.Point(306, 26);
            this.lblVehicleRentalForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleRentalForm.Name = "lblVehicleRentalForm";
            this.lblVehicleRentalForm.Size = new System.Drawing.Size(362, 40);
            this.lblVehicleRentalForm.TabIndex = 16;
            this.lblVehicleRentalForm.Text = "Vehicle Rental Form";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(67, 33);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(103, 20);
            this.lblCustomerID.TabIndex = 8;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // CustomerRentalDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 671);
            this.Controls.Add(this.lblVehicleRentalForm);
            this.Controls.Add(this.gboCustomerDetails);
            this.Controls.Add(this.gboVehicleDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gboRentalDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerRentalDetailForm";
            this.Text = "Customer Rental Detail Form";
            this.gboCustomerDetails.ResumeLayout(false);
            this.gboCustomerDetails.PerformLayout();
            this.gboVehicleDetails.ResumeLayout(false);
            this.gboVehicleDetails.PerformLayout();
            this.gboRentalDetails.ResumeLayout(false);
            this.gboRentalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCustomerDetails;
        private System.Windows.Forms.Button btnRetrieveCustomer;
        private System.Windows.Forms.GroupBox gboVehicleDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.GroupBox gboRentalDetails;
        private System.Windows.Forms.Label lblVehicleRentalForm;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRetalRate;
        private System.Windows.Forms.Label lblRentalDays;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
    }
}