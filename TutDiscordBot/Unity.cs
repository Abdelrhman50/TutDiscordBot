using System.Linq;
using Discord.WebSocket;
using TutDiscordBot.DataStorage;
using TutDiscordBot.DataStorage.Implementations;
using TutDiscordBot.Discord;
using Unity;
using Unity.Injection;
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

            _container.RegisterSingleton<IDataStorage, InMemoryStorage>();

            _container.RegisterSingleton<ILogger, Logger>();

            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefualt()));

            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));

            _container.RegisterSingleton<Connection>();
            
        }

        public  static T Resolve<T>()
        {
            return (T) Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
