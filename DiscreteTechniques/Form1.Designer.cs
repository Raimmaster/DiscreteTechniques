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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.técnicasDeConteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPSR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPCR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVSR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVCR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCSR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCCR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPC = new System.Windows.Forms.ToolStripMenuItem();
            this.másTécnicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRA = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tEntradaN = new System.Windows.Forms.TextBox();
            this.tEntradaM = new System.Windows.Forms.TextBox();
            this.tResultado = new System.Windows.Forms.TextBox();
            this.lExample = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.toolTipCasos = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.técnicasDeConteoToolStripMenuItem,
            this.másTécnicasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(713, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // técnicasDeConteoToolStripMenuItem
            // 
            this.técnicasDeConteoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPSR,
            this.tsPCR,
            this.tsVSR,
            this.tsVCR,
            this.tsCSR,
            this.tsCCR,
            this.tsPC});
            this.técnicasDeConteoToolStripMenuItem.Name = "técnicasDeConteoToolStripMenuItem";
            this.técnicasDeConteoToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.técnicasDeConteoToolStripMenuItem.Text = "Técnicas de Conteo";
            // 
            // tsPSR
            // 
            this.tsPSR.Name = "tsPSR";
            this.tsPSR.Size = new System.Drawing.Size(275, 26);
            this.tsPSR.Text = "Permutación sin Repetición";
            // 
            // tsPCR
            // 
            this.tsPCR.Name = "tsPCR";
            this.tsPCR.Size = new System.Drawing.Size(275, 26);
            this.tsPCR.Text = "Permutación con Repetición";
            // 
            // tsVSR
            // 
            this.tsVSR.Name = "tsVSR";
            this.tsVSR.Size = new System.Drawing.Size(275, 26);
            this.tsVSR.Text = "Variación sin Repetición";
            // 
            // tsVCR
            // 
            this.tsVCR.Name = "tsVCR";
            this.tsVCR.Size = new System.Drawing.Size(275, 26);
            this.tsVCR.Text = "Variación con Repetición";
            // 
            // tsCSR
            // 
            this.tsCSR.Name = "tsCSR";
            this.tsCSR.Size = new System.Drawing.Size(275, 26);
            this.tsCSR.Text = "Combinación sin Repetición";
            // 
            // tsCCR
            // 
            this.tsCCR.Name = "tsCCR";
            this.tsCCR.Size = new System.Drawing.Size(275, 26);
            this.tsCCR.Text = "Combinación con Repetición";
            // 
            // tsPC
            // 
            this.tsPC.Name = "tsPC";
            this.tsPC.Size = new System.Drawing.Size(275, 26);
            this.tsPC.Text = "Permutación Circular";
            // 
            // másTécnicasToolStripMenuItem
            // 
            this.másTécnicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRM,
            this.tsRA});
            this.másTécnicasToolStripMenuItem.Name = "másTécnicasToolStripMenuItem";
            this.másTécnicasToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.másTécnicasToolStripMenuItem.Text = "Más Técnicas";
            // 
            // tsRM
            // 
            this.tsRM.Name = "tsRM";
            this.tsRM.Size = new System.Drawing.Size(216, 26);
            this.tsRM.Text = "Regla Multiplicativa";
            // 
            // tsRA
            // 
            this.tsRA.Name = "tsRA";
            this.tsRA.Size = new System.Drawing.Size(216, 26);
            this.tsRA.Text = "Regla Aditiva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada (n): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada (m): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado:";
            // 
            // tEntradaN
            // 
            this.tEntradaN.Location = new System.Drawing.Point(143, 56);
            this.tEntradaN.Name = "tEntradaN";
            this.tEntradaN.Size = new System.Drawing.Size(64, 22);
            this.tEntradaN.TabIndex = 4;
            this.toolTipCasos.SetToolTip(this.tEntradaN, "En PCR, n es el total de elementos.");
            // 
            // tEntradaM
            // 
            this.tEntradaM.Location = new System.Drawing.Point(143, 90);
            this.tEntradaM.Name = "tEntradaM";
            this.tEntradaM.Size = new System.Drawing.Size(64, 22);
            this.tEntradaM.TabIndex = 5;
            // 
            // tResultado
            // 
            this.tResultado.Location = new System.Drawing.Point(143, 130);
            this.tResultado.Name = "tResultado";
            this.tResultado.Size = new System.Drawing.Size(64, 22);
            this.tResultado.TabIndex = 6;
            // 
            // lExample
            // 
            this.lExample.AutoSize = true;
            this.lExample.Location = new System.Drawing.Point(356, 55);
            this.lExample.Name = "lExample";
            this.lExample.Size = new System.Drawing.Size(0, 17);
            this.lExample.TabIndex = 7;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(38, 185);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 8;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(132, 185);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 9;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 249);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.lExample);
            this.Controls.Add(this.tResultado);
            this.Controls.Add(this.tEntradaM);
            this.Controls.Add(this.tEntradaN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem tsPCR;
        private System.Windows.Forms.ToolStripMenuItem tsVSR;
        private System.Windows.Forms.ToolStripMenuItem tsVCR;
        private System.Windows.Forms.ToolStripMenuItem tsCSR;
        private System.Windows.Forms.ToolStripMenuItem tsCCR;
        private System.Windows.Forms.ToolStripMenuItem tsPC;
        private System.Windows.Forms.ToolStripMenuItem másTécnicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsRM;
        private System.Windows.Forms.ToolStripMenuItem tsRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tEntradaN;
        private System.Windows.Forms.ToolTip toolTipCasos;
        private System.Windows.Forms.TextBox tEntradaM;
        private System.Windows.Forms.TextBox tResultado;
        private System.Windows.Forms.Label lExample;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bReset;
    }
}

