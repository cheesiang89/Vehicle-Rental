namespace RentalCA
{
    partial class ReturnVehicleUI
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
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblVehicleReturn = new System.Windows.Forms.Label();
            this.lblCarPlateNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCarPlateNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(341, 295);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(165, 17);
            this.lblAlert.TabIndex = 14;
            this.lblAlert.Text = "Wrong car plate number.";
            // 
            // lblVehicleReturn
            // 
            this.lblVehicleReturn.AutoSize = true;
            this.lblVehicleReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleReturn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleReturn.Location = new System.Drawing.Point(284, 125);
            this.lblVehicleReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleReturn.Name = "lblVehicleReturn";
            this.lblVehicleReturn.Size = new System.Drawing.Size(226, 36);
            this.lblVehicleReturn.TabIndex = 13;
            this.lblVehicleReturn.Text = "Vehicle Return";
            // 
            // lblCarPlateNo
            // 
            this.lblCarPlateNo.AutoSize = true;
            this.lblCarPlateNo.Location = new System.Drawing.Point(274, 257);
            this.lblCarPlateNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarPlateNo.Name = "lblCarPlateNo";
            this.lblCarPlateNo.Size = new System.Drawing.Size(88, 17);
            this.lblCarPlateNo.TabIndex = 12;
            this.lblCarPlateNo.Text = "CarPlateNo.:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 361);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 33);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCarPlateNo
            // 
            this.txtCarPlateNo.Location = new System.Drawing.Point(375, 257);
            this.txtCarPlateNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarPlateNo.Name = "txtCarPlateNo";
            this.txtCarPlateNo.Size = new System.Drawing.Size(144, 22);
            this.txtCarPlateNo.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 361);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReturnVehicleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblVehicleReturn);
            this.Controls.Add(this.lblCarPlateNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCarPlateNo);
            this.Name = "ReturnVehicleUI";
            this.Text = "Return Vehicle UI";
            this.Load += new System.EventHandler(this.ReturnVehicleUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblVehicleReturn;
        private System.Windows.Forms.Label lblCarPlateNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCarPlateNo;
        private System.Windows.Forms.Button btnCancel;
    }
}