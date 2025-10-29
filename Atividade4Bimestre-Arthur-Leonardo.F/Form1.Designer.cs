namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDeCasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.conversãoDeTemperaturaToolStripMenuItem,
            this.áreaDeCasaToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            // 
            // conversãoDeTemperaturaToolStripMenuItem
            // 
            this.conversãoDeTemperaturaToolStripMenuItem.Name = "conversãoDeTemperaturaToolStripMenuItem";
            this.conversãoDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.conversãoDeTemperaturaToolStripMenuItem.Text = "Conversão de Temperatura";
            // 
            // áreaDeCasaToolStripMenuItem
            // 
            this.áreaDeCasaToolStripMenuItem.Name = "áreaDeCasaToolStripMenuItem";
            this.áreaDeCasaToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.áreaDeCasaToolStripMenuItem.Text = "Área de Casa";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDeCasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

