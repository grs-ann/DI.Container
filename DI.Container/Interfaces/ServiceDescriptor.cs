namespace DI.Container.Interfaces
{
    public enum Lifetime
    {
        Transient,
        Scoped,
        Singleton
    }

    public abstract class ServiceDescriptor
    {
        public Type ServiceType { get; init; }

        public Type ImplementationType { get; init; }

        public Lifetime Lifetime { get; init; }
    }
}
