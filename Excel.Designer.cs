namespace SafeContractorApp
{
    partial class Excel
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
            this.btnExport = new System.Windows.Forms.Button();
            this.vegunning_id = new System.Windows.Forms.CheckBox();
            this.korte_omschrijving = new System.Windows.Forms.CheckBox();
            this.gedetaileerde_omschrijving = new System.Windows.Forms.CheckBox();
            this.optie = new System.Windows.Forms.CheckBox();
            this.aantal_personen = new System.Windows.Forms.CheckBox();
            this.eind_datum = new System.Windows.Forms.CheckBox();
            this.start_datum = new System.Windows.Forms.CheckBox();
            this.extra_uitrustingen = new System.Windows.Forms.CheckBox();
            this.site_id = new System.Windows.Forms.CheckBox();
            this.opdrachtgever_id = new System.Windows.Forms.CheckBox();
            this.voertuig_id = new System.Windows.Forms.CheckBox();
            this.werknemer_id = new System.Windows.Forms.CheckBox();
            this.firma_id = new System.Windows.Forms.CheckBox();
            this.besloten_vergunning_id = new System.Windows.Forms.CheckBox();
            this.open_vergunning_id = new System.Windows.Forms.CheckBox();
            this.vuurvergunning_id = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.lbStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(340, 339);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // vegunning_id
            // 
            this.vegunning_id.AutoSize = true;
            this.vegunning_id.Location = new System.Drawing.Point(12, 37);
            this.vegunning_id.Name = "vegunning_id";
            this.vegunning_id.Size = new System.Drawing.Size(90, 17);
            this.vegunning_id.TabIndex = 1;
            this.vegunning_id.Text = "vegunning_id";
            this.vegunning_id.UseVisualStyleBackColor = true;
            // 
            // korte_omschrijving
            // 
            this.korte_omschrijving.AutoSize = true;
            this.korte_omschrijving.Location = new System.Drawing.Point(12, 75);
            this.korte_omschrijving.Name = "korte_omschrijving";
            this.korte_omschrijving.Size = new System.Drawing.Size(114, 17);
            this.korte_omschrijving.TabIndex = 2;
            this.korte_omschrijving.Text = "korte_omschrijving";
            this.korte_omschrijving.UseVisualStyleBackColor = true;
            // 
            // gedetaileerde_omschrijving
            // 
            this.gedetaileerde_omschrijving.AutoSize = true;
            this.gedetaileerde_omschrijving.Location = new System.Drawing.Point(12, 98);
            this.gedetaileerde_omschrijving.Name = "gedetaileerde_omschrijving";
            this.gedetaileerde_omschrijving.Size = new System.Drawing.Size(154, 17);
            this.gedetaileerde_omschrijving.TabIndex = 3;
            this.gedetaileerde_omschrijving.Text = "gedetaileerde_omschrijving";
            this.gedetaileerde_omschrijving.UseVisualStyleBackColor = true;
            // 
            // optie
            // 
            this.optie.AutoSize = true;
            this.optie.Location = new System.Drawing.Point(12, 121);
            this.optie.Name = "optie";
            this.optie.Size = new System.Drawing.Size(49, 17);
            this.optie.TabIndex = 4;
            this.optie.Text = "optie";
            this.optie.UseVisualStyleBackColor = true;
            // 
            // aantal_personen
            // 
            this.aantal_personen.AutoSize = true;
            this.aantal_personen.Location = new System.Drawing.Point(12, 213);
            this.aantal_personen.Name = "aantal_personen";
            this.aantal_personen.Size = new System.Drawing.Size(105, 17);
            this.aantal_personen.TabIndex = 8;
            this.aantal_personen.Text = "aantal_personen";
            this.aantal_personen.UseVisualStyleBackColor = true;
            // 
            // eind_datum
            // 
            this.eind_datum.AutoSize = true;
            this.eind_datum.Location = new System.Drawing.Point(12, 190);
            this.eind_datum.Name = "eind_datum";
            this.eind_datum.Size = new System.Drawing.Size(81, 17);
            this.eind_datum.TabIndex = 7;
            this.eind_datum.Text = "eind_datum";
            this.eind_datum.UseVisualStyleBackColor = true;
            // 
            // start_datum
            // 
            this.start_datum.AutoSize = true;
            this.start_datum.Location = new System.Drawing.Point(12, 167);
            this.start_datum.Name = "start_datum";
            this.start_datum.Size = new System.Drawing.Size(81, 17);
            this.start_datum.TabIndex = 6;
            this.start_datum.Text = "start_datum";
            this.start_datum.UseVisualStyleBackColor = true;
            // 
            // extra_uitrustingen
            // 
            this.extra_uitrustingen.AutoSize = true;
            this.extra_uitrustingen.Location = new System.Drawing.Point(12, 144);
            this.extra_uitrustingen.Name = "extra_uitrustingen";
            this.extra_uitrustingen.Size = new System.Drawing.Size(109, 17);
            this.extra_uitrustingen.TabIndex = 5;
            this.extra_uitrustingen.Text = "extra_uitrustingen";
            this.extra_uitrustingen.UseVisualStyleBackColor = true;
            // 
            // site_id
            // 
            this.site_id.AutoSize = true;
            this.site_id.Location = new System.Drawing.Point(206, 213);
            this.site_id.Name = "site_id";
            this.site_id.Size = new System.Drawing.Size(56, 17);
            this.site_id.TabIndex = 13;
            this.site_id.Text = "site_id";
            this.site_id.UseVisualStyleBackColor = true;
            // 
            // opdrachtgever_id
            // 
            this.opdrachtgever_id.AutoSize = true;
            this.opdrachtgever_id.Location = new System.Drawing.Point(206, 190);
            this.opdrachtgever_id.Name = "opdrachtgever_id";
            this.opdrachtgever_id.Size = new System.Drawing.Size(109, 17);
            this.opdrachtgever_id.TabIndex = 12;
            this.opdrachtgever_id.Text = "opdrachtgever_id";
            this.opdrachtgever_id.UseVisualStyleBackColor = true;
            // 
            // voertuig_id
            // 
            this.voertuig_id.AutoSize = true;
            this.voertuig_id.Location = new System.Drawing.Point(206, 167);
            this.voertuig_id.Name = "voertuig_id";
            this.voertuig_id.Size = new System.Drawing.Size(78, 17);
            this.voertuig_id.TabIndex = 11;
            this.voertuig_id.Text = "voertuig_id";
            this.voertuig_id.UseVisualStyleBackColor = true;
            // 
            // werknemer_id
            // 
            this.werknemer_id.AutoSize = true;
            this.werknemer_id.Location = new System.Drawing.Point(206, 144);
            this.werknemer_id.Name = "werknemer_id";
            this.werknemer_id.Size = new System.Drawing.Size(92, 17);
            this.werknemer_id.TabIndex = 10;
            this.werknemer_id.Text = "werknemer_id";
            this.werknemer_id.UseVisualStyleBackColor = true;
            // 
            // firma_id
            // 
            this.firma_id.AutoSize = true;
            this.firma_id.Location = new System.Drawing.Point(206, 121);
            this.firma_id.Name = "firma_id";
            this.firma_id.Size = new System.Drawing.Size(62, 17);
            this.firma_id.TabIndex = 9;
            this.firma_id.Text = "firma_id";
            this.firma_id.UseVisualStyleBackColor = true;
            // 
            // besloten_vergunning_id
            // 
            this.besloten_vergunning_id.AutoSize = true;
            this.besloten_vergunning_id.Location = new System.Drawing.Point(403, 213);
            this.besloten_vergunning_id.Name = "besloten_vergunning_id";
            this.besloten_vergunning_id.Size = new System.Drawing.Size(139, 17);
            this.besloten_vergunning_id.TabIndex = 16;
            this.besloten_vergunning_id.Text = "besloten_vergunning_id";
            this.besloten_vergunning_id.UseVisualStyleBackColor = true;
            // 
            // open_vergunning_id
            // 
            this.open_vergunning_id.AutoSize = true;
            this.open_vergunning_id.Location = new System.Drawing.Point(403, 190);
            this.open_vergunning_id.Name = "open_vergunning_id";
            this.open_vergunning_id.Size = new System.Drawing.Size(123, 17);
            this.open_vergunning_id.TabIndex = 15;
            this.open_vergunning_id.Text = "open_vergunning_id";
            this.open_vergunning_id.UseVisualStyleBackColor = true;
            // 
            // vuurvergunning_id
            // 
            this.vuurvergunning_id.AutoSize = true;
            this.vuurvergunning_id.Location = new System.Drawing.Point(403, 167);
            this.vuurvergunning_id.Name = "vuurvergunning_id";
            this.vuurvergunning_id.Size = new System.Drawing.Size(114, 17);
            this.vuurvergunning_id.TabIndex = 14;
            this.vuurvergunning_id.Text = "vuurvergunning_id";
            this.vuurvergunning_id.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "van";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "tot en met";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(213, 37);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(124, 20);
            this.dtpStart.TabIndex = 21;
            // 
            // dtpStop
            // 
            this.dtpStop.CustomFormat = "yyyy-MM-dd";
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStop.Location = new System.Drawing.Point(437, 38);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(124, 20);
            this.dtpStop.TabIndex = 23;
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Location = new System.Drawing.Point(362, 390);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(0, 13);
            this.lbStat.TabIndex = 24;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStat);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.besloten_vergunning_id);
            this.Controls.Add(this.open_vergunning_id);
            this.Controls.Add(this.vuurvergunning_id);
            this.Controls.Add(this.site_id);
            this.Controls.Add(this.opdrachtgever_id);
            this.Controls.Add(this.voertuig_id);
            this.Controls.Add(this.werknemer_id);
            this.Controls.Add(this.firma_id);
            this.Controls.Add(this.aantal_personen);
            this.Controls.Add(this.eind_datum);
            this.Controls.Add(this.start_datum);
            this.Controls.Add(this.extra_uitrustingen);
            this.Controls.Add(this.optie);
            this.Controls.Add(this.gedetaileerde_omschrijving);
            this.Controls.Add(this.korte_omschrijving);
            this.Controls.Add(this.vegunning_id);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Excel";
            this.Text = "Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox vegunning_id;
        private System.Windows.Forms.CheckBox korte_omschrijving;
        private System.Windows.Forms.CheckBox gedetaileerde_omschrijving;
        private System.Windows.Forms.CheckBox optie;
        private System.Windows.Forms.CheckBox aantal_personen;
        private System.Windows.Forms.CheckBox eind_datum;
        private System.Windows.Forms.CheckBox start_datum;
        private System.Windows.Forms.CheckBox extra_uitrustingen;
        private System.Windows.Forms.CheckBox site_id;
        private System.Windows.Forms.CheckBox opdrachtgever_id;
        private System.Windows.Forms.CheckBox voertuig_id;
        private System.Windows.Forms.CheckBox werknemer_id;
        private System.Windows.Forms.CheckBox firma_id;
        private System.Windows.Forms.CheckBox besloten_vergunning_id;
        private System.Windows.Forms.CheckBox open_vergunning_id;
        private System.Windows.Forms.CheckBox vuurvergunning_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Label lbStat;
    }
}