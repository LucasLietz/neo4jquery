using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using Neo4jClient;
using Neo4JDemo.Entities;

namespace Neo4JDemo
{
    public partial class Default : Page
    {
        private String MoviesOfAnActor = "Movies of an actor";
        private String ActorsOfAMovie = "Actors of a movie";
        private Neo _neo;

        protected void Page_Load(object sender, EventArgs e)
        {}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 2)
            {
                if(Hinweis.Visible) Hinweis.Visible = false;

                IEnumerable<Person> persons;
                IEnumerable<Movie> movies;

                //TODO - 
                var neo = new Neo(new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "rhd16"));

                if (Equals(RadioButtonList1.SelectedItem, RadioButtonList1.Items.FindByText(ActorsOfAMovie)))
                {
                    persons = neo.GetActorsBy(TextBox1.Text);

                    if (resultList.Items.Count > 0) resultList.Items.Clear();

                    foreach (var person in persons)
                    {
                        resultList.Items.Add(person.name);
                    }
                }
                else if(Equals(RadioButtonList1.SelectedItem, RadioButtonList1.Items.FindByText(MoviesOfAnActor)))
                {
                    movies = neo.GetMovieBy(TextBox1.Text);

                    if (resultList.Items.Count > 0) resultList.Items.Clear();
                 
                    foreach (var movie in movies)
                    {
                        resultList.Items.Add(movie.title);
                    }
                }
                else
                {
                    throw new Exception("Query not specified");
                }
            }
            else
            {
                Hinweis.Visible = true;
                Hinweis.ForeColor = Color.Red;
            }
        }
    }
}