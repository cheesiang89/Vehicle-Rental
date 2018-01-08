using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RentalCA
{
    class VehUtil
    {
        public static bool isEmpty(String s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }

        public static bool isCustomerID(String s)
        {
            int result;
            if (Int32.TryParse(s, out result) && s.Length == 7)
                return true;
            else
                return false;
        }

        public static bool isEmailValid(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        public static bool isTelephone(string telephone)
        {
            int result;
            if (Int32.TryParse(telephone, out result)&&result>=60000000&&result<=99999999)
                return true;
            else
                return false;
        }

        public static bool isRentalDayValid(string days)
        {
            short result;
            if (Int16.TryParse(days, out result) && result > 0)
                return true;
            else
                return false;
        }

    }
}
