namespace TaskManager.Source.Forms
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.loginEdit = new DevExpress.XtraEditors.TextEdit();
			this.passwordEdit = new DevExpress.XtraEditors.TextEdit();
			this.btn = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// loginEdit
			// 
			this.loginEdit.Location = new System.Drawing.Point(12, 28);
			this.loginEdit.Name = "loginEdit";
			this.loginEdit.Size = new System.Drawing.Size(122, 20);
			this.loginEdit.TabIndex = 0;
			// 
			// passwordEdit
			// 
			this.passwordEdit.Location = new System.Drawing.Point(12, 72);
			this.passwordEdit.Name = "passwordEdit";
			this.passwordEdit.Properties.PasswordChar = '*';
			this.passwordEdit.Size = new System.Drawing.Size(122, 20);
			this.passwordEdit.TabIndex = 1;
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(12, 98);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(122, 23);
			this.btn.TabIndex = 2;
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TaskManager.Properties.Settings.Default, "UserPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.labelControl2.Location = new System.Drawing.Point(12, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(37, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = global::TaskManager.Properties.Settings.Default.UserPassword;
			// 
			// labelControl1
			// 
			this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TaskManager.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(93, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = global::TaskManager.Properties.Settings.Default.UserName;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(149, 135);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.passwordEdit);
			this.Controls.Add(this.loginEdit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit loginEdit;
		private DevExpress.XtraEditors.TextEdit passwordEdit;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton btn;
	}
}