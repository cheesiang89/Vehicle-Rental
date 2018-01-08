using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCA
{
    public partial class VehicleSelectionForm : Form
    {
        public VehicleSelectionForm()
        {
            InitializeComponent();
            cboBoxCategory.DataSource = new string[] { "Car", "Truck", "Bus" };
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                RentVehicleControl c = new RentVehicleControl();
                c.openCustomerRentalDetail(dgVehicle.CurrentRow, cboBoxCategory.Text);
            }
            catch (Exception)
            {

                MessageBox.Show(VehMessage.NoVehicleSelected);
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void availableVehicleButton_Click(object sender, EventArgs e)
        {
            try
            {
                RentVehicleControl c = new RentVehicleControl();
                string chosenCategory = cboBoxCategory.Text;
                dgVehicle.DataSource = c.retrieveAvailableVehicles(chosenCategory);
            }
            catch (Exception)
            {
                MessageBox.Show(VehMessage.GeneralErrorMsg);
            }

        }
    }
}
