//Sort FORM
using StateDBConnectionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace gvang_CPT_206_StateApp2
{
    public partial class Sort : Form
    {
        SqlConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C: \Users\gong_\Desktop\2024SP - CPT 206 - A80S - Adv Event - Driven Program\gvang_CPT_206_StateApp2\StateDBConnectionLibrary\50statesDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Sort()
        {
            InitializeComponent();
            //statesDataGridView.DataSource = StatesDBConnection.GetAllStates();

        }
        /// <summary>
        /// upload data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void states_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }
        /// <summary>
        /// Search bottom. User can search by State Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stateName = txtSearch.Text;
            if(!string.IsNullOrEmpty(stateName))
            {
                statesDataGridView.DataSource = StatesDBConnection.StateName(stateName);
            }

        }
        

        //Close form and return to Main Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.ShowDialog();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDBDataSet.States);

        }
        /// <summary>
        /// Sort by State Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStateNameSort_Click(object sender, EventArgs e)
        {
            try
            {
                this.statesTableAdapter.FillByStateNameSort(this.statesDBDataSet.States);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Sort by State Capital
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStateCapitolSort_Click(object sender, EventArgs e)
        {
            try
            {
                this.statesTableAdapter.FillByStateCapital(this.statesDBDataSet.States);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Sort by State Population
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatePopulationSort_Click(object sender, EventArgs e)
        {
            try
            {
                this.statesTableAdapter.FillByStatePopulation(this.statesDBDataSet.States);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// able to go back and view all database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.statesDBDataSet.States);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// list of all 50 states; user can look-up info by selecting from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
