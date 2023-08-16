using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 35;

            Console.WriteLine("There once was a man named " + name);
            Console.WriteLine("He was " + age + " years old");
            Console.WriteLine("He really liked the name " + name);
            Console.WriteLine("But didnt like being " + age);


            workingWithStrings();
            
            workingWithNumbers();

            userInput();

            Console.ReadLine();
        }
        static void dataTypes()
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = false;
        }
        static void workingWithStrings()
        {
            Console.WriteLine();

            //concatenation
            string phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine(phrase);

            //figure out how many characters are in string
            string phrase1 = "Giraffe Academy";
            Console.WriteLine(phrase1.Length);

            //Convert string into upper case
            string phrase2 = "Giraffe Academy";
            Console.WriteLine(phrase2.ToUpper());

            //see if phrase contains a word
            string phrase3 = "Giraffe Academy";
            Console.WriteLine(phrase3.Contains("Academy"));

            //figure out characters in a string
            string phrase4 = "Giraffe Academy";
            Console.WriteLine(phrase4[0]);

            //index position to tell us the value located inside of the string
            string phrase5 = "Giraffe Academy";
            Console.WriteLine(phrase5.IndexOf("Academy"));

            //grab one part of the string and print that out
            string phrase6 = "Giraffe Academy";
                                               //8 --> start grabbing the characters
            Console.WriteLine(phrase6.Substring(8, 3));
                                                   //3 --> how many characters to grab
            //Console.ReadLine();
        }
        static void workingWithNumbers()
        {
            Console.WriteLine();

            //to get remainder --> use modulus
            Console.WriteLine(5 % 2);

            //add 1 to the number --> increments
            int num = 6;
            num++;
            Console.WriteLine(num);

            //MATH METHODS --> math.

            //absolute value
            Console.WriteLine(Math.Abs(-40));

            //raised to a power
            Console.WriteLine(Math.Pow(3, 2));

            //square root
            Console.WriteLine(Math.Sqrt(36));

            //rounding off
            Console.WriteLine(Math.Round(4.4));


            //Console.ReadLine();
        }
        static void userInput()
        {
            Console.WriteLine();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }
    }
}
