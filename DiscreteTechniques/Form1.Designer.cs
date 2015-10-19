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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRA = new System.Windows.Forms.RadioButton();
            this.rbRM = new System.Windows.Forms.RadioButton();
            this.rbPC = new System.Windows.Forms.RadioButton();
            this.rbCCR = new System.Windows.Forms.RadioButton();
            this.rbCSR = new System.Windows.Forms.RadioButton();
            this.rbVCR = new System.Windows.Forms.RadioButton();
            this.rbVSR = new System.Windows.Forms.RadioButton();
            this.rbPCR = new System.Windows.Forms.RadioButton();
            this.rbPSR = new System.Windows.Forms.RadioButton();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(910, 28);
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
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada (n): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada (m): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado:";
            // 
            // tEntradaN
            // 
            this.tEntradaN.Location = new System.Drawing.Point(143, 59);
            this.tEntradaN.Name = "tEntradaN";
            this.tEntradaN.Size = new System.Drawing.Size(64, 22);
            this.tEntradaN.TabIndex = 4;
            this.tEntradaN.Text = "0";
            this.toolTipCasos.SetToolTip(this.tEntradaN, "En PCR, n es el total de elementos.");
            // 
            // tEntradaM
            // 
            this.tEntradaM.Enabled = false;
            this.tEntradaM.Location = new System.Drawing.Point(143, 93);
            this.tEntradaM.Name = "tEntradaM";
            this.tEntradaM.Size = new System.Drawing.Size(64, 22);
            this.tEntradaM.TabIndex = 5;
            this.tEntradaM.Text = "0";
            // 
            // tResultado
            // 
            this.tResultado.Location = new System.Drawing.Point(143, 133);
            this.tResultado.Name = "tResultado";
            this.tResultado.Size = new System.Drawing.Size(64, 22);
            this.tResultado.TabIndex = 6;
            this.tResultado.Text = "0";
            // 
            // lExample
            // 
            this.lExample.AutoSize = true;
            this.lExample.Location = new System.Drawing.Point(35, 237);
            this.lExample.Name = "lExample";
            this.lExample.Size = new System.Drawing.Size(0, 17);
            this.lExample.TabIndex = 7;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(38, 173);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 8;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(132, 173);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 9;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRA);
            this.groupBox1.Controls.Add(this.rbRM);
            this.groupBox1.Controls.Add(this.rbPC);
            this.groupBox1.Controls.Add(this.rbCCR);
            this.groupBox1.Controls.Add(this.rbCSR);
            this.groupBox1.Controls.Add(this.rbVCR);
            this.groupBox1.Controls.Add(this.rbVSR);
            this.groupBox1.Controls.Add(this.rbPCR);
            this.groupBox1.Controls.Add(this.rbPSR);
            this.groupBox1.Location = new System.Drawing.Point(234, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Técnicas";
            // 
            // rbRA
            // 
            this.rbRA.AutoSize = true;
            this.rbRA.Location = new System.Drawing.Point(452, 101);
            this.rbRA.Name = "rbRA";
            this.rbRA.Size = new System.Drawing.Size(112, 21);
            this.rbRA.TabIndex = 8;
            this.rbRA.TabStop = true;
            this.rbRA.Text = "Regla Aditiva";
            this.rbRA.UseVisualStyleBackColor = true;
            this.rbRA.CheckedChanged += new System.EventHandler(this.rbRA_CheckedChanged);
            // 
            // rbRM
            // 
            this.rbRM.AutoSize = true;
            this.rbRM.Location = new System.Drawing.Point(214, 101);
            this.rbRM.Name = "rbRM";
            this.rbRM.Size = new System.Drawing.Size(150, 21);
            this.rbRM.TabIndex = 7;
            this.rbRM.TabStop = true;
            this.rbRM.Text = "Regla Multiplicativa";
            this.rbRM.UseVisualStyleBackColor = true;
            this.rbRM.CheckedChanged += new System.EventHandler(this.rbRM_CheckedChanged);
            // 
            // rbPC
            // 
            this.rbPC.AutoSize = true;
            this.rbPC.Location = new System.Drawing.Point(6, 101);
            this.rbPC.Name = "rbPC";
            this.rbPC.Size = new System.Drawing.Size(160, 21);
            this.rbPC.TabIndex = 6;
            this.rbPC.TabStop = true;
            this.rbPC.Text = "Permutación Circular";
            this.rbPC.UseVisualStyleBackColor = true;
            this.rbPC.CheckedChanged += new System.EventHandler(this.rbPC_CheckedChanged);
            // 
            // rbCCR
            // 
            this.rbCCR.AutoSize = true;
            this.rbCCR.Location = new System.Drawing.Point(452, 62);
            this.rbCCR.Name = "rbCCR";
            this.rbCCR.Size = new System.Drawing.Size(208, 21);
            this.rbCCR.TabIndex = 5;
            this.rbCCR.TabStop = true;
            this.rbCCR.Text = "Combinación con Repetición";
            this.rbCCR.UseVisualStyleBackColor = true;
            this.rbCCR.CheckedChanged += new System.EventHandler(this.rbCCR_CheckedChanged);
            // 
            // rbCSR
            // 
            this.rbCSR.AutoSize = true;
            this.rbCSR.Location = new System.Drawing.Point(214, 62);
            this.rbCSR.Name = "rbCSR";
            this.rbCSR.Size = new System.Drawing.Size(203, 21);
            this.rbCSR.TabIndex = 4;
            this.rbCSR.TabStop = true;
            this.rbCSR.Text = "Combinación sin Repetición";
            this.rbCSR.UseVisualStyleBackColor = true;
            this.rbCSR.CheckedChanged += new System.EventHandler(this.rbCSR_CheckedChanged);
            // 
            // rbVCR
            // 
            this.rbVCR.AutoSize = true;
            this.rbVCR.Location = new System.Drawing.Point(7, 62);
            this.rbVCR.Name = "rbVCR";
            this.rbVCR.Size = new System.Drawing.Size(186, 21);
            this.rbVCR.TabIndex = 3;
            this.rbVCR.TabStop = true;
            this.rbVCR.Text = "Variación con Repetición";
            this.rbVCR.UseVisualStyleBackColor = true;
            this.rbVCR.CheckedChanged += new System.EventHandler(this.rbVCR_CheckedChanged);
            // 
            // rbVSR
            // 
            this.rbVSR.AutoSize = true;
            this.rbVSR.Location = new System.Drawing.Point(452, 25);
            this.rbVSR.Name = "rbVSR";
            this.rbVSR.Size = new System.Drawing.Size(181, 21);
            this.rbVSR.TabIndex = 2;
            this.rbVSR.TabStop = true;
            this.rbVSR.Text = "Variación sin Repetición";
            this.rbVSR.UseVisualStyleBackColor = true;
            this.rbVSR.CheckedChanged += new System.EventHandler(this.rbVSR_CheckedChanged);
            // 
            // rbPCR
            // 
            this.rbPCR.AutoSize = true;
            this.rbPCR.Location = new System.Drawing.Point(214, 25);
            this.rbPCR.Name = "rbPCR";
            this.rbPCR.Size = new System.Drawing.Size(206, 21);
            this.rbPCR.TabIndex = 1;
            this.rbPCR.TabStop = true;
            this.rbPCR.Text = "Permutación con Repetición";
            this.rbPCR.UseVisualStyleBackColor = true;
            this.rbPCR.CheckedChanged += new System.EventHandler(this.rbPCR_CheckedChanged);
            // 
            // rbPSR
            // 
            this.rbPSR.AutoSize = true;
            this.rbPSR.Checked = true;
            this.rbPSR.Location = new System.Drawing.Point(7, 25);
            this.rbPSR.Name = "rbPSR";
            this.rbPSR.Size = new System.Drawing.Size(201, 21);
            this.rbPSR.TabIndex = 0;
            this.rbPSR.TabStop = true;
            this.rbPSR.Text = "Permutación sin Repetición";
            this.rbPSR.UseVisualStyleBackColor = true;
            this.rbPSR.CheckedChanged += new System.EventHandler(this.rbPSR_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 346);
            this.Controls.Add(this.groupBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Técnicas";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRA;
        private System.Windows.Forms.RadioButton rbRM;
        private System.Windows.Forms.RadioButton rbPC;
        private System.Windows.Forms.RadioButton rbCCR;
        private System.Windows.Forms.RadioButton rbCSR;
        private System.Windows.Forms.RadioButton rbVCR;
        private System.Windows.Forms.RadioButton rbVSR;
        private System.Windows.Forms.RadioButton rbPCR;
        private System.Windows.Forms.RadioButton rbPSR;
    }
}

