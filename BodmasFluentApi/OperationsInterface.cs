namespace BodmasFluentApi
{
    public interface IAddOrSubtract
    {
	    IAddOrSubtract Subtract(int integer, int value);
        IAddOrSubtract Subtract(int value);
        IAddOrSubtract Add(int integer, int value);
	    IAddOrSubtract Add(int value);
    }

	public interface IMultiplyOrDivide
	{
		IMultiplyOrDivide Multiply(int integer, int value);
		IMultiplyOrDivide Multiply(int value);
		IMultiplyOrDivide Divide(int integer, int value);
		IMultiplyOrDivide Divide(int value);
		IAddOrSubtract Add(int integer, int value);
		IAddOrSubtract Add(int value);
		IAddOrSubtract Subtract(int integer, int value);
		IAddOrSubtract Subtract(int value);
	}
}