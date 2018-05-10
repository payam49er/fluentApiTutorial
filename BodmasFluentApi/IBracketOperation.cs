namespace BodmasFluentApi
{
    public interface IBracketOperation
    {
        IAddValue Add();
        ISubtractValue Subtract();
        IMultiplyValue Multiply();
        IDivideValue Div();
        int Execute();
    }

    public interface ISubtractValue
    {
        IBracketOperation Subtract();
    }

    public interface IAddValue
    {
        IBracketOperation Add();
    }

    public interface IMultiplyValue
    {
        IBracketOperation Multiply();
    }

    public interface IDivideValue
    {
        IBracketOperation Div();
    }
}