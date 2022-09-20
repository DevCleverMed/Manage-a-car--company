namespace Controle2
{
    partial class Autocars
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
            this.labelCode = new System.Windows.Forms.Label();
            this.labelCapacite = new System.Windows.Forms.Label();
            this.labelDate_Achat = new System.Windows.Forms.Label();
            this.labelConsomation = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.textBoxCapacite = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxConsomation = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_prec = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(52, 48);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(47, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // labelCapacite
            // 
            this.labelCapacite.AutoSize = true;
            this.labelCapacite.Location = new System.Drawing.Point(52, 118);
            this.labelCapacite.Name = "labelCapacite";
            this.labelCapacite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCapacite.Size = new System.Drawing.Size(72, 20);
            this.labelCapacite.TabIndex = 1;
            this.labelCapacite.Text = "Capacite";
            // 
            // labelDate_Achat
            // 
            this.labelDate_Achat.AutoSize = true;
            this.labelDate_Achat.Location = new System.Drawing.Point(52, 174);
            this.labelDate_Achat.Name = "labelDate_Achat";
            this.labelDate_Achat.Size = new System.Drawing.Size(95, 20);
            this.labelDate_Achat.TabIndex = 2;
            this.labelDate_Achat.Text = "Date_Achat";
            // 
            // labelConsomation
            // 
            this.labelConsomation.AutoSize = true;
            this.labelConsomation.Location = new System.Drawing.Point(52, 234);
            this.labelConsomation.Name = "labelConsomation";
            this.labelConsomation.Size = new System.Drawing.Size(103, 20);
            this.labelConsomation.TabIndex = 3;
            this.labelConsomation.Text = "Consomation";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(52, 311);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(63, 20);
            this.labelMarque.TabIndex = 4;
            this.labelMarque.Text = "Marque";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(224, 303);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(220, 28);
            this.comboBoxMarque.TabIndex = 6;
            this.comboBoxMarque.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarque_SelectedIndexChanged);
            // 
            // textBoxCapacite
            // 
            this.textBoxCapacite.Location = new System.Drawing.Point(224, 118);
            this.textBoxCapacite.Name = "textBoxCapacite";
            this.textBoxCapacite.Size = new System.Drawing.Size(220, 26);
            this.textBoxCapacite.TabIndex = 7;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(224, 48);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(220, 26);
            this.textBoxCode.TabIndex = 8;
            // 
            // textBoxConsomation
            // 
            this.textBoxConsomation.Location = new System.Drawing.Point(224, 234);
            this.textBoxConsomation.Name = "textBoxConsomation";
            this.textBoxConsomation.Size = new System.Drawing.Size(220, 26);
            this.textBoxConsomation.TabIndex = 9;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(601, 63);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(148, 59);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(601, 212);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(164, 53);
            this.buttonSupprimer.TabIndex = 11;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(824, 209);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(168, 56);
            this.buttonEnregistrer.TabIndex = 12;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(824, 63);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(160, 59);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(658, 364);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(91, 47);
            this.btn_dernier.TabIndex = 14;
            this.btn_dernier.Text = ">>";
            this.btn_dernier.UseVisualStyleBackColor = true;
            this.btn_dernier.Click += new System.EventHandler(this.btn_dernier_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(518, 364);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(84, 47);
            this.btn_suivant.TabIndex = 15;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_prec
            // 
            this.btn_prec.Location = new System.Drawing.Point(290, 364);
            this.btn_prec.Name = "btn_prec";
            this.btn_prec.Size = new System.Drawing.Size(81, 47);
            this.btn_prec.TabIndex = 16;
            this.btn_prec.Text = "<";
            this.btn_prec.UseVisualStyleBackColor = true;
            this.btn_prec.Click += new System.EventHandler(this.btn_prec_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(172, 364);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(68, 47);
            this.btn_premier.TabIndex = 17;
            this.btn_premier.Text = "<<";
            this.btn_premier.UseVisualStyleBackColor = true;
            this.btn_premier.Click += new System.EventHandler(this.btn_premier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(636, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "N sur 3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Autocars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.btn_prec);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_dernier);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxConsomation);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxCapacite);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.labelConsomation);
            this.Controls.Add(this.labelDate_Achat);
            this.Controls.Add(this.labelCapacite);
            this.Controls.Add(this.labelCode);
            this.Name = "Autocars";
            this.Text = "Autocars";
            this.Load += new System.EventHandler(this.Autocars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelCapacite;
        private System.Windows.Forms.Label labelDate_Achat;
        private System.Windows.Forms.Label labelConsomation;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.TextBox textBoxCapacite;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxConsomation;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_prec;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}