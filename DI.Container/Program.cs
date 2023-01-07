using DI.Container.Interfaces;



class ContainerBuilder : IContainerBuilder
{
    public IContainer Build()
    {
        throw new NotImplementedException();
    }

    public void Register(ServiceDescriptor descriptor)
    {
        throw new NotImplementedException();
    }
}

class Container
{

}

class Registration
{
    /*public Container ConfigureServices()
    {
        var builder = new ContainerBuilder();
        builder.RegisterTransient<IService, Service>();
        builder.RegisterScoped<Controller, Controller>();

        return builder.Build();
    }*/
}


class Controller
{
    private readonly IService _service;

    public Controller(IService service)
	{
        _service = service;
    }

    public void Do() { }
}

interface IService
{

}

class Service : IService
{

}