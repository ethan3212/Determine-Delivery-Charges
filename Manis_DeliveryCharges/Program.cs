using System;
using System.Data.Common;
using System.Linq.Expressions;
using static System.Console;

namespace Manis_DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zips = { "12789", "54012", "54481", "54982", "60007", "60103", "60187", "60188", "71244", "90210" };
            string[] prices = { "$1 ", "$2 ", "$3 ", "$4 ", "$5 ", "$6", "$7 ", "$8 ", "$9 ", "$10 " };
            int x;
            string entryZip;
            bool zipFound = false;
            Write("Enter a zip code for delivery: ");
            entryZip = ReadLine();

            for (x = 0; x < zips.Length && !zipFound; ++x)
            {
                if (entryZip == zips[x])
                {
                    zipFound = true;
                    string price = prices[x];
                    Write("Delivery to {0} ok. The charge is {1} ", entryZip, price);
                }
            }
            if (!zipFound)
                WriteLine("Sorry, no delivery to {0}", entryZip);
        }
    }
}
