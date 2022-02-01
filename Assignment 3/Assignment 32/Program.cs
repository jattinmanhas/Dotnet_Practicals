// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
     class MainProgram
     {
          public static void Main(string[] args)
          {
               Console.WriteLine("\nEnter a string : ");
               String str = Console.ReadLine();
               Console.WriteLine($"\'{str}\' has length : { StringClasses.Length(str)}");

               
                Console.WriteLine("\nEnter a sentence : ");
               String sentence = Console.ReadLine();

               if (StringClasses.isDeclarative(sentence))
               {
                    Console.WriteLine("It is a declarative sentence");
               }
               else if (StringClasses.isExclamation(sentence))
               {
                    Console.WriteLine("It is a Exclamatory sentence");
               }
               else if (StringClasses.isInterrogative(sentence))
               {
                    Console.WriteLine("It is a interrogative sentence");
               }
               else{
                    Console.WriteLine("It is not a Sentence.");
               }

              
               Console.WriteLine("\nEnter a name, having first name and last name: ");
               String name = Console.ReadLine() ;
               StringClasses.commaName(name);


               Console.WriteLine("\nEnter a name : ");
               String sname = Console.ReadLine();
               StringClasses.modifiedCommaName(sname);
          }
     }
}