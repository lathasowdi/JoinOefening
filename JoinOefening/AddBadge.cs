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
    public partial class AddBadge : Form
    {
        public AddBadge()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            {
                string opschrift = "";
                if (textBox1.Text.Trim() != "")
                {
                    opschrift = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Geef een opschrift a.u.b");
                }
                ctx.Badges.Add(new Badge() { Opschrift = opschrift });
                ctx.SaveChanges();
                MessageBox.Show("Badge toegevoegd");
            }

        }
    }
}
