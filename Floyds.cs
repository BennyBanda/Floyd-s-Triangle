using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3p
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopedNumber1, loopedNumber2, convertedNumber,num1,num0; //Our variables to use

            Console.Write("\n\n"); //Prints out space
            Console.Write("A program that displays the Floyd's triangle : "); // title
            Console.Write("\n\n");
            Console.Write("--------------------------------------------------------------------------"); // separating the title from the number of rows
            Console.Write("\n\n");

            Console.Write("Enter the number of Rows : ");
            convertedNumber = Convert.ToInt32(Console.ReadLine()); // converting the users enterd values into intergers
            Console.Write("Displaying the Floyd's Triangle with {0} number of rows: ", convertedNumber);
            Console.Write("\n\n");

            for(loopedNumber1 = 1;loopedNumber1 <=convertedNumber; loopedNumber1 ++) //first loop
            {
                if (loopedNumber1 % 2 == 0)
                {
                    num1 = 1;
                    num0 = 0;
                }
                else
                {
                    num1 = 0;
                    num0 = 1;
                }
                for (loopedNumber2 = 1; loopedNumber2 <= loopedNumber1; loopedNumber2++) // second loop
                    if (loopedNumber2 % 2 == 0)
                        Console.Write("{0}", num1);
                    else
                        Console.Write("{0}", num0);
                        Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
