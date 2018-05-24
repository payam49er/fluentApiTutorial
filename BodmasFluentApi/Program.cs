using System;

namespace BodmasFluentApi
{
    class Program
    {
        static void Main(string[] args)
        {


            var formula = 4.Multiply(3).Add(3);

            int executedValue = BodMas.Execute(formula);
            string stFormula = BodMas.ToString(formula);

        }
    }
}