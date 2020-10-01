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
    public partial class EditPerson : Form
    {
        public EditPerson()
        {
            InitializeComponent();
        }
        public Persoon mijnpersoon;
        private void btnsave_Click(object sender, EventArgs e)
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
                ctx.Persoons.Where(p => p.PersoonID == mijnpersoon.PersoonID).FirstOrDefault().Voornaam = voornaam;
                ctx.Persoons.Where(p => p.PersoonID == mijnpersoon.PersoonID).FirstOrDefault().Achternaam = achternaam;
                ctx.Persoons.Where(p => p.PersoonID == mijnpersoon.PersoonID).FirstOrDefault().Leeftijd = leeftijd;
                ctx.SaveChanges();
                foreach (var item in listBox1.SelectedItems)
                {

                    ctx.PersoonBadges.Where(p => p.PersoonID == mijnpersoon.PersoonID).FirstOrDefault(). BadgeID = (item as Badge).BadgeID;
                    ctx.SaveChanges();
                }
                ctx.SaveChanges();
                MessageBox.Show("Badge Toevoegd");
                MessageBox.Show("Persoon Bewerk is gedaan");
            }
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            textBox1.Text = mijnpersoon.Voornaam;
            textBox2.Text = mijnpersoon.Achternaam;
            numericUpDown1.Value = (int)mijnpersoon.Leeftijd;
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                var query = ctx.Badges.Join(ctx.PersoonBadges,
                    b => b.BadgeID,
                    pb => pb.BadgeID,
                    (b, pb) => new { b, pb, Opschrift = b.Opschrift }
                    );

                lbopschrift.DisplayMember = "Opschrift";
               lbopschrift.DataSource = query.Where(x => x.pb.PersoonID == mijnpersoon.PersoonID).ToList();
                var Query1= ctx.Badges.Select(g => g).ToList();
                listBox1.DisplayMember = "Opschrift";
                listBox1.DataSource = Query1;
            }
            

        }
    }
}
