using Microsoft.Practices.Unity;
using Unity;
using NLog;

namespace VirtualInputController
{
    public class Bootstrapper
    {
        public readonly UnityContainer container;
        //IoC stuff goes here

        public Bootstrapper()
        {
            container = new UnityContainer();
        }

        public void ConfigureContainer()
        {

        }
    }
}
