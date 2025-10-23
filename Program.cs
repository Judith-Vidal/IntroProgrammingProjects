//############################################
//Author    : Judith Morales Vidal
//Date      : 2024.09.03
//email     : jmoral58@students.solano.edu
//class     : 807
//desc      : A simple F -> C converter
//############################################

//namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature2 {
    internal class Program {
        static void Main(string[] args) {
            
            /********************************
            * Part 1: F-> C
            **********************************/
            // C = (F - 32) x 5/9
            double fah = 0;
            Console.WriteLine("Please enter in a Fahrenheit value? ");
            fah = Convert.ToDouble(Console.ReadLine().Trim());

            double cel = (fah - 32) * (5.0 / 9);
            Console.WriteLine("Your celius value is {0}; ", cel);
            //Console.WriteLine("Your celius value is; " + cel.ToString());


            /********************************
            * Part 2: C-> F
            **********************************/
            // F =  (9/5) C+32
            double cel2 = 0.00;
            Console.WriteLine("Please enter in a Celcius value? ");
            cel2 = Convert.ToDouble(Console.ReadLine().Trim());
            
            double fah2 = ((9.0/5.0) * cel2) + 32;
            Console.WriteLine("Your fahrenheit value is {0}", fah2);

        }
    }
}
