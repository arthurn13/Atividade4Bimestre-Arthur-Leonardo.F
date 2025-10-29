namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    partial class frmtabuada
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(117, 83);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(186, 16);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Escreva um número de 1 a 10:";
            this.lblnumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(240, 446);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(100, 50);
            this.btnwhile.TabIndex = 1;
            this.btnwhile.Text = "Calcular com While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(480, 446);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 50);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(240, 350);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(100, 50);
            this.btnfor.TabIndex = 3;
            this.btnfor.Text = "Calcular com For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(240, 244);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(100, 69);
            this.btndowhile.TabIndex = 4;
            this.btndowhile.Text = "Calcular com DoWhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(720, 446);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 50);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(321, 80);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(139, 22);
            this.txtnum.TabIndex = 6;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(802, 83);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(98, 172);
            this.txtresult.TabIndex = 8;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(643, 86);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(144, 16);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "Resultado da tabuada:";
            this.lblresult.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ControlBox = false;
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.lblnumero);
            this.Name = "frmtabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblresult;
    }
}