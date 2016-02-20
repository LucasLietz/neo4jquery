using System;
using System.Collections.Generic;
using System.Web.Providers.Entities;
using Neo4jClient;
using WebApplication3.Entities;

namespace WebApplication3
{
    public class Neo : INeo4JClient
    {
        private GraphClient _client;
        public Neo()
        {
            _client = GetClient();

            _client.Connect();
        }

        public GraphClient GetClient()
        {
            return new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "rhd16");
        }

        public IEnumerable<Person> GetActorsBy(string movieTitle)
        {
            var results = _client.Cypher
                .Match("(m:Movie)<-[:ACTED_IN]-(p:Person)")
                .Where((Movie m) => m.title == movieTitle)
                .Return(p => p.As<Person>())
                .Results;
            return results;
        }
    }


}