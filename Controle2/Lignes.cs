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
    public partial class Lignes : Form
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=YES; initial catalog=ASTN; integrated security=true");
        private DataSet ds = new DataSet();



        public Lignes()
        {
            InitializeComponent();
        }

        private void Lignes_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ligne", cn);

            da.Fill(ds, "Ligne");
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables["Ligne"];
            remp_como1();
            remp_como2();
            cn.Close();
        }
        private int Existe(int cin)
        {
            int c = -1;
            for (int i = 0; i < ds.Tables["Ligne"].Rows.Count; i++)
            {
                if (ds.Tables["Ligne"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (cin == int.Parse( ds.Tables["Ligne"].Rows[i][0].ToString()))
                    {
                        c = i;
                        break;
                    }
                }
            }
            return c;
        }
        public void remp_como1()

        {
            comboBoxC_v_d.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ville", cn);
            comboBoxC_v_d.Items.Clear();
            da.Fill(ds, "nom_ville");
            comboBoxC_v_d.DataSource = ds.Tables["nom_ville"];
            comboBoxC_v_d.DisplayMember = "nom_ville";
            comboBoxC_v_d.ValueMember = "code_ville";
        }
        public void remp_como2()

        {
            comboBoxC_v_a.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ville", cn);
            comboBoxC_v_a.Items.Clear();
            da.Fill(ds, "nom_ville");
            comboBoxC_v_a.DataSource = ds.Tables["nom_ville"];
            comboBoxC_v_a.DisplayMember = "nom_ville";
            comboBoxC_v_a.ValueMember = "code_ville";
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "" || textBoxDis.Text == "")
            {
                MessageBox.Show("Remplir tous les champs s'il vous plait !");
            }
            else
            {

                int indice = Existe(int.Parse( textBoxCode.Text));
                if (indice == -1)
                {
                    DataRow ligne;
                    ligne = ds.Tables["Ligne"].NewRow();
                    ligne[0] = textBoxCode.Text;
                    ligne[1] = textBoxDis.Text;
                    ligne[2] = comboBoxC_v_d.SelectedValue;
                    ligne[3] = comboBoxC_v_a.SelectedValue;
                    ds.Tables["Ligne"].Rows.Add(ligne);
                    //vider();
                }
                else MessageBox.Show("Existe déja");
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {

                MessageBox.Show("indique code ");
            }
            else
            {
                int t = Existe(int.Parse(textBoxCode.Text));
                if (t == -1)
                {
                    MessageBox.Show("aucune enregistrement");

                }
                else
                {
                    textBoxDis.Text = ds.Tables["Ligne"].Rows[t][1].ToString();
                    comboBoxC_v_d.SelectedValue = ds.Tables["Ligne"].Rows[t][2].ToString();
                    comboBoxC_v_d.SelectedValue = ds.Tables["Ligne"].Rows[t][2].ToString();


                }
            }
        }
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Ligne", cn);
            SqlCommandBuilder eng = new SqlCommandBuilder(ad);
            ad.Fill(ds, "Ligne");
            cn.Close();
        }
    }
}


        
    

