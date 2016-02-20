using System.Collections.Generic;
using Neo4jClient;
using Neo4JDemo.Entities;

namespace Neo4JDemo
{
    public class Neo : INeo4JClient
    {
        private IGraphClient _graphClient;

        public Neo(IGraphClient graphClient)
        {
            _graphClient = graphClient;
            _graphClient.Connect();
        }

        public IEnumerable<Person> GetActorsBy(string movieTitle)
        {
            var results = _graphClient.Cypher
                .Match("(m:Movie)<-[:ACTED_IN]-(p:Person)")
                .Where((Movie m) => m.title == movieTitle)
                .Return(p => p.As<Person>())
                .Results;
            return results;
        }
    }
}