﻿namespace SafeContractorApp
{
    partial class Vuurvergunning
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.stpVan = new System.Windows.Forms.DateTimePicker();
            this.cbAard = new System.Windows.Forms.ComboBox();
            this.lbxAard = new System.Windows.Forms.ListBox();
            this.lbxInstallatie = new System.Windows.Forms.ListBox();
            this.cbInstallatie = new System.Windows.Forms.ComboBox();
            this.lbxOmpgeving = new System.Windows.Forms.ListBox();
            this.cbOmgeving = new System.Windows.Forms.ComboBox();
            this.lbxBrand = new System.Windows.Forms.ListBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbMaatregelen = new System.Windows.Forms.TextBox();
            this.btnSumit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxBrandP = new System.Windows.Forms.ListBox();
            this.lbxOmpgevingP = new System.Windows.Forms.ListBox();
            this.lbxInstallatieP = new System.Windows.Forms.ListBox();
            this.lbxAardP = new System.Windows.Forms.ListBox();
            this.tbAard = new System.Windows.Forms.TextBox();
            this.tbIstallatie = new System.Windows.Forms.TextBox();
            this.tbOmgeving = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.brnO = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(91, 30);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(182, 20);
            this.dtpDatum.TabIndex = 21;
            // 
            // dtpTot
            // 
            this.dtpTot.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTot.Location = new System.Drawing.Point(496, 30);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(182, 20);
            this.dtpTot.TabIndex = 23;
            // 
            // stpVan
            // 
            this.stpVan.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.stpVan.Location = new System.Drawing.Point(293, 30);
            this.stpVan.Name = "stpVan";
            this.stpVan.Size = new System.Drawing.Size(182, 20);
            this.stpVan.TabIndex = 24;
            // 
            // cbAard
            // 
            this.cbAard.FormattingEnabled = true;
            this.cbAard.Location = new System.Drawing.Point(30, 85);
            this.cbAard.Name = "cbAard";
            this.cbAard.Size = new System.Drawing.Size(182, 21);
            this.cbAard.TabIndex = 26;
            this.cbAard.SelectedIndexChanged += new System.EventHandler(this.cbAard_SelectedIndexChanged);
            // 
            // lbxAard
            // 
            this.lbxAard.FormattingEnabled = true;
            this.lbxAard.Location = new System.Drawing.Point(30, 176);
            this.lbxAard.Name = "lbxAard";
            this.lbxAard.Size = new System.Drawing.Size(182, 147);
            this.lbxAard.TabIndex = 27;
            // 
            // lbxInstallatie
            // 
            this.lbxInstallatie.FormattingEnabled = true;
            this.lbxInstallatie.Location = new System.Drawing.Point(232, 176);
            this.lbxInstallatie.Name = "lbxInstallatie";
            this.lbxInstallatie.Size = new System.Drawing.Size(182, 147);
            this.lbxInstallatie.TabIndex = 29;
            // 
            // cbInstallatie
            // 
            this.cbInstallatie.FormattingEnabled = true;
            this.cbInstallatie.Location = new System.Drawing.Point(232, 85);
            this.cbInstallatie.Name = "cbInstallatie";
            this.cbInstallatie.Size = new System.Drawing.Size(182, 21);
            this.cbInstallatie.TabIndex = 28;
            this.cbInstallatie.SelectedIndexChanged += new System.EventHandler(this.cbInstallatie_SelectedIndexChanged);
            // 
            // lbxOmpgeving
            // 
            this.lbxOmpgeving.FormattingEnabled = true;
            this.lbxOmpgeving.Location = new System.Drawing.Point(435, 176);
            this.lbxOmpgeving.Name = "lbxOmpgeving";
            this.lbxOmpgeving.Size = new System.Drawing.Size(182, 147);
            this.lbxOmpgeving.TabIndex = 31;
            // 
            // cbOmgeving
            // 
            this.cbOmgeving.FormattingEnabled = true;
            this.cbOmgeving.Location = new System.Drawing.Point(435, 85);
            this.cbOmgeving.Name = "cbOmgeving";
            this.cbOmgeving.Size = new System.Drawing.Size(182, 21);
            this.cbOmgeving.TabIndex = 30;
            this.cbOmgeving.SelectedIndexChanged += new System.EventHandler(this.cbOmgeving_SelectedIndexChanged);
            // 
            // lbxBrand
            // 
            this.lbxBrand.FormattingEnabled = true;
            this.lbxBrand.Location = new System.Drawing.Point(637, 176);
            this.lbxBrand.Name = "lbxBrand";
            this.lbxBrand.Size = new System.Drawing.Size(182, 147);
            this.lbxBrand.TabIndex = 33;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(637, 85);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(182, 21);
            this.cbBrand.TabIndex = 32;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // tbMaatregelen
            // 
            this.tbMaatregelen.Location = new System.Drawing.Point(30, 496);
            this.tbMaatregelen.Multiline = true;
            this.tbMaatregelen.Name = "tbMaatregelen";
            this.tbMaatregelen.Size = new System.Drawing.Size(789, 54);
            this.tbMaatregelen.TabIndex = 34;
            // 
            // btnSumit
            // 
            this.btnSumit.Location = new System.Drawing.Point(364, 556);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(75, 23);
            this.btnSumit.TabIndex = 35;
            this.btnSumit.Text = "Opslaan";
            this.btnSumit.UseVisualStyleBackColor = true;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Aard van het werk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Installatie waaraan gewerkt wordt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Omgeving";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Brandbestrijding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "van";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Bijkomende maatregelen";
            // 
            // lbxBrandP
            // 
            this.lbxBrandP.FormattingEnabled = true;
            this.lbxBrandP.Location = new System.Drawing.Point(637, 329);
            this.lbxBrandP.Name = "lbxBrandP";
            this.lbxBrandP.Size = new System.Drawing.Size(182, 147);
            this.lbxBrandP.TabIndex = 49;
            // 
            // lbxOmpgevingP
            // 
            this.lbxOmpgevingP.FormattingEnabled = true;
            this.lbxOmpgevingP.Location = new System.Drawing.Point(435, 329);
            this.lbxOmpgevingP.Name = "lbxOmpgevingP";
            this.lbxOmpgevingP.Size = new System.Drawing.Size(182, 147);
            this.lbxOmpgevingP.TabIndex = 48;
            // 
            // lbxInstallatieP
            // 
            this.lbxInstallatieP.FormattingEnabled = true;
            this.lbxInstallatieP.Location = new System.Drawing.Point(232, 329);
            this.lbxInstallatieP.Name = "lbxInstallatieP";
            this.lbxInstallatieP.Size = new System.Drawing.Size(182, 147);
            this.lbxInstallatieP.TabIndex = 47;
            // 
            // lbxAardP
            // 
            this.lbxAardP.FormattingEnabled = true;
            this.lbxAardP.Location = new System.Drawing.Point(30, 329);
            this.lbxAardP.Name = "lbxAardP";
            this.lbxAardP.Size = new System.Drawing.Size(182, 147);
            this.lbxAardP.TabIndex = 46;
            // 
            // tbAard
            // 
            this.tbAard.Location = new System.Drawing.Point(30, 113);
            this.tbAard.Multiline = true;
            this.tbAard.Name = "tbAard";
            this.tbAard.Size = new System.Drawing.Size(182, 57);
            this.tbAard.TabIndex = 50;
            // 
            // tbIstallatie
            // 
            this.tbIstallatie.Location = new System.Drawing.Point(232, 113);
            this.tbIstallatie.Multiline = true;
            this.tbIstallatie.Name = "tbIstallatie";
            this.tbIstallatie.Size = new System.Drawing.Size(182, 57);
            this.tbIstallatie.TabIndex = 51;
            // 
            // tbOmgeving
            // 
            this.tbOmgeving.Location = new System.Drawing.Point(435, 112);
            this.tbOmgeving.Multiline = true;
            this.tbOmgeving.Name = "tbOmgeving";
            this.tbOmgeving.Size = new System.Drawing.Size(182, 57);
            this.tbOmgeving.TabIndex = 52;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(637, 112);
            this.tbBrand.Multiline = true;
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(182, 57);
            this.tbBrand.TabIndex = 53;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(202, 130);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(24, 23);
            this.btnA.TabIndex = 54;
            this.btnA.Text = "+";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(405, 130);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(24, 23);
            this.btnI.TabIndex = 55;
            this.btnI.Text = "+";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // brnO
            // 
            this.brnO.Location = new System.Drawing.Point(607, 130);
            this.brnO.Name = "brnO";
            this.brnO.Size = new System.Drawing.Size(24, 23);
            this.brnO.TabIndex = 56;
            this.brnO.Text = "+";
            this.brnO.UseVisualStyleBackColor = true;
            this.brnO.Click += new System.EventHandler(this.brnO_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(806, 130);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(24, 23);
            this.btnB.TabIndex = 57;
            this.btnB.Text = "+";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // Vuurvergunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 608);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.brnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbOmgeving);
            this.Controls.Add(this.tbIstallatie);
            this.Controls.Add(this.tbAard);
            this.Controls.Add(this.lbxBrandP);
            this.Controls.Add(this.lbxOmpgevingP);
            this.Controls.Add(this.lbxInstallatieP);
            this.Controls.Add(this.lbxAardP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.tbMaatregelen);
            this.Controls.Add(this.lbxBrand);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.lbxOmpgeving);
            this.Controls.Add(this.cbOmgeving);
            this.Controls.Add(this.lbxInstallatie);
            this.Controls.Add(this.cbInstallatie);
            this.Controls.Add(this.lbxAard);
            this.Controls.Add(this.cbAard);
            this.Controls.Add(this.stpVan);
            this.Controls.Add(this.dtpTot);
            this.Controls.Add(this.dtpDatum);
            this.Name = "Vuurvergunning";
            this.Text = "Vuurvergunning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.DateTimePicker stpVan;
        private System.Windows.Forms.ComboBox cbAard;
        private System.Windows.Forms.ListBox lbxAard;
        private System.Windows.Forms.ListBox lbxInstallatie;
        private System.Windows.Forms.ComboBox cbInstallatie;
        private System.Windows.Forms.ListBox lbxOmpgeving;
        private System.Windows.Forms.ComboBox cbOmgeving;
        private System.Windows.Forms.ListBox lbxBrand;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox tbMaatregelen;
        private System.Windows.Forms.Button btnSumit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxBrandP;
        private System.Windows.Forms.ListBox lbxOmpgevingP;
        private System.Windows.Forms.ListBox lbxInstallatieP;
        private System.Windows.Forms.ListBox lbxAardP;
        private System.Windows.Forms.TextBox tbAard;
        private System.Windows.Forms.TextBox tbIstallatie;
        private System.Windows.Forms.TextBox tbOmgeving;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button brnO;
        private System.Windows.Forms.Button btnB;
    }
}