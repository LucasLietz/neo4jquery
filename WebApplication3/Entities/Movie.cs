using Neo4JDemo.Interfaces;

namespace Neo4JDemo.Entities
{
    public class Movie : IMovie
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}