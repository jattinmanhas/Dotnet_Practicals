using System;

static class FirstClasses{
     public static void addition(int a, int b){
          int c = a + b;
          Console.WriteLine($"Addition of two numbers is: {c}");
     }

     public static void subtraction(int a, int b)

     {
          int c = a - b;
          Console.WriteLine($"Subtraction of two numbers is: {c}");
     }
     public static void multiplication(int a, int b)
     {
          int x = a * b;
          Console.WriteLine($"Multiplication of two numbers is: {x}");
     }
     public static void division(int a, int b)
     {
          int y = a / b;
          Console.WriteLine($"Division of two numbers is: {y}");
     }
     public static void orderOperation(int a, int b, int c)
     {
          int z = a + b * c;
          Console.WriteLine($"Output for above Operation : ${z}");
     }
     public static void remainder(int a, int b, int c)
     {
          int d = (a + b) / c;
          int e = (a + b) % c;
          Console.WriteLine($"quotient : {d}");
          Console.WriteLine($"remainder : {e}");
     }
     public static void findMinMax()
     {
          int max = int.MaxValue;
          int min = int.MinValue;
          Console.WriteLine($"The range of integers is {min} to {max}");
     }
     public static void doubleTypes(double x, double y, double z)
     {
          double d = (x + y) / z;
          Console.WriteLine($"double expresion (a+b)/c = {d}");
     }
     public static void doubleMinMax()
     {
          double max = double.MaxValue;
          double min = double.MinValue;
          Console.WriteLine($"The range of double is {min} to {max}");
     }
     public static void roundingError()
     {
          double third = 1.0 / 3.0;
          Console.WriteLine($"rounding error in double {third}");
     }
     public static void decimalMinMax()
     {
          decimal min = decimal.MinValue;
          decimal max = decimal.MaxValue;
          Console.WriteLine($"The range of the decimal type is {min} to {max}");
     }
     public static void decimalAndDouble()
     {
          double a = 1.0;
          double b = 3.0;
          Console.WriteLine($"Double: {a / b}");

          decimal c = 1.0M;
          decimal d = 3.0M;
          Console.WriteLine($"Decimal: {c / d}");
     }
     public static void areaCircle()
     {
          double radius = 2.50;
          double area = Math.PI * radius * radius;
          Console.WriteLine(area);
     }
}