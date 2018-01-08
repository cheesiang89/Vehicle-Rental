using System.Data;
using System.Data.SqlClient;
using System;

namespace RentalCA
{
    public class TransactionDAO
    {
        SqlConnection cn;       // Declaring Connection object
                                // SqlCommand cmInsert;
        SqlCommand cmSelectAvailableCar;
        SqlCommand cmSelectAvailableTruck;
        SqlCommand cmSelectAvailableBus;
        SqlCommand cmSelectAvailableVehicle;
        SqlCommand cmInsertTransaction;
        SqlCommand cmUpdateVehicleStatus;
        SqlCommand cmSelectCustomerDetails;

        private static TransactionDAO dbInstance;
        public TransactionDAO()
        {
            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename =|DataDirectory|VehicleRental.mdf;" +
               @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            initializeSQLCmd();
        }


        private void initializeSQLCmd()
        {
           
            cmSelectAvailableCar = new SqlCommand();
            cmSelectAvailableTruck = new SqlCommand();
            cmSelectAvailableBus = new SqlCommand();
            cmInsertTransaction = new SqlCommand();
            cmUpdateVehicleStatus = new SqlCommand();
            cmSelectCustomerDetails = new SqlCommand();

            cmSelectAvailableCar.CommandText =
               "Select Model, Colour, CarType, MaxSeats, RentalRate, RentalStatus, Vehicle.CarPlateNumber from Vehicle inner join Car on Vehicle.CarPlateNumber = Car.CarPlateNumber WHERE RentalStatus='Available'";
            cmSelectAvailableCar.Connection = cn;

            cmSelectAvailableTruck.CommandText =
               "Select Model, Colour, NumberWheels, MaxCargo, RentalRate, RentalStatus, Vehicle.CarPlateNumber from Vehicle inner join Truck on Vehicle.CarPlateNumber = Truck.CarPlateNumber WHERE RentalStatus='Available'";
            cmSelectAvailableTruck.Connection = cn;

            cmSelectAvailableBus.CommandText =
               "Select Model, Colour, Television, MaxPassengers, RentalRate, RentalStatus, Vehicle.CarPlateNumber from Vehicle inner join Bus on Vehicle.CarPlateNumber = Bus.CarPlateNumber WHERE RentalStatus='Available'";
            cmSelectAvailableBus.Connection = cn;

            cmInsertTransaction.CommandText =
                "Insert into RentalTransaction(RentalStartDate, RentalTargetEndDate, CustomerID, CarPlateNumber) values(@RentalStartDate, @RentalTargetEndDate, @CustomerID, @CarPlateNumber)";
            cmInsertTransaction.Connection = cn;

            cmUpdateVehicleStatus.CommandText =
                "Update Vehicle set RentalStatus = 'Rented Out' where CarPlateNumber = @CarPlateNumber";
            cmUpdateVehicleStatus.Connection = cn;

            cmSelectCustomerDetails.CommandText =
                "Select * from Customer where CustomerID=@customerID";
            cmSelectCustomerDetails.Connection = cn;


        }

        public DataTable RetrieveVehicleDetails(string chosenCategory)
        {
            switch (chosenCategory)
            {
                case "Car":
                    cmSelectAvailableVehicle = cmSelectAvailableCar;
                    break;
                case "Truck":
                    cmSelectAvailableVehicle = cmSelectAvailableTruck;
                    break;
                case "Bus":
                    cmSelectAvailableVehicle = cmSelectAvailableBus;
                    break;
            }

           

            SqlParameter pChosenCategory =
                 new SqlParameter("@ChosenCategory", SqlDbType.NVarChar);
            pChosenCategory.Value = chosenCategory;

            // clear any previous parameters set before adding new parameters
            cmSelectAvailableVehicle.Parameters.Clear();
            cmSelectAvailableVehicle.Parameters.Add(pChosenCategory);

            SqlDataAdapter da = new SqlDataAdapter(cmSelectAvailableVehicle);
            DataSet ds = new DataSet();
            da.Fill(ds);
        
            return ds.Tables[0];
        }

        public static TransactionDAO getInstance()
        {

            if (dbInstance == null)
                dbInstance = new TransactionDAO();

            return dbInstance;
        }

        public void CreateTransaction(string carPlateNumber, int customerID, int days)
        {
            SqlParameter pRentalStartDate = new SqlParameter("@RentalStartDate", SqlDbType.DateTime);
            pRentalStartDate.Value = DateTime.Now.Date;

            SqlParameter pRentalTargetEndDate = new SqlParameter("@RentalTargetEndDate", SqlDbType.DateTime);
            pRentalTargetEndDate.Value = DateTime.Now.AddDays(days);

            SqlParameter pCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);
            pCustomerID.Value = customerID;

            SqlParameter pCarPlateNumber = new SqlParameter("@CarPlateNumber", SqlDbType.NVarChar, 30);
            pCarPlateNumber.Value = carPlateNumber;

            cmInsertTransaction.Parameters.Clear();
            cmInsertTransaction.Parameters.AddRange(new SqlParameter[] { pRentalStartDate, pRentalTargetEndDate, pCustomerID, pCarPlateNumber });

            
            cmInsertTransaction.ExecuteNonQuery();
        }

        public void UpdateVehicleStatus(string carPlateNumber)
        {
            SqlParameter pCarPlateNumber = new SqlParameter("@CarPlateNumber", SqlDbType.NVarChar, 30);
            pCarPlateNumber.Value = carPlateNumber;

            cmUpdateVehicleStatus.Parameters.Clear();
            cmUpdateVehicleStatus.Parameters.Add(pCarPlateNumber);

            cmUpdateVehicleStatus.ExecuteNonQuery();
        }

        public Customer RetrieveCustomerDetails(int customerID)
        {
            SqlParameter pCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);
            pCustomerID.Value = customerID;

            cmSelectCustomerDetails.Parameters.Clear();
            cmSelectCustomerDetails.Parameters.Add(pCustomerID);

            Customer c = new Customer();
            // execute reader
            SqlDataReader rd = cmSelectCustomerDetails.ExecuteReader();
            if (rd.Read())
            {
                c.CustomerName = rd["CustomerName"].ToString();
                c.Telephone = Int32.Parse(rd["Telephone"].ToString());
                c.EmailAddress = rd["EmailAddress"].ToString();
            }
            else
            {
                throw new VehException(VehMessage.VehicleRecordNotFound);
            }

            return c;
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
    }
}
