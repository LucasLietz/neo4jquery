using System.Collections.Generic;
using Neo4jClient;
using Neo4JDemo.Entities;
using Ninject;

namespace Neo4JDemo
{
    public class Neo : INeo
    {
        private GraphClient _graphClient;

        public Neo(GraphClient graphClient)
        {
            //TODO IOC
            //_graphClient = IoC.IoCKernel.Get<IGraphClient>();
            _graphClient = graphClient;
            _graphClient.Connect();
        }

        //public Neo(IGraphClient graphClient)
        //{
        //    _graphClient = graphClient;
        //    _graphClient.Connect();
        //}

        public IEnumerable<Person> GetActorsBy(string movieTitle)
        {
            var results = _graphClient.Cypher
                .Match("(m:Movie)<-[:ACTED_IN]-(p:Person)")
                .Where((Movie m) => m.title == movieTitle)
                .Return(p => p.As<Person>())
                .Results;
            return results;
        }

        public IEnumerable<Movie> GetMovieBy(string actorsName)
        {
            var results = _graphClient.Cypher
                .Match("(m:Movie)<-[:ACTED_IN]-(p:Person)")
                .Where((Person p) => p.name == actorsName)
                .Return(m => m.As<Movie>())
                .Results;
            return results;
        }
    }
}