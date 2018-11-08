using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram
{
    public interface ICalculate
    {
       int final(int a, int b);
       

    }
    class Addtion : ICalculate
    {
        public int final(int a, int b)
        {
            return a + b;
        }
    }
    class Multiply : ICalculate
    {
        public int final(int a, int b)
        {
            return a*b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Addtion add = new Addtion();
            Multiply mul = new Multiply();

            int firstNum = 0, secondNum = 0, sumFinal,multiFinal,userChoice;
            bool isCorrectNumber = true;

            Console.WriteLine("Enter First No:");

            while (isCorrectNumber)
            {
                try
                {
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    isCorrectNumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only Digits");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow");
                }
            }
           

            Console.WriteLine("Enter Second No:");
              isCorrectNumber = true;

            while (isCorrectNumber)
            {
                try
                {
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    isCorrectNumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only Digits");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow");
                }
            }

            sumFinal =  add.final(firstNum, secondNum);
            multiFinal = mul.final(firstNum, secondNum);

            Console.WriteLine("Enter Your Choice:\n 1.Addition\n 2.Multiplication");
            userChoice = Convert.ToInt32(Console.ReadLine());

            int caseSwitch = userChoice;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Addition value is:" + sumFinal);
                    break;
                case 2:
                    Console.WriteLine("Multiplication value is:" + multiFinal);
                    break;
                default:
                    Console.WriteLine("Enter Correct Choice!!");
                    break;
            }

             Console.ReadKey();


           
        }
    }
}
