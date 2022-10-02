using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {

        static void Main(string[] args)
        {
            string str01 = "Hello, GeekBrains!";

            Console.WriteLine("My first application.");
            System.Console.WriteLine(str01);
            TestNamespase.Program.Sample1();

            int index = 2;
            System.Int32 counter = 3;

            char c = 'a';


            Console.Title = "Сложение двух чисел";
            Console.Clear();

            Console.Write("Введите первое число: ");
            string inputFirstString = Console.ReadLine();
            int firstNumber = int.Parse(inputFirstString);



            Console.Write("Введите второе число: ");
            string inputSecondtString = Console.ReadLine();
            int secondNumber = int.Parse(inputSecondtString);

            int sumResult = firstNumber + secondNumber;

            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sumResult);
            Console.WriteLine("{0} + {1} = {2}      {0} {0} {0} {0} {0}  {2} {2}", firstNumber, secondNumber, sumResult);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sumResult}");

            // + - * / %
            Console.ReadLine();
        }

        static void Sample1()
        {

        }

        static void Sample2()
        {

        }



    }



}

namespace TestNamespase
{
    public class Program
    {
        public static void Sample1()
        {

        }
    }
}
