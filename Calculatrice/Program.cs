using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of classes used 
            User user = new User();
            Calculator calc = new Calculator();
            double result;

         try
            {
                double input1 = user.inputConverter(Console.ReadLine());
                double input2 = user.inputConverter(Console.ReadLine());
                string op = user.operationConverter(Console.ReadLine());


                result = calc.Calculer(input1, input2, op);
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
               

                Console.ReadKey();
            }
            
           

            

        }
    }
}
