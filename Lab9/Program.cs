using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = false;
            while (ProgramContinue== false)
            {
                Console.WriteLine("Welcome to the Circle Tester");
                Console.WriteLine("Enter Radius");


                CIrcle Object1 = new CIrcle();
                Object1.Radius = double.Parse(Console.ReadLine());


                Object1.GetCircumference();

                Object1.GetArea();

                string UserChoice;
                Console.WriteLine("Do you want to create a new ciricle");
                UserChoice = Console.ReadLine();

                if (UserChoice == "No" || UserChoice== "no")
                {
                    ProgramContinue = true;
                }
     
            }
          



        }
    }
}
