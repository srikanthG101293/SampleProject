using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Hyundai : Cars
    {

        static void Main(string[] args)
        {
            Hyundai dust = new Hyundai();

            Console.WriteLine(dust.CallFacility());
            Console.WriteLine(dust.Wheel());
            Console.WriteLine(dust.CheckAC());
            Console.ReadLine();
        }
    }
}
