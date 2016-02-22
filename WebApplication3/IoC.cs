using System.Reflection;
using Neo4jClient;
using Ninject;
using Ninject.Modules;

namespace Neo4JDemo
{
    public class IoC : NinjectModule
    {
        private static IKernel _kernel;

        public static IKernel IoCKernel
        {
            get
            {
                if (_kernel == null) InitializeIoC();
                return _kernel;
            }
        }

        public static void InitializeIoC()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetCallingAssembly());
        }

        public override void Load()
        {
            Bind<INeo>().To<Neo>();
            Bind<IGraphClient>().To<GraphClient>();
        }
    }
}