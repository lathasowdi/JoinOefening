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
    public partial class ViewBadge : Form
    {
        public ViewBadge()
        {
            InitializeComponent();
        }
        public Persoon selectedPersoon;
        private void ViewBadge_Load(object sender, EventArgs e)
        {
            
                textBox1.Text = selectedPersoon.Voornaam + " " + selectedPersoon.Achternaam;
                FillListBox();
           
        }
        private void FillListBox()
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                var query = ctx.Badges.Join(ctx.PersoonBadges,
                    b => b.BadgeID,
                    pb => pb.BadgeID,
                    (b, pb) => new { b, pb, Opschrift = b.Opschrift }
                    );

                listBox1.DisplayMember = "Opschrift";
                listBox1.DataSource = query.Where(x => x.pb.PersoonID == selectedPersoon.PersoonID).ToList();
            }
        }
    }
}
