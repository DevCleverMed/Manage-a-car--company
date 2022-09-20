namespace Controle2
{
    partial class Lignes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelcode_ligne = new System.Windows.Forms.Label();
            this.labeldistance = new System.Windows.Forms.Label();
            this.labelville_depart = new System.Windows.Forms.Label();
            this.labelville_arrivee = new System.Windows.Forms.Label();
            this.textBoxDis = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.comboBoxC_v_a = new System.Windows.Forms.ComboBox();
            this.comboBoxC_v_d = new System.Windows.Forms.ComboBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcode_ligne
            // 
            this.labelcode_ligne.AutoSize = true;
            this.labelcode_ligne.Location = new System.Drawing.Point(49, 81);
            this.labelcode_ligne.Name = "labelcode_ligne";
            this.labelcode_ligne.Size = new System.Drawing.Size(86, 20);
            this.labelcode_ligne.TabIndex = 0;
            this.labelcode_ligne.Text = "code_ligne";
            // 
            // labeldistance
            // 
            this.labeldistance.AutoSize = true;
            this.labeldistance.Location = new System.Drawing.Point(49, 152);
            this.labeldistance.Name = "labeldistance";
            this.labeldistance.Size = new System.Drawing.Size(69, 20);
            this.labeldistance.TabIndex = 1;
            this.labeldistance.Text = "distance";
            // 
            // labelville_depart
            // 
            this.labelville_depart.AutoSize = true;
            this.labelville_depart.Location = new System.Drawing.Point(49, 215);
            this.labelville_depart.Name = "labelville_depart";
            this.labelville_depart.Size = new System.Drawing.Size(84, 20);
            this.labelville_depart.TabIndex = 2;
            this.labelville_depart.Text = "ville depart";
            // 
            // labelville_arrivee
            // 
            this.labelville_arrivee.AutoSize = true;
            this.labelville_arrivee.Location = new System.Drawing.Point(49, 278);
            this.labelville_arrivee.Name = "labelville_arrivee";
            this.labelville_arrivee.Size = new System.Drawing.Size(85, 20);
            this.labelville_arrivee.TabIndex = 3;
            this.labelville_arrivee.Text = "ville arrivee";
            // 
            // textBoxDis
            // 
            this.textBoxDis.Location = new System.Drawing.Point(235, 161);
            this.textBoxDis.Name = "textBoxDis";
            this.textBoxDis.Size = new System.Drawing.Size(251, 26);
            this.textBoxDis.TabIndex = 4;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(235, 81);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(251, 26);
            this.textBoxCode.TabIndex = 5;
            // 
            // comboBoxC_v_a
            // 
            this.comboBoxC_v_a.FormattingEnabled = true;
            this.comboBoxC_v_a.Location = new System.Drawing.Point(235, 270);
            this.comboBoxC_v_a.Name = "comboBoxC_v_a";
            this.comboBoxC_v_a.Size = new System.Drawing.Size(251, 28);
            this.comboBoxC_v_a.TabIndex = 6;
            // 
            // comboBoxC_v_d
            // 
            this.comboBoxC_v_d.FormattingEnabled = true;
            this.comboBoxC_v_d.Location = new System.Drawing.Point(235, 215);
            this.comboBoxC_v_d.Name = "comboBoxC_v_d";
            this.comboBoxC_v_d.Size = new System.Drawing.Size(251, 28);
            this.comboBoxC_v_d.TabIndex = 7;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(741, 81);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(156, 53);
            this.buttonRechercher.TabIndex = 8;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(616, 161);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(162, 45);
            this.buttonAjouter.TabIndex = 9;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(832, 161);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(144, 45);
            this.buttonEnregistrer.TabIndex = 10;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Lignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.comboBoxC_v_d);
            this.Controls.Add(this.comboBoxC_v_a);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxDis);
            this.Controls.Add(this.labelville_arrivee);
            this.Controls.Add(this.labelville_depart);
            this.Controls.Add(this.labeldistance);
            this.Controls.Add(this.labelcode_ligne);
            this.Name = "Lignes";
            this.Text = "Lignes";
            this.Load += new System.EventHandler(this.Lignes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcode_ligne;
        private System.Windows.Forms.Label labeldistance;
        private System.Windows.Forms.Label labelville_depart;
        private System.Windows.Forms.Label labelville_arrivee;
        private System.Windows.Forms.TextBox textBoxDis;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.ComboBox comboBoxC_v_a;
        private System.Windows.Forms.ComboBox comboBoxC_v_d;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}