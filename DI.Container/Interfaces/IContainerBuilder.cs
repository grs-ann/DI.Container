namespace DI.Container.Interfaces
{
    public interface IContainerBuilder
    {
        void Register(ServiceDescriptor descriptor);

        IContainer Build();
    }
}
