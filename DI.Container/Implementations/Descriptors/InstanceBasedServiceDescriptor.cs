using DI.Container.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Container.Implementations.Descriptors
{
    public class InstanceBasedServiceDescriptor : ServiceDescriptor
    {
        public object Instance { get; init; }

        public InstanceBasedServiceDescriptor(Type serviceType, object instance)
        {
            Lifetime = Lifetime.Singleton;
            ServiceType = serviceType;
            Instance = instance;
        }
    }
}
