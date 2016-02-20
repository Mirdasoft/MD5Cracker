namespace MD5Cracker
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
            this.tbHeslaCesta = new System.Windows.Forms.TextBox();
            this.bNacistSoubor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bNacistSlovnik = new System.Windows.Forms.Button();
            this.tbSlovnikCesta = new System.Windows.Forms.TextBox();
            this.bSpustitLamani = new System.Windows.Forms.Button();
            this.bUlozitDo = new System.Windows.Forms.Button();
            this.tbVystupniCesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSlovnik = new System.Windows.Forms.RadioButton();
            this.rbBruteForce = new System.Windows.Forms.RadioButton();
            this.tbPasswordMask = new System.Windows.Forms.TextBox();
            this.rbBruteForce2 = new System.Windows.Forms.RadioButton();
            this.formatCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.NumericUpDown();
            this.tbMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHeslaCesta
            // 
            this.tbHeslaCesta.Location = new System.Drawing.Point(12, 28);
            this.tbHeslaCesta.Name = "tbHeslaCesta";
            this.tbHeslaCesta.Size = new System.Drawing.Size(181, 20);
            this.tbHeslaCesta.TabIndex = 0;
            // 
            // bNacistSoubor
            // 
            this.bNacistSoubor.Location = new System.Drawing.Point(199, 28);
            this.bNacistSoubor.Name = "bNacistSoubor";
            this.bNacistSoubor.Size = new System.Drawing.Size(73, 20);
            this.bNacistSoubor.TabIndex = 1;
            this.bNacistSoubor.Text = "Procházet";
            this.bNacistSoubor.UseVisualStyleBackColor = true;
            this.bNacistSoubor.Click += new System.EventHandler(this.bNacistSoubor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soubor s hesly";
            // 
            // bNacistSlovnik
            // 
            this.bNacistSlovnik.Location = new System.Drawing.Point(199, 77);
            this.bNacistSlovnik.Name = "bNacistSlovnik";
            this.bNacistSlovnik.Size = new System.Drawing.Size(73, 20);
            this.bNacistSlovnik.TabIndex = 5;
            this.bNacistSlovnik.Text = "Procházet";
            this.bNacistSlovnik.UseVisualStyleBackColor = true;
            this.bNacistSlovnik.Click += new System.EventHandler(this.bNacistSlovnik_Click);
            // 
            // tbSlovnikCesta
            // 
            this.tbSlovnikCesta.Location = new System.Drawing.Point(12, 77);
            this.tbSlovnikCesta.Name = "tbSlovnikCesta";
            this.tbSlovnikCesta.Size = new System.Drawing.Size(181, 20);
            this.tbSlovnikCesta.TabIndex = 4;
            // 
            // bSpustitLamani
            // 
            this.bSpustitLamani.BackColor = System.Drawing.Color.ForestGreen;
            this.bSpustitLamani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSpustitLamani.Location = new System.Drawing.Point(199, 126);
            this.bSpustitLamani.Name = "bSpustitLamani";
            this.bSpustitLamani.Size = new System.Drawing.Size(75, 42);
            this.bSpustitLamani.TabIndex = 7;
            this.bSpustitLamani.Text = "Spustit lámání";
            this.bSpustitLamani.UseVisualStyleBackColor = false;
            this.bSpustitLamani.Click += new System.EventHandler(this.bSpustitLamani_Click);
            // 
            // bUlozitDo
            // 
            this.bUlozitDo.Location = new System.Drawing.Point(199, 252);
            this.bUlozitDo.Name = "bUlozitDo";
            this.bUlozitDo.Size = new System.Drawing.Size(73, 20);
            this.bUlozitDo.TabIndex = 9;
            this.bUlozitDo.Text = "Procházet";
            this.bUlozitDo.UseVisualStyleBackColor = true;
            this.bUlozitDo.Click += new System.EventHandler(this.bUlozitDo_Click);
            // 
            // tbVystupniCesta
            // 
            this.tbVystupniCesta.Location = new System.Drawing.Point(12, 253);
            this.tbVystupniCesta.Name = "tbVystupniCesta";
            this.tbVystupniCesta.Size = new System.Drawing.Size(181, 20);
            this.tbVystupniCesta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Výstupní soubor";
            // 
            // rbSlovnik
            // 
            this.rbSlovnik.AutoSize = true;
            this.rbSlovnik.Checked = true;
            this.rbSlovnik.Location = new System.Drawing.Point(12, 54);
            this.rbSlovnik.Name = "rbSlovnik";
            this.rbSlovnik.Size = new System.Drawing.Size(103, 17);
            this.rbSlovnik.TabIndex = 12;
            this.rbSlovnik.TabStop = true;
            this.rbSlovnik.Text = "Slovníkový útok";
            this.rbSlovnik.UseVisualStyleBackColor = true;
            this.rbSlovnik.CheckedChanged += new System.EventHandler(this.rbSlovnik_CheckedChanged);
            // 
            // rbBruteForce
            // 
            this.rbBruteForce.AutoSize = true;
            this.rbBruteForce.Location = new System.Drawing.Point(12, 103);
            this.rbBruteForce.Name = "rbBruteForce";
            this.rbBruteForce.Size = new System.Drawing.Size(80, 17);
            this.rbBruteForce.TabIndex = 13;
            this.rbBruteForce.Text = "Brute Force";
            this.rbBruteForce.UseVisualStyleBackColor = true;
            this.rbBruteForce.CheckedChanged += new System.EventHandler(this.rbBruteForce_CheckedChanged);
            // 
            // tbPasswordMask
            // 
            this.tbPasswordMask.Enabled = false;
            this.tbPasswordMask.Location = new System.Drawing.Point(12, 126);
            this.tbPasswordMask.Name = "tbPasswordMask";
            this.tbPasswordMask.Size = new System.Drawing.Size(181, 20);
            this.tbPasswordMask.TabIndex = 14;
            // 
            // rbBruteForce2
            // 
            this.rbBruteForce2.AutoSize = true;
            this.rbBruteForce2.Location = new System.Drawing.Point(12, 152);
            this.rbBruteForce2.Name = "rbBruteForce2";
            this.rbBruteForce2.Size = new System.Drawing.Size(89, 17);
            this.rbBruteForce2.TabIndex = 15;
            this.rbBruteForce2.Text = "Brute Force 2";
            this.rbBruteForce2.UseVisualStyleBackColor = true;
            this.rbBruteForce2.CheckedChanged += new System.EventHandler(this.rbBruteForce2_CheckedChanged);
            // 
            // formatCombo
            // 
            this.formatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatCombo.Enabled = false;
            this.formatCombo.FormattingEnabled = true;
            this.formatCombo.Location = new System.Drawing.Point(12, 176);
            this.formatCombo.Name = "formatCombo";
            this.formatCombo.Size = new System.Drawing.Size(181, 21);
            this.formatCombo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Min: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max: ";
            // 
            // tbMin
            // 
            this.tbMin.Enabled = false;
            this.tbMin.Location = new System.Drawing.Point(45, 204);
            this.tbMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(47, 20);
            this.tbMin.TabIndex = 21;
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Location = new System.Drawing.Point(137, 204);
            this.tbMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(47, 20);
            this.tbMax.TabIndex = 22;
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatCombo);
            this.Controls.Add(this.rbBruteForce2);
            this.Controls.Add(this.tbPasswordMask);
            this.Controls.Add(this.rbBruteForce);
            this.Controls.Add(this.rbSlovnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUlozitDo);
            this.Controls.Add(this.tbVystupniCesta);
            this.Controls.Add(this.bSpustitLamani);
            this.Controls.Add(this.bNacistSlovnik);
            this.Controls.Add(this.tbSlovnikCesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNacistSoubor);
            this.Controls.Add(this.tbHeslaCesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHeslaCesta;
        private System.Windows.Forms.Button bNacistSoubor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNacistSlovnik;
        private System.Windows.Forms.TextBox tbSlovnikCesta;
        private System.Windows.Forms.Button bSpustitLamani;
        private System.Windows.Forms.Button bUlozitDo;
        private System.Windows.Forms.TextBox tbVystupniCesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSlovnik;
        private System.Windows.Forms.RadioButton rbBruteForce;
        private System.Windows.Forms.TextBox tbPasswordMask;
        private System.Windows.Forms.RadioButton rbBruteForce2;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbMin;
        private System.Windows.Forms.NumericUpDown tbMax;
    }
}

