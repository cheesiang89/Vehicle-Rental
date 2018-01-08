namespace RentalCA
{
    partial class EnquireStatusUI
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCarPlateNumber = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblESN = new System.Windows.Forms.Label();
            this.txtESN = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCarPlateNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblVehicleReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(407, 325);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(257, 26);
            this.txtColor.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(204, 248);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // lblCarPlateNumber
            // 
            this.lblCarPlateNumber.AutoSize = true;
            this.lblCarPlateNumber.Location = new System.Drawing.Point(204, 170);
            this.lblCarPlateNumber.Name = "lblCarPlateNumber";
            this.lblCarPlateNumber.Size = new System.Drawing.Size(138, 20);
            this.lblCarPlateNumber.TabIndex = 3;
            this.lblCarPlateNumber.Text = "Car Plate Number:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(204, 325);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // lblESN
            // 
            this.lblESN.AutoSize = true;
            this.lblESN.Location = new System.Drawing.Point(204, 404);
            this.lblESN.Name = "lblESN";
            this.lblESN.Size = new System.Drawing.Size(167, 20);
            this.lblESN.TabIndex = 5;
            this.lblESN.Text = "Engine Serial Number:";
            // 
            // txtESN
            // 
            this.txtESN.Location = new System.Drawing.Point(407, 404);
            this.txtESN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtESN.Name = "txtESN";
            this.txtESN.ReadOnly = true;
            this.txtESN.Size = new System.Drawing.Size(257, 26);
            this.txtESN.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(204, 481);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // txtCarPlateNumber
            // 
            this.txtCarPlateNumber.Location = new System.Drawing.Point(407, 170);
            this.txtCarPlateNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarPlateNumber.Name = "txtCarPlateNumber";
            this.txtCarPlateNumber.Size = new System.Drawing.Size(257, 26);
            this.txtCarPlateNumber.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(407, 241);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(257, 26);
            this.txtModel.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(407, 475);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(257, 26);
            this.txtStatus.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(563, 554);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(208, 554);
            this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(101, 41);
            this.btnRetrieve.TabIndex = 6;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblVehicleReturn
            // 
            this.lblVehicleReturn.AutoSize = true;
            this.lblVehicleReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleReturn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleReturn.Location = new System.Drawing.Point(327, 65);
            this.lblVehicleReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleReturn.Name = "lblVehicleReturn";
            this.lblVehicleReturn.Size = new System.Drawing.Size(282, 40);
            this.lblVehicleReturn.TabIndex = 8;
            this.lblVehicleReturn.Text = "Vehicle Enquiry";
            // 
            // EnquireStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 649);
            this.Controls.Add(this.lblVehicleReturn);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCarPlateNumber);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtESN);
            this.Controls.Add(this.lblESN);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCarPlateNumber);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtColor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnquireStatusUI";
            this.Text = "frmEnquire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCarPlateNumber;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblESN;
        private System.Windows.Forms.TextBox txtESN;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCarPlateNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblVehicleReturn;
    }
}