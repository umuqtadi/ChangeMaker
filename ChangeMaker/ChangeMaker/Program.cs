using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);

            Console.ReadKey();
        }


        /// <summary>
        /// Fuction takes any dollar amount that you give it and subtracts the change until there is nothing left, while adding up quarters, dimes, nickels and pennies in the most efficient way
        /// </summary>
        /// <param name="amount">amount that you want split up into change</param>
        /// <returns></returns>
        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();
            
            //has to go up here because when put at the bottom it gives the amount after all the change has been deducted
            Console.WriteLine("Amount: {0}", amount);
            
            
            //keeps looping through until the number reaches zero
            while (amount > 0)
            {
                //if the amount is higher then 0.25 it will keep subtracting 0.25 until its below that number
                if (amount >= 0.25m)
                {
                    amount -= 0.25m;
                    amountAsChange.Quarters++;
                }
                    //if number is above 10, but below 25 it will subtract 0.10
                else if (amount >= 0.10m)
                {
                    amount -= 0.10m;
                    amountAsChange.Dimes++;
                }
                else if (amount >= 0.05m)
                {
                    amount -= 0.05m;
                    amountAsChange.Nickles++;
                }
                else
                {
                    amount -= 0.01m;
                    amountAsChange.Pennies++;
                }
            }
            //TODO: Fill in the the code to make this function work

            Console.WriteLine("Quarters: {0}", amountAsChange.Quarters);
            Console.WriteLine("Dimes: {0}", amountAsChange.Dimes);
            Console.WriteLine("Nickles: {0}", amountAsChange.Nickles);
            Console.WriteLine("Pennies: {0}", amountAsChange.Pennies);
            Console.WriteLine("\n");

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
