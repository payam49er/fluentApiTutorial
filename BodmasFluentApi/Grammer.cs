namespace BodmasFluentApi
{
    public class Grammer:IBracketOperation,IAddValue,ISubtractValue,IMultiplyValue,IDivideValue
    {
        IAddValue IBracketOperation.Add()
        {
            throw new System.NotImplementedException();
        }

        ISubtractValue IBracketOperation.Subtract()
        {
            throw new System.NotImplementedException();
        }

        IMultiplyValue IBracketOperation.Multiply()
        {
            throw new System.NotImplementedException();
        }

        IDivideValue IBracketOperation.Div()
        {
            throw new System.NotImplementedException();
        }

        IBracketOperation IAddValue.Add()
        {
            throw new System.NotImplementedException();
        }

        IBracketOperation ISubtractValue.Subtract()
        {
            throw new System.NotImplementedException();
        }

        IBracketOperation IMultiplyValue.Multiply()
        {
            throw new System.NotImplementedException();
        }

        IBracketOperation IDivideValue.Div()
        {
            throw new System.NotImplementedException();
        }

        public int Execute()
        {
            
        }
    }
}