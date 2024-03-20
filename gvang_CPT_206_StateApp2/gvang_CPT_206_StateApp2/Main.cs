//Gong_Vang
//CPT_206
//Main Form - opens up to view and sort form. data sure load and user can sort, search, etc...
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
    
    public partial class Main : Form
    {

        SqlConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C: \Users\gong_\Desktop\2024SP - CPT 206 - A80S - Adv Event - Driven Program\gvang_CPT_206_StateApp2\StateDBConnectionLibrary\50statesDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Main()
        {
            InitializeComponent();
        }

  
        //Close out program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Open Sort FORM; user will be able to view, search, filter, update and sort
        private void btnSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.ShowDialog();
        }
        //Open view FORM;upload and view all 50 States + info
        private void btnView_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.ShowDialog();
        }
    }
}
