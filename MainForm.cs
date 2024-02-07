using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gvang_CPT_206_State_Data_App_2
{
    
    public partial class MainForm : Form
    {
        
        
        public MainForm()
        {
            InitializeComponent();
       

        }

        private void statesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateReportsDataSet);

        }
        private System.Data.DataTable search1
        {
        
            {
                string query1 = "Select Stat Name From table1";
                query1 += ""
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            // TODO: This line of code loads data into the 'stateReportsDataSet.StatesTable' table. You can move, or remove it, as needed.
            //this.statesTableTableAdapter.Fill(this.stateReportsDataSet.StatesTable);



        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
