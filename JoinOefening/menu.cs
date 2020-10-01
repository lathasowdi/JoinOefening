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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public Persoon selectedPersoon;
        public Badge selectedBadge;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListbox();
        }
        private void FillListbox()
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
            var query = ctx.Persoons.Select(p => new { p, naam = p.Voornaam + " " + p.Achternaam }).ToList();
                lbpersoon.DataSource = query;
                lbpersoon.DisplayMember = "naam";
                lbpersoon.ValueMember = "p";
            }
        }

        private void btnnaarJoske_Click(object sender, EventArgs e)
        {
            var selectedPersoon = (Persoon)lbpersoon.SelectedValue;
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                ctx.Persoons.Where(p => p.PersoonID == selectedPersoon.PersoonID).FirstOrDefault().Voornaam = "Joske";
                ctx.SaveChanges();
            }
            MessageBox.Show("Name is changed");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                var joinQuery = ctx.Persoons.
                    Join(ctx.PersoonBadges,
                    p => p.PersoonID,
                    pb => pb.PersoonID,
                    (p, pb) => new { p, pb })
                    .Join(ctx.Badges,
                    pb2 => pb2.pb.BadgeID,
                    b => b.BadgeID,
                    (pb2, b) => new { pb2, b });

                var selectedpersoon = lbpersoon.SelectedValue as Persoon;

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ViewBadge oef = new ViewBadge();

            oef.selectedPersoon = (Persoon)lbpersoon.SelectedValue;

            if (oef.ShowDialog() == DialogResult.OK)
            {
                FillListbox();
            }
        }
       
        private void btnedit_Click(object sender, EventArgs e)
        {
            EditPerson editPerson = new EditPerson();
            var selectedPersoon = (Persoon)lbpersoon.SelectedItem;
            editPerson.mijnpersoon = selectedPersoon;
            if (editPerson.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
        private void btnviewbadge_Click(object sender, EventArgs e)
        {
            ViewBadge viewBadge = new ViewBadge();
            viewBadge.selectedPersoon = (Persoon)lbpersoon.SelectedValue;
            if (viewBadge.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnaddperson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
           if( addPerson.ShowDialog ()==DialogResult.OK)
            {

            }
            
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                int value = Convert.ToInt32(lbpersoon.SelectedValue);
                //var selectedPersoon = (Persoon)lbpersoon.SelectedItem;
                ctx.Persoons.RemoveRange(ctx.Persoons.Where(p => p.PersoonID == value));
                ctx.SaveChanges();
                ctx.PersoonBadges.RemoveRange(ctx.PersoonBadges.Where(p => p.PersoonID == value));
                ctx.SaveChanges();
                MessageBox.Show("Persoon  is verwijderen");
                

            }
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            EditPerson editPerson = new EditPerson();
            editPerson.mijnpersoon = (Persoon)lbpersoon.SelectedValue;
            if (editPerson.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddBadge addBadge = new AddBadge();
            if(addBadge.ShowDialog()==DialogResult.OK)
            {

            }
        }
    }
}
