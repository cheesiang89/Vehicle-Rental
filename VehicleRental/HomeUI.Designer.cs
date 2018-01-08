namespace RentalCA
{
    partial class HomeUI
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
            this.btnEnquireVehicle = new System.Windows.Forms.Button();
            this.btnRentVehicle = new System.Windows.Forms.Button();
            this.btnReturnVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnquireVehicle
            // 
            this.btnEnquireVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnquireVehicle.Location = new System.Drawing.Point(139, 279);
            this.btnEnquireVehicle.Name = "btnEnquireVehicle";
            this.btnEnquireVehicle.Size = new System.Drawing.Size(183, 113);
            this.btnEnquireVehicle.TabIndex = 0;
            this.btnEnquireVehicle.Text = "Enquire Vehicle";
            this.btnEnquireVehicle.UseVisualStyleBackColor = true;
            this.btnEnquireVehicle.Click += new System.EventHandler(this.btnEnquireVehicle_Click);
            // 
            // btnRentVehicle
            // 
            this.btnRentVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentVehicle.Location = new System.Drawing.Point(139, 96);
            this.btnRentVehicle.Name = "btnRentVehicle";
            this.btnRentVehicle.Size = new System.Drawing.Size(183, 113);
            this.btnRentVehicle.TabIndex = 1;
            this.btnRentVehicle.Text = "Rent Vehicle";
            this.btnRentVehicle.UseVisualStyleBackColor = true;
            this.btnRentVehicle.Click += new System.EventHandler(this.btnRentVehicle_Click);
            // 
            // btnReturnVehicle
            // 
            this.btnReturnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnVehicle.Location = new System.Drawing.Point(409, 96);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.Size = new System.Drawing.Size(183, 113);
            this.btnReturnVehicle.TabIndex = 2;
            this.btnReturnVehicle.Text = "Return Vehicle";
            this.btnReturnVehicle.UseVisualStyleBackColor = true;
            this.btnReturnVehicle.Click += new System.EventHandler(this.btnReturnVehicle_Click);
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.Controls.Add(this.btnReturnVehicle);
            this.Controls.Add(this.btnRentVehicle);
            this.Controls.Add(this.btnEnquireVehicle);
            this.Name = "HomeUI";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnquireVehicle;
        private System.Windows.Forms.Button btnRentVehicle;
        private System.Windows.Forms.Button btnReturnVehicle;
    }
}

