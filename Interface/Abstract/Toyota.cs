using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Toyota : Cars, NewFeatures
    {
        public string DiscountPrice()
        {
            return "20% discount on buying Toyoya Cars";
        }
        public override double price()
        {
            return 1000000.00;
        }
        public override int getTotalSeat()
        {
            return 5;
        }
        public override string colors()
        {
            return "Red";
        }

        static void Main(string[] args)
        {
            Toyota Toy = new Toyota();
            Console.WriteLine("-------Common property defined commonly in Cars Class----------");

            Console.WriteLine(Toy.CallFacility());
            Console.WriteLine(Toy.Wheel());
            Console.WriteLine(Toy.CheckAC());
            Console.WriteLine("-------Own property defined in Toyota class------------");
            Console.WriteLine(Toy.DiscountPrice());
            Console.WriteLine("-------Common method but implementation is diffrent defined in IExtra Interface------------");
            Console.WriteLine("Total ONRoad Price:" + Toy.price());
            Console.WriteLine(Toy.getTotalSeat());
            Console.WriteLine(Toy.colors());

            Console.ReadLine();
        }

        public string GPS()
        {
            throw new NotImplementedException();
        }
    }
}
