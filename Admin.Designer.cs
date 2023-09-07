namespace SafeContractorApp
{
    partial class Admin
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
            this.cbSitenaam = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOpdrachtgever = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVoertuigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWerknemer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.tbGSMnummer_werknemer = new System.Windows.Forms.TextBox();
            this.dtpExamen = new System.Windows.Forms.DateTimePicker();
            this.tbMerk = new System.Windows.Forms.TextBox();
            this.tbGSMnummer_opdrachtgever = new System.Windows.Forms.TextBox();
            this.tbGSMnummer_site = new System.Windows.Forms.TextBox();
            this.tbSiteverantwoordelijke = new System.Windows.Forms.TextBox();
            this.btnDelete_Firma = new System.Windows.Forms.Button();
            this.btnUpdate_Firma = new System.Windows.Forms.Button();
            this.btnAdd_Firma = new System.Windows.Forms.Button();
            this.btnAdd_Werkenemer = new System.Windows.Forms.Button();
            this.btnUpdate_Werknemer = new System.Windows.Forms.Button();
            this.btnDelete_Werknemer = new System.Windows.Forms.Button();
            this.btnAdd_Voertuigen = new System.Windows.Forms.Button();
            this.btnUpdate_Voertuigen = new System.Windows.Forms.Button();
            this.btnDelete_Voertuigen = new System.Windows.Forms.Button();
            this.btnAdd_Opdrachtgever = new System.Windows.Forms.Button();
            this.btnUpdate_Opdrachtgever = new System.Windows.Forms.Button();
            this.btnDelete_Opdrachtgever = new System.Windows.Forms.Button();
            this.btnAdd_Site = new System.Windows.Forms.Button();
            this.btnUpdate_Sitenaam = new System.Windows.Forms.Button();
            this.btnDelete_Site = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNoodnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbSitenaam
            // 
            this.cbSitenaam.AutoSize = true;
            this.cbSitenaam.Location = new System.Drawing.Point(9, 321);
            this.cbSitenaam.Name = "cbSitenaam";
            this.cbSitenaam.Size = new System.Drawing.Size(51, 13);
            this.cbSitenaam.TabIndex = 19;
            this.cbSitenaam.Text = "Sitenaam";
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(12, 337);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(121, 21);
            this.cbSite.TabIndex = 18;
            this.cbSite.SelectedIndexChanged += new System.EventHandler(this.cbSite_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Opdrachtgever";
            // 
            // cbOpdrachtgever
            // 
            this.cbOpdrachtgever.FormattingEnabled = true;
            this.cbOpdrachtgever.Location = new System.Drawing.Point(12, 275);
            this.cbOpdrachtgever.Name = "cbOpdrachtgever";
            this.cbOpdrachtgever.Size = new System.Drawing.Size(121, 21);
            this.cbOpdrachtgever.TabIndex = 16;
            this.cbOpdrachtgever.SelectedIndexChanged += new System.EventHandler(this.cbOpdrachtgever_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Voertuigen";
            // 
            // cbVoertuigen
            // 
            this.cbVoertuigen.FormattingEnabled = true;
            this.cbVoertuigen.Location = new System.Drawing.Point(12, 215);
            this.cbVoertuigen.Name = "cbVoertuigen";
            this.cbVoertuigen.Size = new System.Drawing.Size(121, 21);
            this.cbVoertuigen.TabIndex = 14;
            this.cbVoertuigen.SelectedIndexChanged += new System.EventHandler(this.cbVoertuigen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Werknemer";
            // 
            // cbWerknemer
            // 
            this.cbWerknemer.FormattingEnabled = true;
            this.cbWerknemer.Location = new System.Drawing.Point(12, 153);
            this.cbWerknemer.Name = "cbWerknemer";
            this.cbWerknemer.Size = new System.Drawing.Size(121, 21);
            this.cbWerknemer.TabIndex = 12;
            this.cbWerknemer.SelectedIndexChanged += new System.EventHandler(this.cbWerknemer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firma";
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Location = new System.Drawing.Point(12, 99);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(121, 21);
            this.cbFirma.TabIndex = 10;
            this.cbFirma.SelectedIndexChanged += new System.EventHandler(this.cbFirma_SelectedIndexChanged);
            // 
            // tbGSMnummer_werknemer
            // 
            this.tbGSMnummer_werknemer.Location = new System.Drawing.Point(354, 154);
            this.tbGSMnummer_werknemer.Name = "tbGSMnummer_werknemer";
            this.tbGSMnummer_werknemer.Size = new System.Drawing.Size(137, 20);
            this.tbGSMnummer_werknemer.TabIndex = 22;
            // 
            // dtpExamen
            // 
            this.dtpExamen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamen.Location = new System.Drawing.Point(177, 154);
            this.dtpExamen.Name = "dtpExamen";
            this.dtpExamen.Size = new System.Drawing.Size(143, 20);
            this.dtpExamen.TabIndex = 23;
            this.dtpExamen.Value = new System.DateTime(2023, 8, 31, 0, 0, 0, 0);
            // 
            // tbMerk
            // 
            this.tbMerk.Location = new System.Drawing.Point(177, 215);
            this.tbMerk.Name = "tbMerk";
            this.tbMerk.Size = new System.Drawing.Size(143, 20);
            this.tbMerk.TabIndex = 24;
            // 
            // tbGSMnummer_opdrachtgever
            // 
            this.tbGSMnummer_opdrachtgever.Location = new System.Drawing.Point(177, 276);
            this.tbGSMnummer_opdrachtgever.Name = "tbGSMnummer_opdrachtgever";
            this.tbGSMnummer_opdrachtgever.Size = new System.Drawing.Size(143, 20);
            this.tbGSMnummer_opdrachtgever.TabIndex = 26;
            // 
            // tbGSMnummer_site
            // 
            this.tbGSMnummer_site.Location = new System.Drawing.Point(177, 384);
            this.tbGSMnummer_site.Name = "tbGSMnummer_site";
            this.tbGSMnummer_site.Size = new System.Drawing.Size(143, 20);
            this.tbGSMnummer_site.TabIndex = 29;
            // 
            // tbSiteverantwoordelijke
            // 
            this.tbSiteverantwoordelijke.Location = new System.Drawing.Point(12, 384);
            this.tbSiteverantwoordelijke.Name = "tbSiteverantwoordelijke";
            this.tbSiteverantwoordelijke.Size = new System.Drawing.Size(143, 20);
            this.tbSiteverantwoordelijke.TabIndex = 28;
            // 
            // btnDelete_Firma
            // 
            this.btnDelete_Firma.Location = new System.Drawing.Point(715, 98);
            this.btnDelete_Firma.Name = "btnDelete_Firma";
            this.btnDelete_Firma.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Firma.TabIndex = 20;
            this.btnDelete_Firma.Text = "Delete";
            this.btnDelete_Firma.UseVisualStyleBackColor = true;
            this.btnDelete_Firma.Click += new System.EventHandler(this.btnDelete_Firma_Click);
            // 
            // btnUpdate_Firma
            // 
            this.btnUpdate_Firma.Location = new System.Drawing.Point(622, 97);
            this.btnUpdate_Firma.Name = "btnUpdate_Firma";
            this.btnUpdate_Firma.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Firma.TabIndex = 21;
            this.btnUpdate_Firma.Text = "Update";
            this.btnUpdate_Firma.UseVisualStyleBackColor = true;
            this.btnUpdate_Firma.Click += new System.EventHandler(this.btnUpdate_Firma_Click);
            // 
            // btnAdd_Firma
            // 
            this.btnAdd_Firma.Location = new System.Drawing.Point(525, 98);
            this.btnAdd_Firma.Name = "btnAdd_Firma";
            this.btnAdd_Firma.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Firma.TabIndex = 30;
            this.btnAdd_Firma.Text = "Add";
            this.btnAdd_Firma.UseVisualStyleBackColor = true;
            this.btnAdd_Firma.Click += new System.EventHandler(this.btnAdd_Firma_Click);
            // 
            // btnAdd_Werkenemer
            // 
            this.btnAdd_Werkenemer.Location = new System.Drawing.Point(525, 156);
            this.btnAdd_Werkenemer.Name = "btnAdd_Werkenemer";
            this.btnAdd_Werkenemer.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Werkenemer.TabIndex = 33;
            this.btnAdd_Werkenemer.Text = "Add";
            this.btnAdd_Werkenemer.UseVisualStyleBackColor = true;
            this.btnAdd_Werkenemer.Click += new System.EventHandler(this.btnAdd_Werkenemer_Click);
            // 
            // btnUpdate_Werknemer
            // 
            this.btnUpdate_Werknemer.Location = new System.Drawing.Point(622, 155);
            this.btnUpdate_Werknemer.Name = "btnUpdate_Werknemer";
            this.btnUpdate_Werknemer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Werknemer.TabIndex = 32;
            this.btnUpdate_Werknemer.Text = "Update";
            this.btnUpdate_Werknemer.UseVisualStyleBackColor = true;
            this.btnUpdate_Werknemer.Click += new System.EventHandler(this.btnUpdate_Werknemer_Click);
            // 
            // btnDelete_Werknemer
            // 
            this.btnDelete_Werknemer.Location = new System.Drawing.Point(715, 156);
            this.btnDelete_Werknemer.Name = "btnDelete_Werknemer";
            this.btnDelete_Werknemer.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Werknemer.TabIndex = 31;
            this.btnDelete_Werknemer.Text = "Delete";
            this.btnDelete_Werknemer.UseVisualStyleBackColor = true;
            this.btnDelete_Werknemer.Click += new System.EventHandler(this.btnDelete_Werknemer_Click);
            // 
            // btnAdd_Voertuigen
            // 
            this.btnAdd_Voertuigen.Location = new System.Drawing.Point(523, 212);
            this.btnAdd_Voertuigen.Name = "btnAdd_Voertuigen";
            this.btnAdd_Voertuigen.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Voertuigen.TabIndex = 36;
            this.btnAdd_Voertuigen.Text = "Add";
            this.btnAdd_Voertuigen.UseVisualStyleBackColor = true;
            this.btnAdd_Voertuigen.Click += new System.EventHandler(this.btnAdd_Voertuigen_Click);
            // 
            // btnUpdate_Voertuigen
            // 
            this.btnUpdate_Voertuigen.Location = new System.Drawing.Point(620, 211);
            this.btnUpdate_Voertuigen.Name = "btnUpdate_Voertuigen";
            this.btnUpdate_Voertuigen.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Voertuigen.TabIndex = 35;
            this.btnUpdate_Voertuigen.Text = "Update";
            this.btnUpdate_Voertuigen.UseVisualStyleBackColor = true;
            this.btnUpdate_Voertuigen.Click += new System.EventHandler(this.btnUpdate_Voertuigen_Click);
            // 
            // btnDelete_Voertuigen
            // 
            this.btnDelete_Voertuigen.Location = new System.Drawing.Point(713, 212);
            this.btnDelete_Voertuigen.Name = "btnDelete_Voertuigen";
            this.btnDelete_Voertuigen.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Voertuigen.TabIndex = 34;
            this.btnDelete_Voertuigen.Text = "Delete";
            this.btnDelete_Voertuigen.UseVisualStyleBackColor = true;
            this.btnDelete_Voertuigen.Click += new System.EventHandler(this.btnDelete_Voertuigen_Click);
            // 
            // btnAdd_Opdrachtgever
            // 
            this.btnAdd_Opdrachtgever.Location = new System.Drawing.Point(523, 273);
            this.btnAdd_Opdrachtgever.Name = "btnAdd_Opdrachtgever";
            this.btnAdd_Opdrachtgever.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Opdrachtgever.TabIndex = 39;
            this.btnAdd_Opdrachtgever.Text = "Add";
            this.btnAdd_Opdrachtgever.UseVisualStyleBackColor = true;
            this.btnAdd_Opdrachtgever.Click += new System.EventHandler(this.btnAdd_Opdrachtgever_Click);
            // 
            // btnUpdate_Opdrachtgever
            // 
            this.btnUpdate_Opdrachtgever.Location = new System.Drawing.Point(620, 272);
            this.btnUpdate_Opdrachtgever.Name = "btnUpdate_Opdrachtgever";
            this.btnUpdate_Opdrachtgever.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Opdrachtgever.TabIndex = 38;
            this.btnUpdate_Opdrachtgever.Text = "Update";
            this.btnUpdate_Opdrachtgever.UseVisualStyleBackColor = true;
            this.btnUpdate_Opdrachtgever.Click += new System.EventHandler(this.btnUpdate_Opdrachtgever_Click);
            // 
            // btnDelete_Opdrachtgever
            // 
            this.btnDelete_Opdrachtgever.Location = new System.Drawing.Point(713, 273);
            this.btnDelete_Opdrachtgever.Name = "btnDelete_Opdrachtgever";
            this.btnDelete_Opdrachtgever.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Opdrachtgever.TabIndex = 37;
            this.btnDelete_Opdrachtgever.Text = "Delete";
            this.btnDelete_Opdrachtgever.UseVisualStyleBackColor = true;
            this.btnDelete_Opdrachtgever.Click += new System.EventHandler(this.btnDelete_Opdrachtgever_Click);
            // 
            // btnAdd_Site
            // 
            this.btnAdd_Site.Location = new System.Drawing.Point(523, 382);
            this.btnAdd_Site.Name = "btnAdd_Site";
            this.btnAdd_Site.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Site.TabIndex = 42;
            this.btnAdd_Site.Text = "Add";
            this.btnAdd_Site.UseVisualStyleBackColor = true;
            this.btnAdd_Site.Click += new System.EventHandler(this.btnAdd_Site_Click);
            // 
            // btnUpdate_Sitenaam
            // 
            this.btnUpdate_Sitenaam.Location = new System.Drawing.Point(620, 381);
            this.btnUpdate_Sitenaam.Name = "btnUpdate_Sitenaam";
            this.btnUpdate_Sitenaam.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Sitenaam.TabIndex = 41;
            this.btnUpdate_Sitenaam.Text = "Update";
            this.btnUpdate_Sitenaam.UseVisualStyleBackColor = true;
            this.btnUpdate_Sitenaam.Click += new System.EventHandler(this.btnUpdate_Sitenaam_Click);
            // 
            // btnDelete_Site
            // 
            this.btnDelete_Site.Location = new System.Drawing.Point(713, 382);
            this.btnDelete_Site.Name = "btnDelete_Site";
            this.btnDelete_Site.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Site.TabIndex = 40;
            this.btnDelete_Site.Text = "Delete";
            this.btnDelete_Site.UseVisualStyleBackColor = true;
            this.btnDelete_Site.Click += new System.EventHandler(this.btnDelete_Site_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Merk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "GSM nummer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "siteverantwoordelijke ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Datum examen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "GSM nummer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "GSM nummer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Noondnummer";
            // 
            // tbNoodnummer
            // 
            this.tbNoodnummer.Location = new System.Drawing.Point(348, 384);
            this.tbNoodnummer.Name = "tbNoodnummer";
            this.tbNoodnummer.Size = new System.Drawing.Size(143, 20);
            this.tbNoodnummer.TabIndex = 51;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNoodnummer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd_Site);
            this.Controls.Add(this.btnUpdate_Sitenaam);
            this.Controls.Add(this.btnDelete_Site);
            this.Controls.Add(this.btnAdd_Opdrachtgever);
            this.Controls.Add(this.btnUpdate_Opdrachtgever);
            this.Controls.Add(this.btnDelete_Opdrachtgever);
            this.Controls.Add(this.btnAdd_Voertuigen);
            this.Controls.Add(this.btnUpdate_Voertuigen);
            this.Controls.Add(this.btnDelete_Voertuigen);
            this.Controls.Add(this.btnAdd_Werkenemer);
            this.Controls.Add(this.btnUpdate_Werknemer);
            this.Controls.Add(this.btnDelete_Werknemer);
            this.Controls.Add(this.btnAdd_Firma);
            this.Controls.Add(this.tbGSMnummer_site);
            this.Controls.Add(this.tbSiteverantwoordelijke);
            this.Controls.Add(this.tbGSMnummer_opdrachtgever);
            this.Controls.Add(this.tbMerk);
            this.Controls.Add(this.dtpExamen);
            this.Controls.Add(this.tbGSMnummer_werknemer);
            this.Controls.Add(this.btnUpdate_Firma);
            this.Controls.Add(this.btnDelete_Firma);
            this.Controls.Add(this.cbSitenaam);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOpdrachtgever);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVoertuigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbWerknemer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cbSitenaam;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOpdrachtgever;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVoertuigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWerknemer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.TextBox tbGSMnummer_werknemer;
        private System.Windows.Forms.DateTimePicker dtpExamen;
        private System.Windows.Forms.TextBox tbMerk;
        private System.Windows.Forms.TextBox tbGSMnummer_opdrachtgever;
        private System.Windows.Forms.TextBox tbGSMnummer_site;
        private System.Windows.Forms.TextBox tbSiteverantwoordelijke;
        private System.Windows.Forms.Button btnDelete_Firma;
        private System.Windows.Forms.Button btnUpdate_Firma;
        private System.Windows.Forms.Button btnAdd_Firma;
        private System.Windows.Forms.Button btnAdd_Werkenemer;
        private System.Windows.Forms.Button btnUpdate_Werknemer;
        private System.Windows.Forms.Button btnDelete_Werknemer;
        private System.Windows.Forms.Button btnAdd_Voertuigen;
        private System.Windows.Forms.Button btnUpdate_Voertuigen;
        private System.Windows.Forms.Button btnDelete_Voertuigen;
        private System.Windows.Forms.Button btnAdd_Opdrachtgever;
        private System.Windows.Forms.Button btnUpdate_Opdrachtgever;
        private System.Windows.Forms.Button btnDelete_Opdrachtgever;
        private System.Windows.Forms.Button btnAdd_Site;
        private System.Windows.Forms.Button btnUpdate_Sitenaam;
        private System.Windows.Forms.Button btnDelete_Site;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNoodnummer;
    }
}