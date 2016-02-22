using System.Collections.Generic;
using Neo4JDemo.Entities;

namespace Neo4JDemo
{
    public interface INeo
    {
        IEnumerable<Person> GetActorsBy(string movieTitle);
        IEnumerable<Movie> GetMovieBy(string actorsName);
    }
}