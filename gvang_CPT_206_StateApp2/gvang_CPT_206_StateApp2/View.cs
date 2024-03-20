//View FORM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gvang_CPT_206_StateApp2
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }
        /// <summary>
        /// upload database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDBDataSet.States);

        }
        /// <summary>
        /// close form and return back to Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblReturn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.ShowDialog();
        }

        
    }
}
