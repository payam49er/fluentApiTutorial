using System;

namespace BodmasFluentApi
{
    public static class Extension
    {
        private static Grammer _grammer = new Grammer();
        public static IAddOrSubtract Add(this int integer, int value)
        {
            return _grammer.Add(integer,value);
        }

	    public static IAddOrSubtract Add(this int value)
	    {
		    return _grammer.Add(value);
	    }

	    public static IAddOrSubtract Subtract(this int integer, int value)
        {
            return _grammer.Subtract(integer, value);
        }

	    public static IAddOrSubtract Subtract(this int value)
	    {
		    return _grammer.Subtract(value);
	    }

        public static IMultiplyOrDivide Multiply(this int integer, int value)
        {
            return _grammer.Multiply(integer,value);
        }

	    public static IMultiplyOrDivide Multiply(this int value)
	    {
		    return _grammer.Multiply(value);
	    }

	    public static IMultiplyOrDivide Divide(this int value)
	    {
		    return _grammer.Divide(value);
	    }

        public static IMultiplyOrDivide Divide(this int integer, int value)
        {
            return _grammer.Divide(integer, value);
        }
    }
}