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
    public partial class ReturnDetailsUI : Form
    {
        public ReturnDetailsUI()
        {
            InitializeComponent();
        }

        public void displayTransactionDetails(RentalTransactions transaction, int rentalRate)
        {
            txtCustomerID.Text = transaction.CustomerID.ToString();
            txtRentalStartDate.Text = transaction.RentalStartDate.ToString();
            txtReturnDate.Text = DateTime.Now.Date.ToString();
            txtPayment.Text = (DateTime.Now.Date - transaction.RentalStartDate).ToString();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Update Database
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
