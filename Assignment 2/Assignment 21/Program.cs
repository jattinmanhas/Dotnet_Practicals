using System;

class FirstProgram
{
     static void Main(string[] args)
     {
          int a = 18;
          int b = 6;
          int c = 2;
          double x = 5;
          double y = 4;
          double z = 2;

          FirstClasses.addition(a, b);
          FirstClasses.subtraction(a, b);
          FirstClasses.multiplication(a, b);
          FirstClasses.division(a, b);
          FirstClasses.orderOperation(a, b, c);
          FirstClasses.remainder(a, b, c);
          FirstClasses.findMinMax();
          FirstClasses.doubleTypes(x, y, z);
          FirstClasses.doubleMinMax();
          FirstClasses.roundingError();
          FirstClasses.decimalMinMax();
          FirstClasses.decimalAndDouble();
          FirstClasses.areaCircle();
     }
}