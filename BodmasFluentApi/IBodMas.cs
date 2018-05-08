namespace BodmasFluentApi
{
    public interface IBodMas
    {
        IBodMas Brakets(IBodMas value);
        IBodMas Add(IBodMas value);
        IBodMas Subtract(IBodMas value);
        IBodMas Divide(IBodMas value);
    }
}