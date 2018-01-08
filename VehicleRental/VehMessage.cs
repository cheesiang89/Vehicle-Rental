using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCA
{
    class VehMessage
    {
        public const String GeneralErrorMsg
           = "DFT014E Services not available. Please contact helpdesk.";

        //Don't need
        //public const String VehicleRecordFound
        //    = "Record exist.  Please enter another id.";
        public const String VehicleRecordNotFound
            = "DFT015E Vehicle record not found.  Please enter another car plate number.";

        public const String EmptyCarPlateNumber
            = "DFT016E Car Plate Number cannot be empty.  Please enter a car plate number.";

        public const String EmptyCustomerID
            = "DFT017E Customer ID cannot be empty.  Please enter a customer ID.";

        public const String InvalidEmaildAddress
            = "DFT018E Invalid email address.  Please enter a valid email address.";

        public const String InvalidCustomerID
            = "DFT019E Invalid customer ID.  Please enter a valid customer ID.";

        public const String InvalidTelephone
            = "DFT020E Invalid telephone number.  Please enter a valid telephone number.";

        public const String InvalidDays
            = "DFT021E Invalid rental days.  Please enter a valid rental days.";

        public const String NoVehicleSelected
            = "DFT021E No Vehicle Selcted.  Please select a valid vehicle.";

        //public const String CreateCustomer
        //    = "No Customer ID, new customer record will be created!";
        //Dpnt need
        //public const String CustomerRecordSuccessful
        //    = "DFT099I Customer record successfully created!";
    }
}
