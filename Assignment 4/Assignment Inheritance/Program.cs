// See https://aka.ms/new-console-template for more information
using System;
class Program
{
     public static void Main(string[] args)
     {
          PermanentEmployee e1 = new PermanentEmployee("Eren", "Yeager", new DateTime(2002,07,10, 9, 30, 00), new DateTime(2032, 03, 01), 73000.0, 25000, 1200, 10000);
          Console.WriteLine($"\n\nInformation about First Employee:\n{e1}"); e1.GiveRaise(10.0);
          Console.WriteLine($"\n\nInformation about First Employee after 10% raise:\n{e1}");

          PermanentEmployee e2 = new PermanentEmployee("Levi", "Ackerman", new DateTime(1995 , 03, 23, 10,00,00), new DateTime(2029,03,29), 59000.0, 21000, 1200, 12000);
          Console.WriteLine($"\n\nInforamtion about second Employee:\n{e2}"); e2.GiveRaise(8.0);
          Console.WriteLine($"\n\nInforamtion about second Employee after raise:\n{e2}");

     //method hidding
          e1.methodHiding();
          
     //method overloading
          Console.WriteLine("Method overloading example....");
          Console.WriteLine("Multiplication of two numbers: " + PermanentEmployee.mulDisplay(10, 15));
          Console.WriteLine("Multiplication of three numbers: " + PermanentEmployee.mulDisplay(8, 13, 20));
          Console.WriteLine("Multiplication of four numbers: " + PermanentEmployee.mulDisplay(3, 7, 10, 7));
     }
}
