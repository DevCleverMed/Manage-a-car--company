namespace Controle2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autocarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autocarsToolStripMenuItem,
            this.lignesToolStripMenuItem,
            this.voyagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // autocarsToolStripMenuItem
            // 
            this.autocarsToolStripMenuItem.Name = "autocarsToolStripMenuItem";
            this.autocarsToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.autocarsToolStripMenuItem.Text = "Autocars";
            this.autocarsToolStripMenuItem.Click += new System.EventHandler(this.autocarsToolStripMenuItem_Click);
            // 
            // lignesToolStripMenuItem
            // 
            this.lignesToolStripMenuItem.Name = "lignesToolStripMenuItem";
            this.lignesToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.lignesToolStripMenuItem.Text = "Lignes";
            this.lignesToolStripMenuItem.Click += new System.EventHandler(this.lignesToolStripMenuItem_Click);
            // 
            // voyagesToolStripMenuItem
            // 
            this.voyagesToolStripMenuItem.Name = "voyagesToolStripMenuItem";
            this.voyagesToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.voyagesToolStripMenuItem.Text = "Voyages";
            this.voyagesToolStripMenuItem.Click += new System.EventHandler(this.voyagesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 512);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autocarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voyagesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

