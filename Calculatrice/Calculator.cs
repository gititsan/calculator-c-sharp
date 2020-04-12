using System;

namespace Calculatrice
{
    internal class Calculator
    {
        double result;
        internal double Calculer(double input1, double input2, string op)
        {

           
                switch (op)
                {
                    case "+":
                    case "add":
                      return  result = input1 + input2;
                        break;

                    case "-":
                    case "soustraction":
                        return result = input1 - input2;
                        break;

                    case "/":
                    case "division":
                        return result = input1 / input2;
                        break;

                    case "*":
                    case "multiplication":
                        return result = input1 * input2;

                        break;

                    default:
                        throw new ArgumentNullException("L'opérateur n'est pas correcte");
                        break;

                }
               
                
                
            
            



           
        }
    }
}