using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalCA
{
    public class RentVehicleControl
    {

        public DataTable retrieveAvailableVehicles(string chosenCategory)
        {
            TransactionDAO dao = TransactionDAO.getInstance();

            try
            {
                dao.openConnection();
                DataTable availableVehicles = dao.RetrieveVehicleDetails(chosenCategory);
                return availableVehicles;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dao.CloseConnection();
            }
           

        }

        public void CreateTransaction(string carPlateNumber, int customerID, int days)
        {
            TransactionDAO dao = TransactionDAO.getInstance();
            try
            {
                dao.openConnection();
                dao.CreateTransaction(carPlateNumber, customerID, days);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dao.CloseConnection();
            }
        }

        public void UpdateVehicleStatus(string carPlateNumber)
        {
            TransactionDAO dao = TransactionDAO.getInstance();
            try
            {
                dao.openConnection();
                dao.UpdateVehicleStatus(carPlateNumber);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dao.CloseConnection();
            }
        }

        public Customer RetrieveCustomerDetails(int customerID)
        {
            TransactionDAO dao = TransactionDAO.getInstance();
            try
            {
                dao.openConnection();
                return dao.RetrieveCustomerDetails(customerID);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dao.CloseConnection();
            }
        }

        public void openCustomerRentalDetail(DataGridViewRow vehicle, string chosenCategory)
        {
            CustomerRentalDetailForm f = new CustomerRentalDetailForm(vehicle, chosenCategory);
            f.ShowDialog();
        }
        //Not implemented methods (from Class Diagram) not shown here
    }
}