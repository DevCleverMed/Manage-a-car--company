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

namespace Controle2
{
    public partial class Autocars : Form
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=YES; initial catalog=ASTN; integrated security=true");
        private DataSet ds = new DataSet();
        int cpt;

        public Autocars()
        {
            InitializeComponent();
        }

        private void Autocars_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Autocar", cn);

            da.Fill(ds, "Autocar");
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables["Autocar"];
            //cn.Close();
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "Selection";
            dataGridView1.Columns.Add(col);
            textBoxCode.Text = ds.Tables["Autocar"].Rows[cpt][0].ToString();
            textBoxCapacite.Text = ds.Tables["Autocar"].Rows[cpt][1].ToString();
            dateTimePicker1.Text = ds.Tables["Autocar"].Rows[cpt][2].ToString();
            textBoxConsomation.Text = ds.Tables["Autocar"].Rows[cpt][3].ToString();
            comboBoxMarque.Text = ds.Tables["Autocar"].Rows[cpt][4].ToString();
            label1.Text = cpt + 1 + " sur " + ds.Tables["Autocar"].Rows.Count;
            remp_como();
            cn.Close();
        }
        private int Existe(String cin)
        {
            int c = -1;
            for (int i = 0; i < ds.Tables["Autocar"].Rows.Count; i++)
            {
                if (ds.Tables["Autocar"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (cin == ds.Tables["Autocar"].Rows[i][0].ToString())
                    {
                        c = i;
                        break;
                    }
                }
            }
            return c;
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {

            if (textBoxCode.Text == "" || textBoxCapacite.Text == "" || textBoxConsomation.Text == "")
            {
                MessageBox.Show("Remplir tous les champs s'il vous plait !");
            }
            else
            {

                int indice = Existe(textBoxCode.Text);
                if (indice == -1)
                {
                    DataRow ligne;
                    ligne = ds.Tables["Autocar"].NewRow();
                    ligne[0] = textBoxCode.Text;
                    ligne[1] = textBoxCapacite.Text;
                    ligne[2] = dateTimePicker1.Text;
                    ligne[3] = textBoxConsomation.Text;
                    ligne[4] = comboBoxMarque.Text;
                    ds.Tables["Autocar"].Rows.Add(ligne);
                    //vider();
                }
                else MessageBox.Show("Existe déja");
            }
        }
        public void remp_como()

        {
            comboBoxMarque.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from Autocar", cn);
            comboBoxMarque.Items.Clear();
            da.Fill(ds, "marque");
            comboBoxMarque.DataSource = ds.Tables["marque"];
            comboBoxMarque.DisplayMember = "nom_marque";
            comboBoxMarque.ValueMember = "nom_marque";
        }
        private void comboBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "" || textBoxCapacite.Text == "" || textBoxConsomation.Text == "")
            {
                MessageBox.Show("merci de remplire les champs");
                return;
            }
            bool tr = false;
            for (int i = 0; i < ds.Tables["autocar"].Rows.Count; i++)
            {
                if (textBoxCode.Text == ds.Tables["autocar"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["autocar"].Rows[i][1] = textBoxCapacite.Text;
                    ds.Tables["autocar"].Rows[i][2] = dateTimePicker1.Text;
                    ds.Tables["autocar"].Rows[i][1] = textBoxConsomation.Text;

                    MessageBox.Show("autocar modifier aves succes");
                    dataGridView1.DataSource = ds.Tables["autocar"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("autocar n existe  pas");

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                MessageBox.Show("merci pour remplir  le champ");
                return;

            }
            bool tr = false;
            for (int i = 0; i < ds.Tables["autocar"].Rows.Count; i++)
            {
                if (textBoxCode.Text == ds.Tables["autocar"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["autocar"].Rows[i].Delete();
                    MessageBox.Show("autocar suprimer deja");
                    dataGridView1.DataSource = ds.Tables["autocar"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("autocar n existe pas");
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from autocar", cn);
            SqlCommandBuilder eng = new SqlCommandBuilder(ad);
            ad.Fill(ds, "autocar");
            cn.Close();
        }
        public void navigation()
        {

            textBoxCode.Text = ds.Tables["autocar"].Rows[cpt][0].ToString();
            textBoxCapacite.Text = ds.Tables["autocar"].Rows[cpt][1].ToString();
            dateTimePicker1.Text = ds.Tables["autocar"].Rows[cpt][2].ToString();
            textBoxConsomation.Text = ds.Tables["autocar"].Rows[cpt][3].ToString();
            comboBoxMarque.Text = ds.Tables["autocar"].Rows[cpt][4].ToString();
            label1.Text = cpt + 1 + " sur " + ds.Tables["autocar"].Rows.Count;
        }

        private void btn_premier_Click(object sender, EventArgs e)
        {
            cpt = 0;
            navigation();
        }

        private void btn_prec_Click(object sender, EventArgs e)
        {

            try
            {
                cpt--;
                navigation();
            }
            catch
            {
                MessageBox.Show("vous etes sur le premier enregidtrment");
                cpt++;
            }
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            try
            {
                cpt++;
                navigation();
            }
            catch
            {
                MessageBox.Show("vous etes sur le dernier enregistrement");
                cpt--;
            }

        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            cpt = ds.Tables["autocar"].Rows.Count - 1;
            navigation();
        }
    }
    }
   
    