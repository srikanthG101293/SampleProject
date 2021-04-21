using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Cars
    {

        //put all the common functions but diffrent implementation in  abstract method.  
        public abstract double price();
        public abstract int getTotalSeat();
        public abstract string colors();

        //put all the common property in normal class  
        public string Wheel()
        {
            return "4 wheeler";

        }
        public string CheckAC()
        {
            return "AC is available";
        }
        public string CallFacility()
        {
            return "Call Facility  supported";
        }
    }
}
