using System;
using System.Drawing;
using System.Web.UI;
using Neo4jClient;

namespace WebApplication3
{
    public partial class _Default : Page
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
                var neo = new Neo();
                var persons = neo.GetActorsBy(TextBox1.Text);
                foreach (var person in persons)
                {
                    Ergebnisse.Text += person.name;
                    Ergebnisse.Text += ", ";
                }
                
                Ergebnisse.Visible = true;

            }
            else
            {
                Hinweis.Visible = true;
                Hinweis.ForeColor = Color.Red;
            }
        }
    }
}