using System;
using System.Drawing;
using System.Web.UI;
using Neo4jClient;

namespace Neo4JDemo
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 2)
            {
                if(Hinweis.Visible) Hinweis.Visible = false;
                var neo = new Neo(new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "rhd16"));
                var persons = neo.GetActorsBy(TextBox1.Text);
                if (actorslist.Items.Count > 0) actorslist.Items.Clear();

                foreach (var person in persons)
                {
                    
                    actorslist.Items.Add(person.name);
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