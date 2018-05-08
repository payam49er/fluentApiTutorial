using System;

namespace BodmasFluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
            BodMas formula = 4.Add();
            BodMas.Execute(formula);
            BodMas.ToString(formula);
        }
    }
}