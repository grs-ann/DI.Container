namespace DI.Container.Interfaces
{
    public interface IScope
    {
        object Resolve(Type type);
    }
}
