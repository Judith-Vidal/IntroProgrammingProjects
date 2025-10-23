//############################################################################
//Author    : Judith Morales Vidal
//Date      : 2024.09.03
//email     : jmoral58@students.solano.edu
//class     : 807
//desc      : Finding the largest Number out of 3 numbers
//############################################################################

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargest2 {
    internal class Program {
        static void Main(string[] args)
        {

            //Prompt an user or 3 Integer Values
            int num1 = 0, num2 = 0, num3 = 0;
            Console.WriteLine("Please enter in value number 1?");
            num1 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter in value number 2?");
            num2 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Please enter in value number 3?");
            num3 = Convert.ToInt32(Console.ReadLine().Trim());

            //decide which is the largest

            if (num1 > num2) {
                if (num1 > num3) {
                    Console.WriteLine("Number 1 is the largest!");
                } else {
                    Console.WriteLine("Number 3 is the largest!");
                }
            } else if (num2 > num3) {
                Console.WriteLine("Number 2 is the largest!");
            } else {
                Console.WriteLine("Number 3 is the largest!");
            }
        }
    }
}
