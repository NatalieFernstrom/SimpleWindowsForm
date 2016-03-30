using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace HomePage
{
    public partial class Movies : Form
    {
        private MinDataBasEntities context;
        public Movies()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MinDataBasEntities();
            context.Film.Load();
            context.Skadespelare.Load();
            context.Kategori.Load();
            this.filmBindingSource1.DataSource = context.Film.Local.ToBindingList();
            this.skadespelareBindingSource1.DataSource = context.Skadespelare.Local.ToBindingList();
            this.kategoriBindingSource1.DataSource = context.Kategori.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context.SaveChanges();//Autosaving data before closing
            this.context.Dispose();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            this.context.SaveChanges();
            //this.filmBindingSource.DataSource = context.Film.Local.ToList();
            //this.skadespelareBindingSource.DataSource = context.Skadespelare.Local.ToList();
            //this.kategoriBindingSource.DataSource = context.Kategori.Local.ToList();

        }

    }
}
