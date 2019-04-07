namespace TaskManager.Source.Forms
{
	partial class SplashForm
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
			if( disposing && (components != null) )
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.labelVersion = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// marqueeProgressBarControl1
			// 
			this.marqueeProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.marqueeProgressBarControl1.EditValue = 0;
			this.marqueeProgressBarControl1.Location = new System.Drawing.Point(0, 234);
			this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
			this.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Office 2010 Black";
			this.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
			this.marqueeProgressBarControl1.Size = new System.Drawing.Size(257, 11);
			this.marqueeProgressBarControl1.TabIndex = 5;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Algerian", 20F);
			this.labelControl2.Location = new System.Drawing.Point(83, 190);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(89, 30);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "PLAZA";
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.AllowFocused = false;
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Properties.ShowMenu = false;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
			this.pictureEdit2.Size = new System.Drawing.Size(233, 180);
			this.pictureEdit2.TabIndex = 9;
			// 
			// labelVersion
			// 
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelVersion.Location = new System.Drawing.Point(0, 216);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(257, 18);
			this.labelVersion.TabIndex = 10;
			this.labelVersion.Text = "version ";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 245);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.marqueeProgressBarControl1);
			this.Name = "SplashForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private System.Windows.Forms.Label labelVersion;
	}
}
