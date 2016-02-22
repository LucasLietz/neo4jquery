using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Neo4JDemo.Startup))]
namespace Neo4JDemo
{
    public class Startup {
        public void Configuration(IAppBuilder app) {
            
        }
    }
}
