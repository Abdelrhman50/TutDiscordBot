using System.Linq;
using TutDiscordBot.DataStorage;
using TutDiscordBot.DataStorage.Implementations;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace TutDiscordBot
{
    public static class Unity
    {
        private static UnityContainer _container;


        public static UnityContainer Container
        {
            get
            {
                if(_container == null)
                    RegisterType();
                return _container;
            }
        }

        public static void RegisterType()
        {
            _container= new UnityContainer();

            _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());

            _container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
        }

        public  static T Resolve<T>()
        {
            return (T) Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
