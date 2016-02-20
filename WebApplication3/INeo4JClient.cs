using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Neo4jClient;

namespace WebApplication3
{
    public interface INeo4JClient
    {
        GraphClient GetClient();
    }
}