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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
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
                Persoon niewPersoon = new Persoon();
                niewPersoon.Voornaam = voornaam;
                niewPersoon.Achternaam = achternaam;
                niewPersoon.Leeftijd = leeftijd;
                ctx.Persoons.Add(niewPersoon);
                ctx.SaveChanges();
                MessageBox.Show("Persoon Toevoegd");
                foreach (var item in lbopschrift.SelectedItems)
                {

                    ctx.PersoonBadges.Add(new PersoonBadge() { PersoonID = niewPersoon.PersoonID, BadgeID = (item as Badge).BadgeID });
                    ctx.SaveChanges();
                }
                ctx.SaveChanges();
                MessageBox.Show("Badge Toevoegd");
            }
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                var query = ctx.Badges.Select(p => p).ToList();
                lbopschrift.DataSource = query;
                lbopschrift.DisplayMember = "Opschrift";
            }
        }
    }
}
