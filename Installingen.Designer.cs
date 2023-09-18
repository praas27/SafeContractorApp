namespace SafeContractorApp
{
    partial class Installingen
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
            this.btnPath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(646, 431);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(22, 23);
            this.btnPath.TabIndex = 18;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Path naar documenten locatie";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(93, 434);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(542, 20);
            this.tbPath.TabIndex = 16;
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(646, 379);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(22, 23);
            this.btnImages.TabIndex = 21;
            this.btnImages.Text = "...";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Path naar Images locatie";
            // 
            // tbImages
            // 
            this.tbImages.Location = new System.Drawing.Point(93, 382);
            this.tbImages.Name = "tbImages";
            this.tbImages.Size = new System.Drawing.Size(542, 20);
            this.tbImages.TabIndex = 19;
            // 
            // Installingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImages);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installingen";
            this.Text = "Installingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImages;
    }
}