using System;

namespace BodmasFluentApi
{
    public static class Extension
    {
        public static IAddValue Add(this int integer, int value)
        {
            return new Grammer();
        }
        public static IAddValue Add(this int integer,int intVal = 0, IBracketOperation value=null)
        {
            return new Grammer();
        }
        
        public static IAddValue Add(this int integer, IBracketOperation value=null)
        {
            return new Grammer();
        }
        
        public static ISubtractValue Subtract(this int integer,IBracketOperation value=null)
        {
            return new Grammer();
        }

        public static IMultiplyValue Multiply(this int integer,IBracketOperation value=null)
        {
            return new Grammer();
        }

        public static IDivideValue Divide(this int integer,IBracketOperation value=null)
        {
            return new Grammer();
        }
            
    }
}