namespace SafeContractorApp
{
    partial class Vergunningen
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
            this.dgvVergunning = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVergunning)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVergunning
            // 
            this.dgvVergunning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVergunning.Location = new System.Drawing.Point(13, 13);
            this.dgvVergunning.Name = "dgvVergunning";
            this.dgvVergunning.Size = new System.Drawing.Size(791, 502);
            this.dgvVergunning.TabIndex = 0;
            // 
            // Vergunningen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.dgvVergunning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vergunningen";
            this.Text = "Vergunningen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVergunning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVergunning;
    }
}