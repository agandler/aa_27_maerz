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
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

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


           
            

            Console.ReadLine();
        }
    }
}
