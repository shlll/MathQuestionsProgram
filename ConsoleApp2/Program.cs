using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome, Program!!");
            var name = Console.ReadLine();

            Console.WriteLine(name + " What should u do now? ");
            Console.ReadLine();
            Console.WriteLine("Please choose the following options:");
            var option = "";
            while (option != "e")
            {
                Console.WriteLine("a. to add two numbers");
                Console.WriteLine("b. to substract two numbers");
                Console.WriteLine("c. to multiply two numbers");
                Console.WriteLine("d. to divide two numbers");
                Console.WriteLine("e. to exit the program");
                option = Console.ReadLine();

                if (option == "a")
                {
                    Console.WriteLine("Input 1st number");
                    var firstNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input 2nd number");
                    var secondNum = Int32.Parse(Console.ReadLine());
                    var sum = firstNum + secondNum;
                    Console.WriteLine("The sum is " + sum);
                    Console.ReadLine();

                }
                else if (option == "b")
                {
                    Console.WriteLine("Input 1st number");
                    var firNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input 2nd number");
                    var secNum = Int32.Parse(Console.ReadLine());
                    var sub = firNum - secNum;
                    Console.WriteLine("The sub is " + sub);
                    Console.ReadLine();
                }
                else if (option == "c")
                {
                    Console.WriteLine("Input 1st number");
                    var firstNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input 2nd number");
                    var secondNumber = Int32.Parse(Console.ReadLine());
                    var mul = firstNumber * secondNumber;
                    Console.WriteLine("The mul is " + mul);
                    Console.ReadLine();
                }
                else if (option == "d")
                {
                    Console.WriteLine("Input 1st number");
                    var fiNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input 2nd number");
                    var seNum = Int32.Parse(Console.ReadLine());
                    var div = fiNum / seNum;
                    Console.WriteLine("The div is " + div);
                    Console.ReadLine();

                }
            }









        }
    }
}



