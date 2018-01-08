using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RentalCA
{
    public class VehicleDAO
    {


        SqlConnection cn;       // Declaring Connection object
                                // SqlCommand cmInsert;
        SqlCommand cmSelectDetails;
        SqlCommand cmSelectTransactionDetails;


        private static VehicleDAO dbInstance;

        private VehicleDAO()
        {
            // 
            // string strCN = @"Data Source=(local);" +
            //    "Integrated Security=SSPI;" +
            //   "Initial Catalog = Dafesty";


            //   string strCN = "Data Source=(local);initial catalog=Dafesty;" +
            //         "user id=sa; password=password-12";

            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|VehicleRental.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            initializeSQLCmd();
        }


        private void initializeSQLCmd()
        {

            cmSelectDetails = new SqlCommand();
            cmSelectTransactionDetails = new SqlCommand();

            cmSelectDetails.CommandText =
               "Select Model, Colour, EngineSerialNumber, RentalStatus from Vehicle WHERE CarPlateNumber =@carPlateNumber";
            cmSelectDetails.Connection = cn;

            cmSelectTransactionDetails.CommandText =
                "Select TransID, CustomerID, RentalStartDate, RentalRate from Vehicle inner join RentalTransaction on Vehicle.CarPlateNumber = RentalTransaction.CarPlateNumber WHERE Vehicle.CarPlateNumber =@carPlateNumber and RentalStatus = 'Rented out'";
            cmSelectTransactionDetails.Connection = cn;

        }
        public static VehicleDAO getInstance()
        {

            if (dbInstance == null)
                dbInstance = new VehicleDAO();

            return dbInstance;
        }

        public void openConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }

        //public void InsertCustomer(Customer customer)
        //{
        //    if (RetrieveCustomerCount(customer.CustomerId) != 0)
        //        throw new DFTException(DFTMessage.CustomerRecordFound);

        //    SqlParameter pCustomerId =
        //         new SqlParameter("@CustomerId", SqlDbType.NVarChar, 4);
        //    SqlParameter pCustomerName =
        //        new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50);
        //    SqlParameter pPhoneNumber =
        //        new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 9);
        //    SqlParameter pEmailAddress =
        //        new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 30);

        //    // clear any previous parameters set before adding new parameters
        //    cmInsert.Parameters.Clear();
        //    cmInsert.Parameters.AddRange(new SqlParameter[]
        //              { pCustomerId, pCustomerName, pPhoneNumber, pEmailAddress });

        //    pCustomerId.Value = customer.CustomerId;
        //    pCustomerName.Value = customer.CustomerName;
        //    pPhoneNumber.Value = customer.PhoneNumber;
        //    pEmailAddress.Value = customer.EmailAddress;

        //    cmInsert.ExecuteNonQuery();

        //}

        public Vehicle RetrieveVehicleDetails(string carPlateNumber)
        {
            SqlParameter pCarPlateNumber =
                 new SqlParameter("@carPlateNumber", SqlDbType.NVarChar, 50);
            pCarPlateNumber.Value = carPlateNumber;

            cmSelectDetails.Parameters.Clear();
            cmSelectDetails.Parameters.Add(pCarPlateNumber);


            Vehicle v = new Vehicle(); ;

            // execute reader
            SqlDataReader rd = cmSelectDetails.ExecuteReader();
            if (rd.Read())
            {
                v.Model = rd["Model"].ToString();
                v.Colour = rd["Colour"].ToString();
                v.EngineSerialNumber = rd["EngineSerialNumber"].ToString();
                v.RentalStatus = rd["RentalStatus"].ToString();
            }
            else
            {
                throw new VehException(VehMessage.VehicleRecordNotFound);
            }

            // close reader
            rd.Close();
            return v;
        }
        public RentalTransactions retrieveTransactionRecord(string txtCarPlateNo, out int rentalRate)
        {
            SqlParameter pCarPlateNumber = new SqlParameter("@carPlateNumber", SqlDbType.NVarChar, 50);
            pCarPlateNumber.Value = txtCarPlateNo;
            cmSelectTransactionDetails.Parameters.Clear();
            cmSelectTransactionDetails.Parameters.Add(pCarPlateNumber);


            RentalTransactions t = new RentalTransactions();
  

            SqlDataReader rd = cmSelectTransactionDetails.ExecuteReader();
            if (rd.Read())
            {
                t.TransID =int.Parse(rd["TransID"].ToString());
                t.RentalStartDate = DateTime.Parse(rd["RentalStartDate"].ToString());
                t.CustomerID =int.Parse(rd["CustomerID"].ToString());
                rentalRate = int.Parse(rd["RentalRate"].ToString());
            }
            else
            {
                throw new VehException(VehMessage.VehicleRecordNotFound);
            }

            rd.Close();
            return t;

        }
    }
}
