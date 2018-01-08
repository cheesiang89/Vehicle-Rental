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
    public partial class CustomerRentalDetailForm : Form
    {
        DataGridViewRow vehicleDetails;
        public CustomerRentalDetailForm(DataGridViewRow vehicleDetails, string chosenCategory)
        {
            this.vehicleDetails = vehicleDetails;
            InitializeComponent();
            displayVehicleDetail(vehicleDetails, chosenCategory);

        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            //if (VehUtil.isEmpty(txtCustomerID.Text))
            //{
            //    MessageBox.Show(VehMessage.CreateCustomer);

            //}

            try
            {

                if (VehUtil.isEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show(VehMessage.EmptyCustomerID);
                    return;
                }
                if (!VehUtil.isCustomerID(txtCustomerID.Text))
                {
                    MessageBox.Show(VehMessage.InvalidCustomerID);
                    return;
                }
                if (!VehUtil.isEmailValid(txtEmail.Text))
                {
                    MessageBox.Show(VehMessage.InvalidEmaildAddress);
                    return;
                }
                if (!VehUtil.isTelephone(txtTelephone.Text))
                {
                    MessageBox.Show(VehMessage.InvalidTelephone);
                    return;
                }
                if (!VehUtil.isRentalDayValid(txtRentalDays.Text))
                {
                    MessageBox.Show(VehMessage.InvalidDays);
                    return;
                }


                RentVehicleControl c = new RentVehicleControl();
                string carPlateNumber = vehicleDetails.Cells[6].Value.ToString();
                int customerID = Int32.Parse(txtCustomerID.Text);
                int days = Int32.Parse(txtRentalDays.Text);
                c.CreateTransaction(carPlateNumber, customerID, days);
                MessageBox.Show("Rent Success!");
            }
            catch (Exception)
            {
                MessageBox.Show(VehMessage.GeneralErrorMsg);
            }
}

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (VehUtil.isEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show(VehMessage.EmptyCustomerID);
                    return;
                }


                if (!VehUtil.isCustomerID(txtCustomerID.Text))
                {
                    MessageBox.Show(VehMessage.InvalidCustomerID);
                    return;
                }

                RentVehicleControl c = new RentVehicleControl();
                Customer customer = c.RetrieveCustomerDetails(Int32.Parse(txtCustomerID.Text));
                txtName.Text = customer.CustomerName;
                txtTelephone.Text = customer.Telephone.ToString();
                txtEmail.Text = customer.EmailAddress;
            }
            catch (Exception)
            {
                MessageBox.Show(VehMessage.GeneralErrorMsg);
            }

        }

        public void displayVehicleDetail(DataGridViewRow vehicleDetails, string chosenCategory)
        {
            lblModel.Text = "Model: "+ vehicleDetails.Cells[0].Value.ToString();
            lblColour.Text = "Colour: " + vehicleDetails.Cells[1].Value.ToString();
            switch (chosenCategory)
            {
                case "Car":
                    lbl2.Text = "CarType:    " + vehicleDetails.Cells[2].Value.ToString();
                    lbl3.Text = "MaxSeats:    " + vehicleDetails.Cells[3].Value.ToString();
                    break;
                case "Truck":
                    lbl2.Text = "NumberWheels:    " + vehicleDetails.Cells[2].Value.ToString();
                    lbl3.Text = "MaxCargo:    " + vehicleDetails.Cells[3].Value.ToString();
                    break;
                case "Bus":
                    lbl2.Text = "Television:    " + vehicleDetails.Cells[2].Value.ToString();
                    lbl3.Text = "MaxPassengers:    " + vehicleDetails.Cells[3].Value.ToString();
                    break;
            }

            lblRetalRate.Text = "Rental Rate: " + vehicleDetails.Cells[4].Value.ToString();
        }
    }
}
