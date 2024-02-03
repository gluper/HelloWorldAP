using _3S.CoDeSys.Core;
using _3S.CoDeSys.Core.ComponentModel;
using System;

namespace HelloWorld
{
    static class APEnvironment
    {
        private static Lazy<DependencyBag> s_bag = new Lazy<DependencyBag>(() => new DependencyBag());

        public static IEngine3 Engine
        {
            get { return s_bag.Value.EngineProvider.Value; }
        }

        // more access methods and properties...
    }

    class DependencyBag : IDependencyInjectable
    {
        public DependencyBag()
        {
            ComponentModel.Singleton.InjectDependencies(this, GetType());
        }

        public void InjectionComplete() { }

        [InjectSingleInstance(Shared = true)]
        public ISharedSingleInstanceProvider<IEngine3> EngineProvider { get; private set; }

        // more dependencies...
    }
}