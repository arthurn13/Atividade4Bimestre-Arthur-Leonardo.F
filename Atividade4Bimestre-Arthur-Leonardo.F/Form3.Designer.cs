namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    partial class frmconversao
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
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(579, 60);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(78, 177);
            this.txtresult.TabIndex = 17;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(476, 63);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(97, 16);
            this.lblresult.TabIndex = 16;
            this.lblresult.Text = "A conversão é:";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(757, 435);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 50);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(277, 233);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(100, 69);
            this.btndowhile.TabIndex = 13;
            this.btndowhile.Text = "Calcular com DoWhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(277, 339);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(100, 50);
            this.btnfor.TabIndex = 12;
            this.btnfor.Text = "Calcular com For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(517, 435);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 50);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(277, 435);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(100, 50);
            this.btnwhile.TabIndex = 10;
            this.btnwhile.Text = "Calcular com While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // frmconversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ControlBox = false;
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnwhile);
            this.Name = "frmconversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnwhile;
    }
}