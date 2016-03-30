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
    public partial class EditDatabas : Form
    {
        public EditDatabas()
        {
            InitializeComponent();
        }

        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.minDataBasDataSet);

        }

        private void EditDatabas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minDataBasDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.minDataBasDataSet.Film);
            // TODO: This line of code loads data into the 'minDataBasDataSet.Skadespelare' table. You can move, or remove it, as needed.
            this.skadespelareTableAdapter.Fill(this.minDataBasDataSet.Skadespelare);
            // TODO: This line of code loads data into the 'minDataBasDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.minDataBasDataSet.Kategori);
            // TODO: This line of code loads data into the 'minDataBasDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.minDataBasDataSet.Film);

        }
    }
}
