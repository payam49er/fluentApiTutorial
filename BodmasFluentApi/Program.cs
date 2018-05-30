using System;

namespace BodmasFluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
	        var formula = 4.Multiply(3).Add(3).Subtract(2) as Grammer;

			BodMas bMas = new BodMas();
			string executedValue = bMas.Execute(formula.Formula);

			Console.WriteLine($"Calculated value is: {executedValue}");

			string stFormula = bMas.ToString(formula);

			Console.WriteLine($"Formula is: {stFormula}");

			Console.Read();

        } 
    }
}