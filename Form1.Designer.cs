﻿namespace MD5Cracker
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
            this.IsSlovnikovyUtok = new System.Windows.Forms.CheckBox();
            this.bNacistSlovnik = new System.Windows.Forms.Button();
            this.tbSlovnikCesta = new System.Windows.Forms.TextBox();
            this.bSpustitLamani = new System.Windows.Forms.Button();
            this.bUlozitDo = new System.Windows.Forms.Button();
            this.tbVystupniCesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // IsSlovnikovyUtok
            // 
            this.IsSlovnikovyUtok.AutoSize = true;
            this.IsSlovnikovyUtok.Location = new System.Drawing.Point(13, 54);
            this.IsSlovnikovyUtok.Name = "IsSlovnikovyUtok";
            this.IsSlovnikovyUtok.Size = new System.Drawing.Size(104, 17);
            this.IsSlovnikovyUtok.TabIndex = 3;
            this.IsSlovnikovyUtok.Text = "Slovníkový útok";
            this.IsSlovnikovyUtok.UseVisualStyleBackColor = true;
            this.IsSlovnikovyUtok.CheckedChanged += new System.EventHandler(this.IsSlovnikovyUtok_CheckedChanged);
            // 
            // bNacistSlovnik
            // 
            this.bNacistSlovnik.Enabled = false;
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
            this.tbSlovnikCesta.Enabled = false;
            this.tbSlovnikCesta.Location = new System.Drawing.Point(12, 77);
            this.tbSlovnikCesta.Name = "tbSlovnikCesta";
            this.tbSlovnikCesta.Size = new System.Drawing.Size(181, 20);
            this.tbSlovnikCesta.TabIndex = 4;
            // 
            // bSpustitLamani
            // 
            this.bSpustitLamani.BackColor = System.Drawing.Color.Red;
            this.bSpustitLamani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSpustitLamani.Location = new System.Drawing.Point(199, 116);
            this.bSpustitLamani.Name = "bSpustitLamani";
            this.bSpustitLamani.Size = new System.Drawing.Size(75, 42);
            this.bSpustitLamani.TabIndex = 7;
            this.bSpustitLamani.Text = "Spustit lámání MD5";
            this.bSpustitLamani.UseVisualStyleBackColor = false;
            this.bSpustitLamani.Click += new System.EventHandler(this.bSpustitLamani_Click);
            // 
            // bUlozitDo
            // 
            this.bUlozitDo.Location = new System.Drawing.Point(199, 229);
            this.bUlozitDo.Name = "bUlozitDo";
            this.bUlozitDo.Size = new System.Drawing.Size(73, 20);
            this.bUlozitDo.TabIndex = 9;
            this.bUlozitDo.Text = "Procházet";
            this.bUlozitDo.UseVisualStyleBackColor = true;
            this.bUlozitDo.Click += new System.EventHandler(this.bUlozitDo_Click);
            // 
            // tbVystupniCesta
            // 
            this.tbVystupniCesta.Location = new System.Drawing.Point(12, 229);
            this.tbVystupniCesta.Name = "tbVystupniCesta";
            this.tbVystupniCesta.Size = new System.Drawing.Size(181, 20);
            this.tbVystupniCesta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Výstupní soubor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUlozitDo);
            this.Controls.Add(this.tbVystupniCesta);
            this.Controls.Add(this.bSpustitLamani);
            this.Controls.Add(this.bNacistSlovnik);
            this.Controls.Add(this.tbSlovnikCesta);
            this.Controls.Add(this.IsSlovnikovyUtok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNacistSoubor);
            this.Controls.Add(this.tbHeslaCesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHeslaCesta;
        private System.Windows.Forms.Button bNacistSoubor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsSlovnikovyUtok;
        private System.Windows.Forms.Button bNacistSlovnik;
        private System.Windows.Forms.TextBox tbSlovnikCesta;
        private System.Windows.Forms.Button bSpustitLamani;
        private System.Windows.Forms.Button bUlozitDo;
        private System.Windows.Forms.TextBox tbVystupniCesta;
        private System.Windows.Forms.Label label2;
    }
}

