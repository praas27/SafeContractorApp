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
            ((System.ComponentModel.ISupportInitialize)(this.nudVergunning)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPrinter
            // 
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(24, 23);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(383, 21);
            this.cbPrinter.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(189, 175);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // nudVergunning
            // 
            this.nudVergunning.Location = new System.Drawing.Point(24, 67);
            this.nudVergunning.Name = "nudVergunning";
            this.nudVergunning.Size = new System.Drawing.Size(69, 20);
            this.nudVergunning.TabIndex = 2;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 210);
            this.Controls.Add(this.nudVergunning);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbPrinter);
            this.Name = "Print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.nudVergunning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown nudVergunning;
    }
}