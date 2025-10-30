namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    partial class frmarea
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
            this.txtareacomodo = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtcomodo = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.lblcomodo = new System.Windows.Forms.Label();
            this.txtlargura = new System.Windows.Forms.TextBox();
            this.lbllargura = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.lblcomp = new System.Windows.Forms.Label();
            this.txtareatotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtareacomodo
            // 
            this.txtareacomodo.Location = new System.Drawing.Point(866, 45);
            this.txtareacomodo.Multiline = true;
            this.txtareacomodo.Name = "txtareacomodo";
            this.txtareacomodo.ReadOnly = true;
            this.txtareacomodo.Size = new System.Drawing.Size(180, 25);
            this.txtareacomodo.TabIndex = 17;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(699, 51);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(152, 16);
            this.lblresult.TabIndex = 16;
            this.lblresult.Text = "A área do cômodo é de:";
            // 
            // txtcomodo
            // 
            this.txtcomodo.Location = new System.Drawing.Point(389, 48);
            this.txtcomodo.Name = "txtcomodo";
            this.txtcomodo.Size = new System.Drawing.Size(139, 22);
            this.txtcomodo.TabIndex = 15;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(751, 469);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 50);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(271, 267);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(100, 69);
            this.btndowhile.TabIndex = 13;
            this.btndowhile.Text = "Calcular com DoWhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(271, 373);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(100, 50);
            this.btnfor.TabIndex = 12;
            this.btnfor.Text = "Calcular com For";
            this.btnfor.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(511, 469);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 50);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(271, 469);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(100, 50);
            this.btnwhile.TabIndex = 10;
            this.btnwhile.Text = "Calcular com While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // lblcomodo
            // 
            this.lblcomodo.AutoSize = true;
            this.lblcomodo.Location = new System.Drawing.Point(114, 51);
            this.lblcomodo.Name = "lblcomodo";
            this.lblcomodo.Size = new System.Drawing.Size(257, 16);
            this.lblcomodo.TabIndex = 9;
            this.lblcomodo.Text = "Digite quantos cômodos sua casa possui:";
            this.lblcomodo.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // txtlargura
            // 
            this.txtlargura.Location = new System.Drawing.Point(389, 101);
            this.txtlargura.Name = "txtlargura";
            this.txtlargura.Size = new System.Drawing.Size(139, 22);
            this.txtlargura.TabIndex = 19;
            // 
            // lbllargura
            // 
            this.lbllargura.AutoSize = true;
            this.lbllargura.Location = new System.Drawing.Point(132, 101);
            this.lbllargura.Name = "lbllargura";
            this.lbllargura.Size = new System.Drawing.Size(239, 16);
            this.lbllargura.TabIndex = 18;
            this.lbllargura.Text = "Digite a largura do cômodo em metros:";
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(389, 154);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(139, 22);
            this.txtcomp.TabIndex = 21;
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(96, 157);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(275, 16);
            this.lblcomp.TabIndex = 20;
            this.lblcomp.Text = "Digite o comprimento do cômodo em metros:";
            // 
            // txtareatotal
            // 
            this.txtareatotal.Location = new System.Drawing.Point(866, 101);
            this.txtareatotal.Multiline = true;
            this.txtareatotal.Name = "txtareatotal";
            this.txtareatotal.ReadOnly = true;
            this.txtareatotal.Size = new System.Drawing.Size(180, 25);
            this.txtareatotal.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "A área total da casa é de:";
            // 
            // frmarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ControlBox = false;
            this.Controls.Add(this.txtareatotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.txtlargura);
            this.Controls.Add(this.lbllargura);
            this.Controls.Add(this.txtareacomodo);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtcomodo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.lblcomodo);
            this.Name = "frmarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtareacomodo;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtcomodo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Label lblcomodo;
        private System.Windows.Forms.TextBox txtlargura;
        private System.Windows.Forms.Label lbllargura;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.TextBox txtareatotal;
        private System.Windows.Forms.Label label1;
    }
}