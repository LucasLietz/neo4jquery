using Neo4JDemo.Interfaces;

namespace Neo4JDemo.Entities
{
    public class Person : IPerson
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}