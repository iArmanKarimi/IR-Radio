
namespace IRRadioDesktopWin
{
	partial class ucSoundControls
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			this.btnMute = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.AutoSize = false;
			this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
			this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBarVolume.LargeChange = 10;
			this.trackBarVolume.Location = new System.Drawing.Point(45, 3);
			this.trackBarVolume.Maximum = 100;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(94, 34);
			this.trackBarVolume.SmallChange = 2;
			this.trackBarVolume.TabIndex = 15;
			this.trackBarVolume.Value = 50;
			this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
			// 
			// btnMute
			// 
			this.btnMute.AutoSize = true;
			this.btnMute.BackColor = System.Drawing.Color.SteelBlue;
			this.btnMute.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.btnMute.FlatAppearance.BorderSize = 2;
			this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMute.Image = global::IRRadioDesktopWin.Properties.Resources.icons8_audio_24px;
			this.btnMute.Location = new System.Drawing.Point(3, 3);
			this.btnMute.Name = "btnMute";
			this.btnMute.Size = new System.Drawing.Size(36, 34);
			this.btnMute.TabIndex = 16;
			this.btnMute.UseVisualStyleBackColor = false;
			this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
			// 
			// ucSoundControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.btnMute);
			this.Controls.Add(this.trackBarVolume);
			this.Name = "ucSoundControls";
			this.Size = new System.Drawing.Size(142, 40);
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMute;
		private System.Windows.Forms.TrackBar trackBarVolume;
	}
}
