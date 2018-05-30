using System.Text;

namespace BodmasFluentApi
{
    public class Grammer:IMultiplyOrDivide,IAddOrSubtract
    {
	    private static StringBuilder _formula = new StringBuilder();


	    public string Formula => _formula.ToString();

        public IAddOrSubtract Add(int integer, int value)
        {
	        _formula.Append($"{integer}+{value}");
	        return this;
        }

	    public IAddOrSubtract Add(int value)
	    {
		    _formula.Append($"+{value}");
		    return this;
		}

	    public IAddOrSubtract Subtract(int integer, int value)
	    {
		    _formula.Append($"{integer}-{value}");
		    return this;
	    }

        public IAddOrSubtract Subtract(int value)
        {
	        _formula.Append($"-{value}");
	        return this;
        }

        public IMultiplyOrDivide Multiply(int integer, int value)
        {
	        _formula.Append($"{integer}*{value}");
            return this;
        }

	    public IMultiplyOrDivide Multiply(int value)
	    {
		    _formula.Append($"*{value}");
		    return this;
	    }

	    public IMultiplyOrDivide Divide(int integer, int value)
	    {
		    _formula.Append($"{integer}/{value}");
		    return this;
	    }

        public IMultiplyOrDivide Divide(int value)
        {
	        _formula.Append($"/{value}");
            return this;
        }

//        public IMultiplyOrDivide Bracket(IBracket value)
//        {
//            throw new System.NotImplementedException();
//        }
    }
}