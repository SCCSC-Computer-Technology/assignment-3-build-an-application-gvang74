using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gvang_CPT_206_State_Database_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Exacel Workbook|*.xlsx", Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach ( var row in rows )
                        {
                            if ( isFirstRow )
                            {
                                foreach(IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;

                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                            dataGridView.DataSource = dt.DefaultView;
                            Cursor.Current = Cursors.WaitCursor;
                        }
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = txtSearch.Text;
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void txtSea(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)35)
                btn_Search.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
