using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinOefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(JoinedDatabaseEntities ctx= new JoinedDatabaseEntities())
            {
                string voornaam = "";
                if (textBox1.Text.Trim() != "")
                {
                    voornaam = textBox1.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een Voornaam a.u.b");
                }
                string achternaam = "";
                if (textBox2.Text.Trim() != "")
                {
                    achternaam = textBox2.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een Achternaam a.u.b");
                }
                
                int leeftijd;
                leeftijd = (int)numericUpDown1.Value;
                
                ctx.Persoons.Add(new Persoon() { Voornaam = voornaam, Achternaam = achternaam, Leeftijd = leeftijd });
                ctx.SaveChanges();
                MessageBox.Show("Persoon Toevoegd");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                var query = ctx.Persoons.Select(x => x);
        BindingList<Persoon> listItems = new BindingList<Persoon>();
                cbpersonen.DisplayMember = "Voornaam";
                cbpersonen.ValueMember = "PersoonID";
        foreach (var item in query)
                {
                    Persoon persoon = new Persoon()
                    {
                        PersoonID = item.PersoonID,
                        Voornaam = item.Voornaam,
                    };
            listItems.Add(persoon);
                }
                cbpersonen.DataSource = listItems;
            }

        }

        private void cbpersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblId.Text = cbpersonen.SelectedValue.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(cbpersonen.SelectedValue);
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                ctx.Persoons.Where(p => p.PersoonID == value).FirstOrDefault().Voornaam = "Joske";
                ctx.SaveChanges();
            }

        }
    }
}
