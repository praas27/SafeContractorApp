namespace SafeContractorApp
{
    partial class Print
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
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.nudVergunning = new System.Windows.Forms.NumericUpDown();
            this.nudVuur = new System.Windows.Forms.NumericUpDown();
            this.nudOpen = new System.Windows.Forms.NumericUpDown();
            this.nudGesl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVergunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGesl)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPrinter
            // 
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(12, 23);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(418, 21);
            this.cbPrinter.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::SafeContractorApp.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(156, 102);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 44);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // nudVergunning
            // 
            this.nudVergunning.Location = new System.Drawing.Point(12, 67);
            this.nudVergunning.Name = "nudVergunning";
            this.nudVergunning.Size = new System.Drawing.Size(69, 20);
            this.nudVergunning.TabIndex = 2;
            // 
            // nudVuur
            // 
            this.nudVuur.Location = new System.Drawing.Point(114, 67);
            this.nudVuur.Name = "nudVuur";
            this.nudVuur.Size = new System.Drawing.Size(69, 20);
            this.nudVuur.TabIndex = 3;
            // 
            // nudOpen
            // 
            this.nudOpen.Location = new System.Drawing.Point(217, 67);
            this.nudOpen.Name = "nudOpen";
            this.nudOpen.Size = new System.Drawing.Size(69, 20);
            this.nudOpen.TabIndex = 4;
            // 
            // nudGesl
            // 
            this.nudGesl.Location = new System.Drawing.Point(348, 67);
            this.nudGesl.Name = "nudGesl";
            this.nudGesl.Size = new System.Drawing.Size(69, 20);
            this.nudGesl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "werkvergunning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "vuurvergunning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "openen van leidingen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "besloten ruimtes";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 149);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudGesl);
            this.Controls.Add(this.nudOpen);
            this.Controls.Add(this.nudVuur);
            this.Controls.Add(this.nudVergunning);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbPrinter);
            this.Name = "Print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.nudVergunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGesl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown nudVergunning;
        private System.Windows.Forms.NumericUpDown nudVuur;
        private System.Windows.Forms.NumericUpDown nudOpen;
        private System.Windows.Forms.NumericUpDown nudGesl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}