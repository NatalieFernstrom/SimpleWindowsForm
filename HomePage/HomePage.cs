using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
         
        }

        private void ShowMovies_Click(object sender, EventArgs e)
        {
            ShowMovie Form = new ShowMovie();
            Form.Show();
        }

        private void EditDatabase_Click(object sender, EventArgs e)
        {
            EditDatabas Form = new EditDatabas();
            Form.Show();
        }
    }
}
