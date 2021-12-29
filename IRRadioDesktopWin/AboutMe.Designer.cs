namespace IRRadioDesktopWin
{
	partial class AboutMe
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
			this.labelName = new System.Windows.Forms.Label();
			this.buttonGithub = new System.Windows.Forms.Button();
			this.pictureBoxUser = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelName.Font = new System.Drawing.Font("Courgette", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(111, 11);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(221, 41);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Arman Karimi";
			this.labelName.Click += new System.EventHandler(this.labelProfileName_Click);
			// 
			// buttonGithub
			// 
			this.buttonGithub.BackgroundImage = global::IRRadioDesktopWin.Properties.Resources.icons8_github_48;
			this.buttonGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGithub.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGithub.Location = new System.Drawing.Point(189, 55);
			this.buttonGithub.Name = "buttonGithub";
			this.buttonGithub.Size = new System.Drawing.Size(52, 41);
			this.buttonGithub.TabIndex = 4;
			this.buttonGithub.UseVisualStyleBackColor = true;
			this.buttonGithub.Click += new System.EventHandler(this.buttonGithub_Click);
			// 
			// pictureBoxUser
			// 
			this.pictureBoxUser.BackgroundImage = global::IRRadioDesktopWin.Properties.Resources.icons8_account_64;
			this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxUser.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxUser.Name = "pictureBoxUser";
			this.pictureBoxUser.Size = new System.Drawing.Size(93, 81);
			this.pictureBoxUser.TabIndex = 0;
			this.pictureBoxUser.TabStop = false;
			// 
			// AboutMe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 105);
			this.Controls.Add(this.buttonGithub);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.pictureBoxUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "AboutMe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About me";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutMe_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonGithub;
		private System.Windows.Forms.PictureBox pictureBoxUser;
	}
}