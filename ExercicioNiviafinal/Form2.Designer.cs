namespace ExercicioNiviafinal
{
    partial class Formposto
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
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(82, 78);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(105, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Quantidade de Litros";
            this.lblnumero.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(82, 122);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(105, 13);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "Tipo de Combustível";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(253, 71);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(127, 20);
            this.txtq.TabIndex = 2;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(253, 119);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(127, 20);
            this.txtcod.TabIndex = 3;
            this.txtcod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(82, 174);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(55, 13);
            this.lblnumero2.TabIndex = 4;
            this.lblnumero2.Text = "Resultado";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(253, 171);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(127, 20);
            this.txtresult.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(112, 263);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(94, 36);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(268, 263);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(92, 36);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(433, 263);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(90, 36);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Formposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.lblnumero);
            this.Name = "Formposto";
            this.RightToLeftLayout = true;
            this.Text = "Formposto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}