// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
     class Main_Program
     {
          public static void Main()
          {
               Console.WriteLine("Please enter the numerator?");
               int numerator = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Please enter the denominator?");
               int denominator = Convert.ToInt32(Console.ReadLine());

               Rational rational = new Rational(numerator, denominator);

               rational.IntegerDivison();
               rational.FloatingDivision();
               rational.MixedFraction();
          }
     }
}