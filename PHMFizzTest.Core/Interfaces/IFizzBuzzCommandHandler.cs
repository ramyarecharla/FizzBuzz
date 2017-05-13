namespace PHMFizzTest.Core.Interfaces
{
    public interface IFizzBuzzCommandHandler<in TType>
    {
        bool CanHandle(TType target);
        string Handle();
    }
}
