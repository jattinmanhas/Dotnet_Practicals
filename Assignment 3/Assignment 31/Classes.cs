using System;
class Rational
{
     int numerator, denominator;
     public Rational(int a, int b)
     {
          this.denominator = b;
          this.numerator = a;
          if (b == 0)
          {
               throw new DivideByZeroException();
          }
     }
     public void FloatingDivision()
     {
          Console.WriteLine("Floating Point division result = " + ((float)numerator / denominator)); 
     }
     public void IntegerDivison()
     {
          Console.WriteLine($"Integer division result = { (int)numerator / denominator} with a remainder { numerator % denominator}");
     }
     public void MixedFraction()
     {
          int mixedNum = (int)numerator / denominator;

          Console.WriteLine($"The result as a mixed fraction is = { mixedNum} { numerator % denominator}/{ denominator}");
     }
}