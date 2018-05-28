/********************************************************************
 * Original from SDEV 240                                           *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 255, Excercise 11):                           *
 * In a “You Do It” section of this chapter, you created a tipping  * 
 * table for patrons to use when analyzing their restaurant bills.  *
 * Now, create a modified program named TippingTable3 in which      *
 * each of the following values is obtained from user input:        *
 * - The lowest tipping percentage                                  *
 * - The highest tipping percentage                                 *
 * - The lowest possible restaurant bill                            *
 * - The highest restaurant bill.                                   *
 ********************************************************************/
using System;

namespace TippingTable3
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables
            double DinnerPrice, TipRate, Tip,  LOWRATE, MAXRATE, MAXDINNER;
            const double TIPSTEP = 0.05;
            const double DINNERSTEP = 10.00;

            //ask user for inputs
            Console.Write("Enter the lowest tipping rate(in decimal form (ex. 5% = 0.05): ");
            string lrate = Console.ReadLine();
            LOWRATE = Convert.ToDouble(lrate);

            Console.Write("Enter the highest tipping rate in decimal form (ex. 20% = 0.20): ");
            string hrate = Console.ReadLine();
            MAXRATE = Convert.ToDouble(hrate);

            Console.Write("Enter the lowest bill: $");
            string lbill = Console.ReadLine();
            DinnerPrice = Convert.ToDouble(lbill);

            Console.Write("Enter the highest bill: $");
            string hbill = Console.ReadLine();
            MAXDINNER = Convert.ToDouble(hbill);

            //spacer
            Console.WriteLine();

            //display header
            Console.Write("Price");
            for (TipRate = LOWRATE; TipRate <= MAXRATE; TipRate += TIPSTEP)
                Console.Write("{0, 8}", TipRate.ToString("F"));
            Console.WriteLine();

            //create dashed line below header
            const int NUM_DASHES = 100;
            for (int x = 0; x < NUM_DASHES; ++x)
                Console.Write("-");
            Console.WriteLine();

            //display tip associated with price as a chart
            TipRate = LOWRATE;

            while (DinnerPrice <= MAXDINNER)
            {
                Console.Write("{0, 8}", DinnerPrice.ToString("C"));
                while (TipRate <= MAXRATE)
                {
                    Tip = DinnerPrice * TipRate;
                    Console.Write("{0, 8}", Tip.ToString("C"));
                    TipRate += TIPSTEP;
                }
                DinnerPrice += DINNERSTEP;
                TipRate = LOWRATE;
                Console.WriteLine();
            }

            //stops program from automatically closing after above text displays.
            Console.ReadLine();
        }
    }
}
