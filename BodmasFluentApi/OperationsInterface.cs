namespace BodmasFluentApi
{
    public interface IAddOrSubtract
    {
        IAddOrSubtract Subtract(int value);
        IAddOrSubtract Add(int value);
    }

    public interface IMultiplyOrDivide
    {
        IMultiplyOrDivide Multiply(int value);
        IMultiplyOrDivide Divide(int value);
        IAddOrSubtract Add(int value);
        IAddOrSubtract Subtract(int value);
    }

  
//    public interface IBracket
//    {
//        IMultiplyOrDivide Bracket(IBracket value);
//       
//    }
}