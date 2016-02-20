using System.Collections.Generic;
using Neo4JDemo.Entities;

namespace Neo4JDemo
{
    public interface INeo4JClient
    {
        IEnumerable<Person> GetActorsBy(string movieTitle);
    }
}