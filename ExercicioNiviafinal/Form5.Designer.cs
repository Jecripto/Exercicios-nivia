﻿namespace ExercicioNiviafinal
{
    partial class Formloop3
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(107, 69);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(144, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Digite o Número da Tabuada";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(107, 157);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "Tabuada:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(295, 66);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(261, 154);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(134, 20);
            this.txtresult.TabIndex = 3;
            this.txtresult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(110, 238);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(97, 37);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(295, 238);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(97, 37);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Formloop3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.lblnumero);
            this.Name = "Formloop3";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
    }
}