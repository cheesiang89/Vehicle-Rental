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
    public partial class EnquireStatusUI : Form
    {
        public EnquireStatusUI()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (VehUtil.isEmpty(txtCarPlateNumber.Text))
                {
                    MessageBox.Show(VehMessage.EmptyCarPlateNumber);
                    return;
                }
                EnquireStatusControl statusControl = new EnquireStatusControl();
                Vehicle v = statusControl.RetrieveVehicle(txtCarPlateNumber.Text);
                txtModel.Text = v.Model;
                txtColor.Text = v.Colour;
                txtESN.Text = v.EngineSerialNumber;
                txtStatus.Text = v.RentalStatus;
            }
            catch (VehException vehExcep)
            {
                //Console.WriteLine("Exception !!!");
                //Console.WriteLine(vehExcep.Message);
                //Console.WriteLine(vehExcep.StackTrace);
                MessageBox.Show(vehExcep.Message);
            }
            catch (Exception excep)
            {
                //Console.WriteLine("Exception !!!");
                //Console.WriteLine(excep.Message);
                //Console.WriteLine(excep.StackTrace);
                MessageBox.Show(VehMessage.GeneralErrorMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
