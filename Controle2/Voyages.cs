using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Controle2
{
    public partial class Voyages : Form
    {

        private SqlConnection cn = new SqlConnection(@"Data Source=YES; initial catalog=ASTN; integrated security=true");
        private DataSet ds = new DataSet();

        public Voyages()

        {
            InitializeComponent();
        }
        private void Rapport_TXT(DataGridView dg)
        {
            using (TextWriter tw = new StreamWriter(@"C:\Users\TOSHIBA\source\repos\Controle2\jamal.Txt"))
            {
                for (int i = 0; i < dg.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        tw.Write($"{dg.Rows[i].Cells[j].Value.ToString()}");

                        if (!(j == dg.Columns.Count - 1))
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }

        }
        private void Rapport_XML(DataSet ds)
        {
            if (ds == null) { return; }
            // Create a file name to write to.
            string filename = @"C:\Users\TOSHIBA\source\repos\Controle2\jamal.xml";
            FileStream streamWrite = new FileStream(filename, FileMode.Create);

            // Write to the file with the WriteXml method.
            ds.WriteXml(streamWrite);
            streamWrite.Close();
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt1 = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt1.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt1.Rows.Add(cellValues);
            }

            return dt1;
        }
        private void Voyages_Load(object sender, EventArgs e)
        {
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Voyage", cn);

            da.Fill(ds, "Voyage");

            da = new SqlDataAdapter("select * from Personnel", cn);

            da.Fill(ds, "Personnel");

            comboBox1.DataSource = ds.Tables["Personnel"];
            comboBox1.ValueMember = "Matricule";
            comboBox1.DisplayMember = "Nom";
            comboBox1.SelectedIndex = -1; // pour rien selectionner au départ

            cn.Close();
        }
        public void remp_como()

        {
            comboBox1.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from Personnel", cn);
            comboBox1.Items.Clear();
            da.Fill(ds, "Nom");
            comboBox1.DataSource = ds.Tables["Nom"];
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Nom";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idM_selected_index = comboBox1.SelectedIndex;

            if (idM_selected_index == -1) dataGridView1.DataSource = null;

            else
            {

                string idM_Selected = comboBox1.SelectedValue.ToString();

                DataTable copy = ds.Tables["Voyage"].Copy();


                for (int i = 0; i < copy.Rows.Count; i++)
                {
                    if (copy.Rows[i].RowState != DataRowState.Deleted)
                    {

                        if (idM_Selected != ds.Tables["Voyage"].Rows[i][6].ToString())
                        {
                            copy.Rows[i].Delete();
                        }
                    }

                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = copy;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dT1 = GetDataTableFromDGV(dataGridView1);
            DataSet dS1 = new DataSet();
            dS1.Tables.Add(dT1);


            Rapport_XML(dS1);
            Rapport_TXT(dataGridView1);
        }
    }
}
