using System;

namespace Calculatrice
{
    internal class User
    {
        string op;
        double input;
        internal double inputConverter(string v)
        {
            try
            {
                input = Convert.ToDouble(v);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return input;
             
        }

        internal string operationConverter(string v)
        {

            v= (v.ToLower());
           

           


            return v;
        }
    }
}