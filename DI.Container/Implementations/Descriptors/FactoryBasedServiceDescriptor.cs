using DI.Container.Interfaces;

namespace DI.Container.Implementations.Descriptors
{
    public class FactoryBasedServiceDescriptor : ServiceDescriptor
    {
        public Func<IScope, object> Factory { get; init; }
    }
}
