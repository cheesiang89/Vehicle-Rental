using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCA
{
    class VehException : ApplicationException
    {
        public VehException() : base()    {
        }

        public VehException(string message) : base(message)   {
        }

        public VehException(string message, Exception innerExc) 
            : base(message, innerExc)   {
        }
    }
}
