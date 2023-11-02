namespace WFA_MysqlTeszt
{
    partial class main
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
            this.username = new System.Windows.Forms.Label();
            this.telNumb = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(61, 60);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 16);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // telNumb
            // 
            this.telNumb.AutoSize = true;
            this.telNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telNumb.Location = new System.Drawing.Point(61, 88);
            this.telNumb.Name = "telNumb";
            this.telNumb.Size = new System.Drawing.Size(86, 16);
            this.telNumb.TabIndex = 2;
            this.telNumb.Text = "Telephone:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gender.Location = new System.Drawing.Point(61, 120);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(62, 16);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.telNumb);
            this.Controls.Add(this.username);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu | by Sango";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label telNumb;
        private System.Windows.Forms.Label gender;
    }
}