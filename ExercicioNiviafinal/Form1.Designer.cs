namespace ExercicioNiviafinal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadePostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.looping1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.looping2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.looping3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(762, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadePostoToolStripMenuItem,
            this.looping1ToolStripMenuItem,
            this.looping2ToolStripMenuItem,
            this.looping3ToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // atividadePostoToolStripMenuItem
            // 
            this.atividadePostoToolStripMenuItem.Name = "atividadePostoToolStripMenuItem";
            this.atividadePostoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividadePostoToolStripMenuItem.Text = "AtividadePosto";
            this.atividadePostoToolStripMenuItem.Click += new System.EventHandler(this.atividadePostoToolStripMenuItem_Click);
            // 
            // looping1ToolStripMenuItem
            // 
            this.looping1ToolStripMenuItem.Name = "looping1ToolStripMenuItem";
            this.looping1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.looping1ToolStripMenuItem.Text = "Looping 1";
            this.looping1ToolStripMenuItem.Click += new System.EventHandler(this.looping1ToolStripMenuItem_Click);
            // 
            // looping2ToolStripMenuItem
            // 
            this.looping2ToolStripMenuItem.Name = "looping2ToolStripMenuItem";
            this.looping2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.looping2ToolStripMenuItem.Text = "Looping 2";
            this.looping2ToolStripMenuItem.Click += new System.EventHandler(this.looping2ToolStripMenuItem_Click);
            // 
            // looping3ToolStripMenuItem
            // 
            this.looping3ToolStripMenuItem.Name = "looping3ToolStripMenuItem";
            this.looping3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.looping3ToolStripMenuItem.Text = "Looping 3";
            this.looping3ToolStripMenuItem.Click += new System.EventHandler(this.looping3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 456);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadePostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem looping1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem looping2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem looping3ToolStripMenuItem;
    }
}

