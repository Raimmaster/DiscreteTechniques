namespace DiscreteTechniques
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.técnicasDeConteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPSR = new System.Windows.Forms.ToolStripMenuItem();
            this.permutaciónConRepeticiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variaciónSinRepeticiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variaciónConRepeticiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinaciónSinRepeticiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinaciónConRepeticiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másTécnicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaMultiplicativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaAditivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permutaciónCircularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.técnicasDeConteoToolStripMenuItem,
            this.másTécnicasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(599, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // técnicasDeConteoToolStripMenuItem
            // 
            this.técnicasDeConteoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPSR,
            this.permutaciónConRepeticiónToolStripMenuItem,
            this.variaciónSinRepeticiónToolStripMenuItem,
            this.variaciónConRepeticiónToolStripMenuItem,
            this.combinaciónSinRepeticiónToolStripMenuItem,
            this.combinaciónConRepeticiónToolStripMenuItem,
            this.permutaciónCircularToolStripMenuItem});
            this.técnicasDeConteoToolStripMenuItem.Name = "técnicasDeConteoToolStripMenuItem";
            this.técnicasDeConteoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.técnicasDeConteoToolStripMenuItem.Text = "Técnicas de Conteo";
            // 
            // tsPSR
            // 
            this.tsPSR.Enabled = false;
            this.tsPSR.Name = "tsPSR";
            this.tsPSR.Size = new System.Drawing.Size(228, 22);
            this.tsPSR.Text = "Permutación sin Repetición";
            // 
            // permutaciónConRepeticiónToolStripMenuItem
            // 
            this.permutaciónConRepeticiónToolStripMenuItem.Name = "permutaciónConRepeticiónToolStripMenuItem";
            this.permutaciónConRepeticiónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.permutaciónConRepeticiónToolStripMenuItem.Text = "Permutación con Repetición";
            // 
            // variaciónSinRepeticiónToolStripMenuItem
            // 
            this.variaciónSinRepeticiónToolStripMenuItem.Name = "variaciónSinRepeticiónToolStripMenuItem";
            this.variaciónSinRepeticiónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.variaciónSinRepeticiónToolStripMenuItem.Text = "Variación sin Repetición";
            // 
            // variaciónConRepeticiónToolStripMenuItem
            // 
            this.variaciónConRepeticiónToolStripMenuItem.Name = "variaciónConRepeticiónToolStripMenuItem";
            this.variaciónConRepeticiónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.variaciónConRepeticiónToolStripMenuItem.Text = "Variación con Repetición";
            // 
            // combinaciónSinRepeticiónToolStripMenuItem
            // 
            this.combinaciónSinRepeticiónToolStripMenuItem.Name = "combinaciónSinRepeticiónToolStripMenuItem";
            this.combinaciónSinRepeticiónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.combinaciónSinRepeticiónToolStripMenuItem.Text = "Combinación sin Repetición";
            // 
            // combinaciónConRepeticiónToolStripMenuItem
            // 
            this.combinaciónConRepeticiónToolStripMenuItem.Name = "combinaciónConRepeticiónToolStripMenuItem";
            this.combinaciónConRepeticiónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.combinaciónConRepeticiónToolStripMenuItem.Text = "Combinación con Repetición";
            // 
            // másTécnicasToolStripMenuItem
            // 
            this.másTécnicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reglaMultiplicativaToolStripMenuItem,
            this.reglaAditivaToolStripMenuItem});
            this.másTécnicasToolStripMenuItem.Name = "másTécnicasToolStripMenuItem";
            this.másTécnicasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.másTécnicasToolStripMenuItem.Text = "Más Técnicas";
            // 
            // reglaMultiplicativaToolStripMenuItem
            // 
            this.reglaMultiplicativaToolStripMenuItem.Name = "reglaMultiplicativaToolStripMenuItem";
            this.reglaMultiplicativaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reglaMultiplicativaToolStripMenuItem.Text = "Regla Multiplicativa";
            // 
            // reglaAditivaToolStripMenuItem
            // 
            this.reglaAditivaToolStripMenuItem.Name = "reglaAditivaToolStripMenuItem";
            this.reglaAditivaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reglaAditivaToolStripMenuItem.Text = "Regla Aditiva";
            // 
            // permutaciónCircularToolStripMenuItem
            // 
            this.permutaciónCircularToolStripMenuItem.Name = "permutaciónCircularToolStripMenuItem";
            this.permutaciónCircularToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.permutaciónCircularToolStripMenuItem.Text = "Permutación Circular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 299);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Técnicas";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem técnicasDeConteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsPSR;
        private System.Windows.Forms.ToolStripMenuItem permutaciónConRepeticiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variaciónSinRepeticiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variaciónConRepeticiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinaciónSinRepeticiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinaciónConRepeticiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permutaciónCircularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másTécnicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaMultiplicativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaAditivaToolStripMenuItem;
    }
}

