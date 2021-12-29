
namespace IRRadioDesktopWin
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlStations = new System.Windows.Forms.TabControl();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.ucGeneralStations = new IRRadioDesktopWin.ucGeneralStations();
			this.tabPageProvincial = new System.Windows.Forms.TabPage();
			this.ucProvincialStations = new IRRadioDesktopWin.ucProvincialStations();
			this.tabPageNamaa = new System.Windows.Forms.TabPage();
			this.ucNamaaStations = new IRRadioDesktopWin.ucNamaaStations();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.timerRadioReconnect = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxPlayingStationBrand = new System.Windows.Forms.PictureBox();
			this.btnTurnOnOff = new System.Windows.Forms.Button();
			this.pictureBoxPlayingStation = new System.Windows.Forms.PictureBox();
			this.btnAboutMe = new System.Windows.Forms.Button();
			this.ucSoundControls = new IRRadioDesktopWin.ucSoundControls();
			this.tabControlStations.SuspendLayout();
			this.tabPageGeneral.SuspendLayout();
			this.tabPageProvincial.SuspendLayout();
			this.tabPageNamaa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingStationBrand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingStation)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlStations
			// 
			this.tabControlStations.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlStations.Controls.Add(this.tabPageGeneral);
			this.tabControlStations.Controls.Add(this.tabPageProvincial);
			this.tabControlStations.Controls.Add(this.tabPageNamaa);
			this.tabControlStations.Dock = System.Windows.Forms.DockStyle.Right;
			this.tabControlStations.Font = new System.Drawing.Font("IRPooya", 11.5F);
			this.tabControlStations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tabControlStations.Location = new System.Drawing.Point(395, 0);
			this.tabControlStations.Multiline = true;
			this.tabControlStations.Name = "tabControlStations";
			this.tabControlStations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabControlStations.RightToLeftLayout = true;
			this.tabControlStations.SelectedIndex = 0;
			this.tabControlStations.ShowToolTips = true;
			this.tabControlStations.Size = new System.Drawing.Size(221, 313);
			this.tabControlStations.TabIndex = 5;
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.AutoScroll = true;
			this.tabPageGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(200)))), ((int)(((byte)(245)))));
			this.tabPageGeneral.Controls.Add(this.ucGeneralStations);
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 4);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabPageGeneral.Size = new System.Drawing.Size(213, 270);
			this.tabPageGeneral.TabIndex = 0;
			this.tabPageGeneral.Text = "سراسری";
			this.tabPageGeneral.ToolTipText = "ایستگاه های سراسری";
			// 
			// ucGeneralStations
			// 
			this.ucGeneralStations.Brand = null;
			this.ucGeneralStations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucGeneralStations.Location = new System.Drawing.Point(3, 3);
			this.ucGeneralStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.ucGeneralStations.Name = "ucGeneralStations";
			this.ucGeneralStations.Size = new System.Drawing.Size(207, 264);
			this.ucGeneralStations.TabIndex = 0;
			this.ucGeneralStations.Url = null;
			// 
			// tabPageProvincial
			// 
			this.tabPageProvincial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.tabPageProvincial.Controls.Add(this.ucProvincialStations);
			this.tabPageProvincial.Location = new System.Drawing.Point(4, 4);
			this.tabPageProvincial.Name = "tabPageProvincial";
			this.tabPageProvincial.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProvincial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabPageProvincial.Size = new System.Drawing.Size(213, 270);
			this.tabPageProvincial.TabIndex = 1;
			this.tabPageProvincial.Text = "استانی";
			this.tabPageProvincial.ToolTipText = "ایستگاه های استانی";
			// 
			// ucProvincialStations
			// 
			this.ucProvincialStations.Brand = null;
			this.ucProvincialStations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucProvincialStations.Location = new System.Drawing.Point(3, 3);
			this.ucProvincialStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.ucProvincialStations.Name = "ucProvincialStations";
			this.ucProvincialStations.Size = new System.Drawing.Size(207, 264);
			this.ucProvincialStations.TabIndex = 0;
			this.ucProvincialStations.Url = null;
			// 
			// tabPageNamaa
			// 
			this.tabPageNamaa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
			this.tabPageNamaa.Controls.Add(this.ucNamaaStations);
			this.tabPageNamaa.Location = new System.Drawing.Point(4, 4);
			this.tabPageNamaa.Name = "tabPageNamaa";
			this.tabPageNamaa.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNamaa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabPageNamaa.Size = new System.Drawing.Size(213, 270);
			this.tabPageNamaa.TabIndex = 2;
			this.tabPageNamaa.Text = "نما";
			this.tabPageNamaa.ToolTipText = "ایستگاه های نما";
			// 
			// ucNamaaStations
			// 
			this.ucNamaaStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(250)))), ((int)(((byte)(90)))));
			this.ucNamaaStations.Brand = null;
			this.ucNamaaStations.Channel = IRRadioLib.Stations.NamaaStations.Channels.None;
			this.ucNamaaStations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucNamaaStations.Location = new System.Drawing.Point(3, 3);
			this.ucNamaaStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.ucNamaaStations.Name = "ucNamaaStations";
			this.ucNamaaStations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ucNamaaStations.Size = new System.Drawing.Size(207, 264);
			this.ucNamaaStations.TabIndex = 0;
			this.ucNamaaStations.Url = null;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// timerRadioReconnect
			// 
			this.timerRadioReconnect.Interval = 1200;
			this.timerRadioReconnect.Tick += new System.EventHandler(this.TimerRadioReconnect_Tick);
			// 
			// pictureBoxPlayingStationBrand
			// 
			this.pictureBoxPlayingStationBrand.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxPlayingStationBrand.Image = global::IRRadioDesktopWin.Properties.Resources.radio_FM_picture;
			this.pictureBoxPlayingStationBrand.Location = new System.Drawing.Point(296, 219);
			this.pictureBoxPlayingStationBrand.Name = "pictureBoxPlayingStationBrand";
			this.pictureBoxPlayingStationBrand.Size = new System.Drawing.Size(89, 86);
			this.pictureBoxPlayingStationBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPlayingStationBrand.TabIndex = 17;
			this.pictureBoxPlayingStationBrand.TabStop = false;
			// 
			// btnTurnOnOff
			// 
			this.btnTurnOnOff.AutoSize = true;
			this.btnTurnOnOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnTurnOnOff.BackColor = System.Drawing.Color.Transparent;
			this.btnTurnOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTurnOnOff.FlatAppearance.BorderSize = 0;
			this.btnTurnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTurnOnOff.Image = global::IRRadioDesktopWin.Properties.Resources.icons8_shutdown_gray_80px;
			this.btnTurnOnOff.Location = new System.Drawing.Point(193, 219);
			this.btnTurnOnOff.Name = "btnTurnOnOff";
			this.btnTurnOnOff.Size = new System.Drawing.Size(86, 86);
			this.btnTurnOnOff.TabIndex = 15;
			this.btnTurnOnOff.UseVisualStyleBackColor = false;
			this.btnTurnOnOff.Click += new System.EventHandler(this.btnTurnOnOff_Click);
			// 
			// pictureBoxPlayingStation
			// 
			this.pictureBoxPlayingStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxPlayingStation.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBoxPlayingStation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayingStation.Image")));
			this.pictureBoxPlayingStation.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxPlayingStation.Name = "pictureBoxPlayingStation";
			this.pictureBoxPlayingStation.Size = new System.Drawing.Size(395, 214);
			this.pictureBoxPlayingStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxPlayingStation.TabIndex = 12;
			this.pictureBoxPlayingStation.TabStop = false;
			// 
			// btnAboutMe
			// 
			this.btnAboutMe.BackColor = System.Drawing.Color.Transparent;
			this.btnAboutMe.BackgroundImage = global::IRRadioDesktopWin.Properties.Resources.icons8_info_64;
			this.btnAboutMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAboutMe.Location = new System.Drawing.Point(0, 278);
			this.btnAboutMe.Name = "btnAboutMe";
			this.btnAboutMe.Size = new System.Drawing.Size(35, 35);
			this.btnAboutMe.TabIndex = 19;
			this.btnAboutMe.UseVisualStyleBackColor = false;
			this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
			// 
			// ucSoundControls
			// 
			this.ucSoundControls.AutoSize = true;
			this.ucSoundControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ucSoundControls.BackColor = System.Drawing.Color.Transparent;
			this.ucSoundControls.Location = new System.Drawing.Point(41, 241);
			this.ucSoundControls.Name = "ucSoundControls";
			this.ucSoundControls.Size = new System.Drawing.Size(142, 40);
			this.ucSoundControls.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(202)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(616, 313);
			this.Controls.Add(this.btnAboutMe);
			this.Controls.Add(this.ucSoundControls);
			this.Controls.Add(this.pictureBoxPlayingStationBrand);
			this.Controls.Add(this.btnTurnOnOff);
			this.Controls.Add(this.pictureBoxPlayingStation);
			this.Controls.Add(this.tabControlStations);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IRRadio رادیو ایران";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControlStations.ResumeLayout(false);
			this.tabPageGeneral.ResumeLayout(false);
			this.tabPageProvincial.ResumeLayout(false);
			this.tabPageNamaa.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingStationBrand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingStation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControlStations;
		private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.TabPage tabPageProvincial;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.PictureBox pictureBoxPlayingStation;
		private System.Windows.Forms.TabPage tabPageNamaa;
		private ucNamaaStations ucNamaaStations;
		private ucProvincialStations ucProvincialStations;
		private ucGeneralStations ucGeneralStations;
		private System.Windows.Forms.Button btnTurnOnOff;
		private System.Windows.Forms.PictureBox pictureBoxPlayingStationBrand;
		private ucSoundControls ucSoundControls;
		private System.Windows.Forms.Timer timerRadioReconnect;
		private System.Windows.Forms.Button btnAboutMe;
	}
}

