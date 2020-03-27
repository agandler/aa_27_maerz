using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex. I.
            string[] names = new string[3];
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.Write("Name: ");
                    names[i] = Console.ReadLine();
                }
            }
            catch (IndexOutOfRangeException e)
            {
               Console.WriteLine(e.Message);
            }

            //ex. II.
            try
            {
                int num1 = 10;
                Console.WriteLine("number 1: {0} ",num1);
                int num2 = 0;
                Console.WriteLine("number 2 : {0}",num2);
          
                Console.WriteLine(num1 / num2);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            //ex III.
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                int addend = Convert.ToInt32(Console.ReadLine());

                if (addend == 10)
                {
                    throw new Exception("Sorry the addition is not possible");
                }

                int sum = num + addend;

                Console.WriteLine("Result: {0}", sum);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
