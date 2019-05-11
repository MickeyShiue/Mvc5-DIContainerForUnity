using Mvc5_DIContainerForUnity.Service;
using System;

using Unity;
using Unity.AspNet.Mvc;

namespace Mvc5_DIContainerForUnity
{
    public static class UnityConfig
    {     
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });
    
        public static IUnityContainer Container => container.Value;
         
        public static void RegisterTypes(IUnityContainer container)
        {
            container
                .RegisterType<IMessageService, MessageService>(new PerRequestLifetimeManager());
        }
    }
}