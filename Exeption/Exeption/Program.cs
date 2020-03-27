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
            //Üb 1
            string[] names = new string[3];
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Name: ");
                    names[i] = Console.ReadLine();
                }
            }
            catch (IndexOutOfRangeException e)
            {
               Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
