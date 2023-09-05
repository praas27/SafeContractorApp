namespace SafeContractorApp
{
    partial class Dashbord
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDatabse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lbWelcome.Location = new System.Drawing.Point(310, 171);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(173, 42);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lbHost.Location = new System.Drawing.Point(99, 273);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(105, 42);
            this.lbHost.TabIndex = 1;
            this.lbHost.Text = "Host:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lbUser.Location = new System.Drawing.Point(99, 402);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(107, 42);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User:";
            // 
            // lbDatabse
            // 
            this.lbDatabse.AutoSize = true;
            this.lbDatabse.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lbDatabse.Location = new System.Drawing.Point(99, 331);
            this.lbDatabse.Name = "lbDatabse";
            this.lbDatabse.Size = new System.Drawing.Size(189, 42);
            this.lbDatabse.TabIndex = 3;
            this.lbDatabse.Text = "Database:";
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.lbDatabse);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDatabse;
    }
}