namespace RentalCA
{
    partial class VehicleSelectionForm
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
            this.cboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dgVehicle = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblVehicleRental = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBoxCategory
            // 
            this.cboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategory.FormattingEnabled = true;
            this.cboBoxCategory.Location = new System.Drawing.Point(233, 181);
            this.cboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBoxCategory.Name = "cboBoxCategory";
            this.cboBoxCategory.Size = new System.Drawing.Size(257, 28);
            this.cboBoxCategory.TabIndex = 10;
            // 
            // dgVehicle
            // 
            this.dgVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicle.Location = new System.Drawing.Point(165, 235);
            this.dgVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVehicle.Name = "dgVehicle";
            this.dgVehicle.RowTemplate.Height = 28;
            this.dgVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVehicle.Size = new System.Drawing.Size(520, 236);
            this.dgVehicle.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(584, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(165, 501);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(101, 41);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(562, 175);
            this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(101, 41);
            this.btnRetrieve.TabIndex = 6;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.availableVehicleButton_Click);
            // 
            // lblVehicleRental
            // 
            this.lblVehicleRental.AutoSize = true;
            this.lblVehicleRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRental.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleRental.Location = new System.Drawing.Point(271, 56);
            this.lblVehicleRental.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleRental.Name = "lblVehicleRental";
            this.lblVehicleRental.Size = new System.Drawing.Size(362, 40);
            this.lblVehicleRental.TabIndex = 15;
            this.lblVehicleRental.Text = "Vehicle Rental Form";
            // 
            // VehicleSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 649);
            this.Controls.Add(this.lblVehicleRental);
            this.Controls.Add(this.cboBoxCategory);
            this.Controls.Add(this.dgVehicle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRetrieve);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VehicleSelectionForm";
            this.Text = "Vehicle Rental Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxCategory;
        private System.Windows.Forms.DataGridView dgVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblVehicleRental;
    }
}