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
    public partial class example : Form
    {
        public example()
        {
            InitializeComponent();
        }

        private void example_Load(object sender, EventArgs e)
        {
            //using (JoinedDatabaseEntities ctx = new JoinedDatabaseEntities())
            //{
            /*Heel verkorte versie, met dank aan Benjamin :-)*/
            //var query = ctx.Persoons.Select(x => x).ToList();
            //cbpersonen.DisplayMember = "Voornaam";
            //cbpersonen.ValueMember = "Id";
            //cbpersonen.DataSource = query;
            //var query = ctx.Persoons.Select(x => new { Naam = x.Voornaam + " " + x.Achternaam, Id = x.PersoonID }).ToList();
            //    var query = ctx.Persoons.Select(x => x);
            //    BindingList<Persoon> listItems = new BindingList<Persoon>();
            //    cbpersonen.DisplayMember = "Voornaam";
            //    cbpersonen.ValueMember = "PersoonID";
            //    foreach (var item in query)
            //    {
            //        Persoon persoon = new Persoon()
            //        {
            //            PersoonID = item.PersoonID,
            //            Voornaam = item.Voornaam,
            //        };
            //        listItems.Add(persoon);
            //    }
            //    cbpersonen.DataSource = listItems;
            //}
        }
        private void cbpersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblId.Text = cbpersonen.SelectedValue.ToString();
            //  var selectedpersoon = cbpersonen.SelectedItem as Persoon;
            //  textBox1.Text = selectedpersoon.Voornaam;
            //  textBox2.Text = selectedpersoon.Achternaam;
            //numericUpDown1.Value =Convert.ToInt32( selectedpersoon.Leeftijd);


        }
    }
}
